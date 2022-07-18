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
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;

        public Form1()
        {
            InitializeComponent();
        }

        public void deschideBD()
        {
            con = new SqlConnection();
            con.ConnectionString =@"Data Source=(LocalDB)\v11.0;AttachDbFilename='D:\Programe VS\ProiectASD\ProiectASD\AgentieIMOBILE.mdf';Integrated Security=True";
            con.Open();
        }

        public bool verificaLOGIN(string nume, string parola)
        {
            deschideBD();
            string AcceseazaConturi;
            AcceseazaConturi = "SELECT * FROM CONTURI";
            da = new SqlDataAdapter(AcceseazaConturi, con);
            ds = new DataSet();
            da.Fill(ds, "conturi");
            con.Close();

            int a = 0;

            foreach (DataRow dr in ds.Tables["conturi"].Rows)
            {
                if (nume.ToUpper() == dr.ItemArray.GetValue(0).ToString().ToUpper() && parola == dr.ItemArray.GetValue(1).ToString())
                {
                    a++;
                    
                }
                
            }

            if (a != 0)
            {
                return true;
            }
            else return false;
        }

        public char getTip(string nume, string parola)
        {
            char tip = 'n';
            foreach (DataRow dr in ds.Tables["conturi"].Rows)
            {
                if (nume.ToUpper() == dr.ItemArray.GetValue(0).ToString().ToUpper() && parola == dr.ItemArray.GetValue(1).ToString())
                {
                    tip = Convert.ToChar(dr.ItemArray.GetValue(2));
                }
            }




            return tip;
        }


        private void Login_Click(object sender, EventArgs e)
        {
            if(verificaLOGIN(NumeUtilizator.Text,Parola.Text)==true)
            {
                if (getTip(NumeUtilizator.Text, Parola.Text)=='C')
                {
                Form2 frm2 = new Form2();
                this.Hide();
                frm2.ShowDialog();
                }
                else
                {
                Form3 frm3 = new Form3();
                this.Hide();
                    frm3.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Nume sau parola gresita!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            

            

        }

        private void creazaCont_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            this.Hide();
            frm4.ShowDialog();
        }
    }
}
