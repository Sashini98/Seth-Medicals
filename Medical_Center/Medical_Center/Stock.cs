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
    public partial class Stock : Form
    {
        public Stock()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
           
            this.stockTableAdapter2.Fill(this.medicalDataSet9.Stock);
            
            this.stockTableAdapter1.Fill(this.medicalDataSet6.Stock);
           
            this.stockTableAdapter.Fill(this.medicalDataSet4.Stock);


            try
            {

                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\kasun\Desktop\final project\Medical.mdb");


                string query = "select ID from stock where Quantity<=10";
                OleDbCommand cmd = new OleDbCommand(query, con);
                OleDbDataReader read;

                

                    con.Open();
                    read = cmd.ExecuteReader();


                    while (read.Read())
                    {
                        string m_id = read["ID"].ToString();
                        MessageBox.Show("Stock less then 10 :"+m_id);




                    }
                    con.Close();
                    

                }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            

       
              
            




        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Select newForm = new Select();
            this.Hide();

            newForm.ShowDialog();
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\kasun\Desktop\final project\Medical.mdb");

           
           
            OleDbDataAdapter adapt;
            DataTable dt;

      
            con.Open();
            adapt = new OleDbDataAdapter("select * from stock where Description like '" + txtName.Text + "%'", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

                    

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSrch_Click(object sender, EventArgs e)
        {

            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\kasun\Desktop\final project\Medical.mdb");



            OleDbDataAdapter adapt;
            DataTable dt;


            con.Open();
            adapt = new OleDbDataAdapter("select * from stock where Name like '" + txtBName.Text + "%'", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

           
        }

        private void btnSearch_KeyDown(object sender, KeyEventArgs e)
        {
            btnSearch.PerformClick();
        }

        private void btnSrch_KeyDown(object sender, KeyEventArgs e)
        {
            btnSrch.PerformClick();
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtBName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtBName_Click(object sender, EventArgs e)
        {
        
            txtName.Clear();
            dataGridView1.Refresh();

        }

        private void txtName_Click(object sender, EventArgs e)
        {
            txtBName.Clear();
            dataGridView1.Refresh();
        }
    }
}
