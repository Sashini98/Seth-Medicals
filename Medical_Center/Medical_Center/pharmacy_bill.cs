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
    public partial class pharmacy_bill : Form
    {
        public pharmacy_bill()
        {
            InitializeComponent();
        }

        private void pharmacy_bill_Load(object sender, EventArgs e)
        {
            gridview_data();
            dataGridView1.Refresh();

            lblBill.Text = pharmacy.bill;
            lblDate.Text = pharmacy.date;
            lblStot.Text = pharmacy.stot;
            lblDis.Text = pharmacy.discount;
            lblTot.Text = pharmacy.total1;
            
            
            this.billTableAdapter2.Fill(this.medicalDataSet14.Bill);
          
            this.billTableAdapter1.Fill(this.medicalDataSet11.Bill);

            this.billTableAdapter.Fill(this.medicalDataSet10.Bill);

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pharmacy_bill_KeyDown(object sender, KeyEventArgs e)
        { }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern long BitBlt(IntPtr hdcDest, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, int dwRop);
        private Bitmap memoryImage;

        private void PrintScreen()
        {
            Graphics mygraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, mygraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            IntPtr dc1 = mygraphics.GetHdc();
            IntPtr dc2 = memoryGraphics.GetHdc();
            BitBlt(dc2, 0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height, dc1, 0, 0, 13369376);
            mygraphics.ReleaseHdc(dc1);
            memoryGraphics.ReleaseHdc(dc2);
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

        private void pharmacy_bill_MouseClick(object sender, MouseEventArgs e)
        {

            PrintScreen();
            printPreviewDialog1.ShowDialog();

            try
            {
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\kasun\Desktop\final project\Medical.mdb");



                string query = "delete * from Bill";
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

       

        private void pharmacy_bill_FormClosed(object sender, FormClosedEventArgs e)
        {
            pharmacy newForm = new pharmacy();
            this.Hide();

            newForm.ShowDialog();
            this.Close();
        }


    }
}
