using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace ProiectASD
{
    public partial class Form3 : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;

        public void deschideBD()
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename='D:\Programe VS\ProiectASD\ProiectASD\AgentieIMOBILE.mdf';Integrated Security=True";
            con.Open();
        }
        public void umpledgv()
        {
            deschideBD();
            string AcceseazaImobile;
            AcceseazaImobile = "SELECT * FROM IMOBILE";
            da = new SqlDataAdapter(AcceseazaImobile, con);
            ds = new DataSet();
            da.Fill(ds, "imobile");
            con.Close();
            imobile.DataSource = ds.Tables["imobile"];
            imobile.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            deschideBD();
            string AcceseazaCereri;
            AcceseazaCereri = "SELECT * FROM Cereri";
            da = new SqlDataAdapter(AcceseazaCereri, con);
            da.Fill(ds, "cereri");
            con.Close();
            cereri.DataSource = ds.Tables["cereri"];
            cereri.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            deschideBD();
            string AcceseazaContracte;
            AcceseazaContracte = "SELECT * FROM Contracte";
            da = new SqlDataAdapter(AcceseazaContracte, con);
            da.Fill(ds, "Contracte");
            con.Close();
            contracte.DataSource = ds.Tables["Contracte"];
            contracte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        public Form3()
        {
            InitializeComponent();
            umpledgv();

        }

        private void addIMOB_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(STRimob.Text)==false && String.IsNullOrEmpty(NRimob.Text)==false && String.IsNullOrEmpty(ORASimob.Text)==false && SUPRimob.Value!=0 && CAMimob.Value !=0 && PRETimob.Value != 0)
            {
                deschideBD();
                string insIMB = "INSERT INTO IMOBILE VALUES ('" + STRimob.Text + "','" + NRimob.Text + "','" + SUPRimob.Value + "','" + CAMimob.Value + "','" + ETimob.Value + "','" + ORASimob.Text + "','" + PRETimob.Value + "' )";
                SqlCommand insertImobil = new SqlCommand(insIMB,con);
                insertImobil.ExecuteNonQuery();
                con.Close();
                umpledgv();
                MessageBox.Show("Imobilul a fost adaugat cu succes!");
                
            }
            else
            {
                MessageBox.Show("Nu ati completat toate campurile!!");
            }
        }

        private void updateIMOB_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(stradaImobil.Text) == false && String.IsNullOrEmpty(nrImobil.Text) == false)
            {
                deschideBD();
                string updatepret = "UPDATE IMOBILE SET Pret = '" + PretNou.Value + "' WHERE upper(Strada) = '" + stradaImobil.Text + "' AND Numar = '" + nrImobil.Text + "'";
                SqlCommand update = new SqlCommand(updatepret, con);
                update.ExecuteNonQuery();
                con.Close();
                umpledgv();

                MessageBox.Show("Pret updatat cu succes!");
            }
            else
            {
                MessageBox.Show("Nu ati completat strada sau numarul imobilului");
            }
        }

        private void Sterge_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(stradaImobil.Text) == false && String.IsNullOrEmpty(nrImobil.Text) == false)
            {
                deschideBD();
                string sterge = "DELETE FROM IMOBILE WHERE upper(Strada) = '" + stradaImobil.Text + "' AND Numar = '" + nrImobil.Text + "'";
                SqlCommand delete = new SqlCommand(sterge, con);
                delete.ExecuteNonQuery();
                con.Close();
                umpledgv();
                MessageBox.Show("Imobil sters!");
                
            }
            else
            {
                MessageBox.Show("Nu ati completat strada sau numarul imobilului");
            }
        }
        public int generateId()
        {
            deschideBD();
            string ids = "SELECT (Nr_Contract) FROM Contracte";
            da = new SqlDataAdapter(ids, con);
            da.Fill(ds, "nrC");
            con.Close();
            int nr = ds.Tables["nrC"].Rows.Count;
            nr++;
            ds.Tables["nrC"].Reset();
            List<int> numere = new List<int>();
            foreach (DataRow dr in ds.Tables["nrC"].Rows)
            {
                numere.Add(Convert.ToInt32(dr.ItemArray.GetValue(0)));
            }
            if(numere.Contains(nr)==true)
            {
                do
                {
                    nr++;
                }
                while (numere.Contains(nr) == true);
            }
            return nr;
        }

        private void CreazaC_Click(object sender, EventArgs e)
        {
            DialogResult confirmare = MessageBox.Show("Sunteti sigur ca ati selectat cererea si imobilul corespunzator din tabele?", "Confirm", MessageBoxButtons.YesNo);
            if (confirmare == DialogResult.Yes)
                {
                    int inregCurentaimob = imobile.CurrentCell.RowIndex;
                    DataGridViewRow randimob = imobile.Rows[inregCurentaimob];
                    int inregCurentacer = cereri.CurrentCell.RowIndex;
                    DataGridViewRow randcer = cereri.Rows[inregCurentacer];

                    string imobil = randimob.Cells[0].Value.ToString() + " " + randimob.Cells[1].Value.ToString();
                    string numeprenclient = randcer.Cells[1].Value.ToString() + " " + randcer.Cells[2].Value.ToString();
                    string creazaContract = "INSERT INTO Contracte VALUES('" + generateId() + "','" + numeprenclient + "','" + randcer.Cells[3].Value.ToString() + "','" + imobil + "')";
                    deschideBD();
                    SqlCommand ccontr = new SqlCommand(creazaContract, con);
                    ccontr.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Contract Creat!");
                }

            umpledgv();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            this.Hide();
            frm1.ShowDialog();
        }

        
    }
}
