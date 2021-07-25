using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Medical_Center
{
    public partial class Front : Form
    {
      

        public Front()
        {
            InitializeComponent();
            this.Text = "Front";
           
        }


           


        private void Form1_Load(object sender, EventArgs e)
        {
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;


        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            


            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\kasun\Desktop\final project\Medical.mdb");
            string query = "SELECT * FROM login where name='" + txt_user.Text + "' AND password='" + txt_password.Text + "'";

            OleDbCommand cmd = new OleDbCommand(query, con);

            con.Open();
            OleDbDataReader dr = cmd.ExecuteReader() ;


            int count = 0;



            while (dr.Read())
            {
                count=count+1;

            }

            if (count == 1)
            {
                timer1.Start();
            }
            
            
            else
            {
                MessageBox.Show("Sorry, your login information is not correct. Please try again.");
            }


            con.Close();
        }

        


        private void timer1_Tick(object sender, EventArgs e)
        {

            progressBar1.Increment(1);

            if (progressBar1.Value == 10)
            {
                label2.Text = "Loading Database...";
            }

            else if (progressBar1.Value == 40)
            {
                label2.Text = "Starting Modules...";
            }

            else if (progressBar1.Value == 60)
            {
                label2.Text = "Successfully Loaded.";
            }
            else if (progressBar1.Value == 100)
            {
                timer1.Stop();
                MessageBox.Show("Logged In");

                Select newForm = new Select();
                this.Hide();

                newForm.ShowDialog();
                this.Close();
            }
        }

        private void txt_user_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void btn_login_KeyDown(object sender, KeyEventArgs e)
        {
           btn_login.PerformClick();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
