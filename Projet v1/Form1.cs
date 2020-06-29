using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_v1
{
   
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        Boolean a = true;
        public static String myuser;
        public Form1()
        {
            InitializeComponent(); }

        public SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-UHKDEM5\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=projet");




        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {

            if (a == true) {
                metroLabel1.Visible = false;
                metroLabel2.Visible = false;
                AdminPW.Visible = true;
                AdminUS.Visible = true;
                US.Visible = false;
                PS.Visible = false;
                AdminUStext.Visible = true;
                AdminPWtext.Visible = true;
                AdminLogin.Visible = true;
                Login.Visible = false;
                a = false;

            }
            else
            {
                metroLabel1.Visible = true;
                metroLabel2.Visible = true;
                AdminPW.Visible = false;
                AdminUS.Visible = false;
                US.Visible = true;
                PS.Visible = true;
                AdminUStext.Visible = false;
                AdminPWtext.Visible = false;
                Login.Visible = true;
                AdminLogin.Visible = false;
                a = true;
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Hide();
            using (Form f = new Register())
                f.ShowDialog();
            Show();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from client where codec='" + US.Text + "' and password1 ='" + PS.Text + "';", con);
            IDataReader rd = cmd.ExecuteReader();

            if (!rd.Read())
                MessageBox.Show("le client n'existe pas");

            else
            {
                MessageBox.Show("Connected");
               
                myuser = US.Text;
                 Hide(); 
                 using (Form f = new Information())
                     f.ShowDialog();
                 Show();
                rd.Close();
            }
            rd.Close();
            con.Close();

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Hide();
            using (Form f = new Metro())
                f.ShowDialog();
            Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select codec from client ",con) ;
            SqlDataReader rd = cmd.ExecuteReader();
            
            while (rd.Read())
            {
               
                richTextBox1.Text += Environment.NewLine + rd.GetString(0);
                
                // Waela rd.getint32 ken bech tejbed entier
            }
            
            rd.Close();
            con.Close();
            MessageBox.Show(con.State + "");
        }
    }
}
