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
    public partial class Form4 : Form
    {
        SqlConnection con;

        public void deschideBD()
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename='D:\Programe VS\ProiectASD\ProiectASD\AgentieIMOBILE.mdf';Integrated Security=True";
            con.Open();
        }

        public Form4()
        {
            InitializeComponent();
        }
        public char tip()
        {
            char tip;
            if(admin.Checked==true)
            {
                tip = 'A';
            }
            else
            {
                tip = 'C';
            }
            return tip;
        }

        private void cc_Click(object sender, EventArgs e)
        {
            deschideBD();
            string creazacont = "INSERT INTO CONTURI VALUES ('"+ nume.Text+ "','"+parola.Text+"','" + tip() + "')";
            SqlCommand creaza = new SqlCommand(creazacont, con);
            creaza.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Cont creat cu succes!");

        }

        private void meniu_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            this.Hide();
            frm1.ShowDialog();
        }
    }
}
