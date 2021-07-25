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
    public partial class pharmacy : Form
    {
        double price = 0;
        double qt;
        double ID = 00001;
        double q, ne;
        string name1;

        public static string bill = ""; 
        public static string date = "";
        public static string stot = "";
        public static string discount = "";
        public static string total1 = "";
        double q1, aqty;


        public pharmacy()
        {
            InitializeComponent();
            this.Text = "Pharmacy";

        }

        private void btn_tot_Click(object sender, EventArgs e) { }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Select newForm = new Select();
            this.Hide();

            newForm.ShowDialog();
            this.Close();
        }

        private void txtId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtDose_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtQty_KeyDown(object sender, KeyEventArgs e)
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

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtId_Leave(object sender, EventArgs e)
        {
            try
            {


                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\kasun\Desktop\final project\Medical.mdb");



                string query = "select * from stock where ID=" + txtId.Text;
                OleDbCommand cmd = new OleDbCommand(query, con);
                OleDbDataReader read;



                con.Open();
                read = cmd.ExecuteReader();

                while (read.Read())
                {

                    txtUPrice.Text = read["Price"].ToString();
                }
                con.Close();



            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {

                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\kasun\Desktop\final project\Medical.mdb");


                string query = "select * from stock where ID=" + txtId.Text;
                OleDbCommand cmd = new OleDbCommand(query, con);
                OleDbDataReader read;



                con.Open();
                read = cmd.ExecuteReader();

                while (read.Read())
                {
                    txtQAv.Text = read["Quantity"].ToString();

                    qt = System.Convert.ToInt64(txtQAv.Text);
                    
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        private void button1_Click_1(object sender, EventArgs e)
        {
            double c, d, dis, total;

            c = System.Convert.ToDouble(txtDisR.Text);

            d = c / 100;
            dis = (price * d);

            total = price - dis;

            txtSub.Text = System.Convert.ToString(price);
            txtDis.Text = System.Convert.ToString(dis);
            txtTot.Text = System.Convert.ToString(total);



            try
            {
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\kasun\Desktop\final project\Medical.mdb");



                string query = "Insert into Pharmacy values ('" + lblId.Text + "','" + dateTimePicker1.Text + "','" + txtDisR.Text + "','" + txtSub.Text + "','" + txtDis.Text + "','" + txtTot.Text + "')";
                OleDbCommand cmd = new OleDbCommand(query, con);



                con.Open();

                cmd.ExecuteNonQuery();

               
                con.Close();

                bill = lblId.Text;
                date = dateTimePicker1.Text;
                stot = txtSub.Text;
                discount = txtDis.Text;
                total1 = txtTot.Text;


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            

            ID++;


         
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medicalDataSet13.Bill' table. You can move, or remove it, as needed.
            this.billTableAdapter2.Fill(this.medicalDataSet13.Bill);
            // TODO: This line of code loads data into the 'medicalDataSet12.Bill' table. You can move, or remove it, as needed.
            this.billTableAdapter1.Fill(this.medicalDataSet12.Bill);
          
            lblId.Text = Convert.ToString(ID);

            this.billTableAdapter.Fill(this.medicalDataSet7.Bill);
            gridview_data();

        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            
            double pr;
            pr = System.Convert.ToDouble(txtPrice.Text);

            price = price + pr;

            MessageBox.Show("Added");

            try
            {

                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\kasun\Desktop\final project\Medical.mdb");


                string query = "select Name from stock where ID=" + txtId.Text;
                OleDbCommand cmd = new OleDbCommand(query, con);
                OleDbDataReader read;



                con.Open();
                read = cmd.ExecuteReader();

                while (read.Read())
                {
                    name1 = read["Name"].ToString();

                    

                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\kasun\Desktop\final project\Medical.mdb");


                con.Open();
                dataGridView1.Refresh();

                string query = "Insert into Bill values ('" + txtId.Text + "','" +name1+"','"+ txtQty.Text + "','" + txtPrice.Text + "')";
                OleDbCommand cmd = new OleDbCommand(query, con);

                


                cmd.ExecuteNonQuery();
                
                con.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            try
            {
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\kasun\Desktop\final project\Medical.mdb");



                string query = "Insert into PharmacyStock values ('" + lblId.Text + "','" + dateTimePicker1.Text + "','" + txtId.Text + "','" + txtQty.Text +"')";
                OleDbCommand cmd = new OleDbCommand(query, con);



                con.Open();

                cmd.ExecuteNonQuery();


                con.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            txtId.Clear();
            txtQty.Clear();
            txtUPrice.Clear();
            txtPrice.Clear();
            txtQAv.Clear();

        }

        private void txtQty_Leave(object sender, EventArgs e)
        {
           

            double u, p;
            q1 = System.Convert.ToDouble(txtQty.Text);
            u = System.Convert.ToDouble(txtUPrice.Text);

            p = q1 * u;

            txtPrice.Text = System.Convert.ToString(p);

            try
            {
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\kasun\Desktop\final project\Medical.mdb");

                q = System.Convert.ToInt32(txtQty.Text);

                ne = qt - q;

                string query = "update stock set Quantity=" +ne+" where ID=" + txtId.Text;
                OleDbCommand cmd = new OleDbCommand(query, con);
                 con.Open();

                cmd.ExecuteNonQuery();

                con.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
        }

        private void txtPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                    SendKeys.Send("{TAB}");
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        public void gridview_data()
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\kasun\Desktop\final project\Medical.mdb");

            con.Open();

            OleDbDataAdapter da = new OleDbDataAdapter("select * from Bill", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Bill");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Bill";
            con.Close();


        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtQty.Clear();
            txtUPrice.Clear();
            txtPrice.Clear();
            txtQAv.Clear();
            txtDisR.Clear();
            txtSub.Clear();
            txtDis.Clear();
            txtTot.Clear();


            lblId.Text = Convert.ToString(ID);
        }

        private void btnEnter_KeyDown(object sender, KeyEventArgs e)
        {
            btnEnter.PerformClick();
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            gridview_data();
            dataGridView1.Refresh();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtUPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
          pharmacy_bill newForm = new pharmacy_bill();
            this.Hide();

            newForm.ShowDialog();
            this.Close();
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {

           
           aqty = System.Convert.ToDouble(txtQAv.Text);



            if (q>aqty)
            {
                MessageBox.Show("Quantity limit exceeded");
            }
        }

        private void txtUPrice_TextChanged(object sender, EventArgs e)
        {
          
        }

    }
    




}
