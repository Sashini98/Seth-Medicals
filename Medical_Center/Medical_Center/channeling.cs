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
    public partial class Form3 : Form
    {
        double ID = 00001;
        public static string bill = "";
        public static string date = "";
        public static string name = "";
        public static string age = "";
        public static string gender = "";
        public static string cf = "";
        public static string mf = "";
        public static string stot = "";
        public static string discount = "";
        public static string total1 = "";

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            lblId.Text = Convert.ToString(ID);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c,d,dis,tot,total;

            a = System.Convert.ToDouble(txtCF.Text);
            b = System.Convert.ToDouble(txtMF.Text);
            c = System.Convert.ToDouble(txtDisR.Text);

            tot = a + b;

            d = c / 100;
            dis = (tot * d);

            total = tot - dis;

            txtSub.Text = System.Convert.ToString(tot);
            txtDis.Text = System.Convert.ToString(dis);
            txtTot.Text = System.Convert.ToString(total);

            try
            {
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\kasun\Desktop\final project\Medical.mdb");



                string query = "Insert into Channeling values ('" +lblId.Text+"','"+ dateTimePicker1.Text + "','" + txtName.Text + "','" + txtage.Text + "','" + txtGender.Text + "','" +txtDes.Text+"','"+ txtCF.Text + "','" + txtMF.Text + "','" + txtDisR.Text + "','" + txtSub.Text + "','" + txtDis.Text + "','" + txtTot.Text + "')";
                OleDbCommand cmd = new OleDbCommand(query, con);



                con.Open();

                cmd.ExecuteNonQuery();

               
                con.Close();

                bill=lblId.Text;
                date=dateTimePicker1.Text;
                name = txtName.Text;
                age=txtage.Text ;
                gender=txtGender.Text ;
               
                cf=txtCF.Text;
                mf=txtMF.Text;
                stot=txtSub.Text;
                discount=txtDis.Text;
                total1 = txtTot.Text;


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ID++;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtGender.Text = "Male";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtGender.Text = "Female";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Select newForm = new Select();
            this.Hide();

            newForm.ShowDialog();
            this.Close();
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void radioButton2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void radioButton1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }

        }

        private void txtCF_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtMF_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtDisR_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            button1.PerformClick();
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtDisR.Clear();
            txtSub.Clear();
            txtDis.Clear();
            txtTot.Clear();
            txtName.Clear();
            txtage.Clear();
            txtGender.Clear();
            txtCF.Clear();
            txtMF.Clear();
            txtDes.Clear();

            lblId.Text = Convert.ToString(ID);
            

        }

        private void txtage_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Channel_Bill newForm = new Channel_Bill();
            this.Hide();

            newForm.ShowDialog();
            this.Close();
         }

        public void txtName_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
