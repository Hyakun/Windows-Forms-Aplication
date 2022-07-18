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
    public partial class Form2 : Form
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

        public Form2()
        {
            deschideBD();
            string AcceseazaImobile;
            AcceseazaImobile = "SELECT * FROM IMOBILE";
            da = new SqlDataAdapter(AcceseazaImobile, con);
            ds = new DataSet();
            da.Fill(ds, "imobile");
            con.Close();
            
            InitializeComponent();
            foreach (DataRow dr in ds.Tables["imobile"].Rows)
            {
                string imobil = dr.ItemArray.GetValue(1) + " " + dr.ItemArray.GetValue(0) + " Suprafata " + dr.ItemArray.GetValue(2) + " Camere " + dr.ItemArray.GetValue(3) + " Etaj " + dr.ItemArray.GetValue(4) + " Oras " + dr.ItemArray.GetValue(5) + " Pret " + dr.ItemArray.GetValue(6);               
                IMOBILE.Items.Add(imobil + "");
            }

        }

        private void butonlogout_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            this.Hide();
            frm1.ShowDialog();

        }

        private void filtru_Click(object sender, EventArgs e)
        {
            DataTable dt = ds.Tables["imobile"];

            if(suprafata1.Value!=0 && suprafata2.Value!=0)
            {
                foreach(DataRow dr in dt.Rows)
                {
                    
                    if(Convert.ToInt32(dr.ItemArray.GetValue(2)) < Convert.ToInt32(suprafata1.Value) || Convert.ToInt32(dr.ItemArray.GetValue(2))> Convert.ToInt32(suprafata2.Value))
                    {
                        dr.Delete();
                    }                 
                }

                dt.AcceptChanges();
                
            }
            

            if(camere1.Value!=0 && camere2.Value!=0)
            {
                foreach (DataRow dr in dt.Rows)
                {

                    if (Convert.ToInt32(dr.ItemArray.GetValue(3)) < Convert.ToInt32(camere1.Value) || Convert.ToInt32(dr.ItemArray.GetValue(3)) > Convert.ToInt32(camere2.Value))
                    {
                        dr.Delete();
                    }
                }

                dt.AcceptChanges();
                
            }
            if (etaj1.Value != 0 && etaj2.Value != 0)
            {
                foreach (DataRow dr in dt.Rows)
                {

                    if (Convert.ToInt32(dr.ItemArray.GetValue(4)) < Convert.ToInt32(etaj1.Value) || Convert.ToInt32(dr.ItemArray.GetValue(4)) > Convert.ToInt32(etaj2.Value))
                    {
                        dr.Delete();
                    }
                }

                dt.AcceptChanges();

            }
            if (String.IsNullOrEmpty(oras.Text) == false)
            {
                foreach (DataRow dr in dt.Rows)
                {

                    if (dr.ItemArray.GetValue(5).ToString().ToUpper() != oras.Text.ToUpper())
                    {
                        dr.Delete();
                    }
                }

                dt.AcceptChanges();

            }
            if (camere1.Value != 0 && camere2.Value != 0)
            {
                foreach (DataRow dr in dt.Rows)
                {

                    if (Convert.ToInt32(dr.ItemArray.GetValue(6)) < Convert.ToInt32(pret1.Value) || Convert.ToInt32(dr.ItemArray.GetValue(6)) > Convert.ToInt32(pret2.Value))
                    {
                        dr.Delete();
                    }
                }

                dt.AcceptChanges();

            }

            if (String.IsNullOrEmpty(strada.Text) == false)
            {
                foreach (DataRow dr in dt.Rows)
                {

                    if (dr.ItemArray.GetValue(0).ToString().ToUpper() != strada.Text.ToUpper())
                    {
                        dr.Delete();
                    }
                }

                dt.AcceptChanges();

            }



            IMOBILE.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                string imobil = dr.ItemArray.GetValue(1) + " " + dr.ItemArray.GetValue(0) + " Suprafata " + dr.ItemArray.GetValue(2) + " Camere " + dr.ItemArray.GetValue(3) + " Etaj " + dr.ItemArray.GetValue(4) + " Oras " + dr.ItemArray.GetValue(5) + " Pret " + dr.ItemArray.GetValue(6);
                IMOBILE.Items.Add(imobil + "");
            }

        }
        public int generateId()
        {
            deschideBD();
            string ids = "SELECT (Nr) FROM Cereri";
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
            if (numere.Contains(nr) == true)
            {
                do
                {
                    nr++;
                }
                while (numere.Contains(nr) == true);
            }
            return nr;
        }

        private void creazaC_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(nume.Text) == false || String.IsNullOrEmpty(prenume.Text) == false || String.IsNullOrEmpty(cnp.Text) == false || String.IsNullOrEmpty(IMOBILE.SelectedItem.ToString()) == false)
            {  
                string adaugaCerere = "INSERT INTO Cereri VALUES('" + generateId() + "','" + nume.Text + "','" + prenume.Text + "','" + cnp.Text + "','" + IMOBILE.SelectedItem.ToString() + "')";
                deschideBD();
                SqlCommand insert = new SqlCommand(adaugaCerere, con);
                insert.ExecuteNonQuery();
                MessageBox.Show("Cererea a fost trimisa!");
                con.Close();
            }
            else
                MessageBox.Show("Nu ati completat toate casutele sau nu ati selectat imobilul");
        }


    }
}
