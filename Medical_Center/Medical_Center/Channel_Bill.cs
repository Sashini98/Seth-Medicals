using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medical_Center
{
    public partial class Channel_Bill : Form
    {
        public Channel_Bill()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e) { }

        public void label3_Click(object sender, EventArgs e) { }

        public void lblName_Click(object sender, EventArgs e)
        {

        }

        private void Channel_Bill_Load(object sender, EventArgs e)
        {
            lblBill.Text = Form3.bill;
            lblDate.Text = Form3.date;
            lblName.Text = Form3.name;
            lblAge.Text = Form3.age;
            lblGender.Text = Form3.gender;
            lblCF.Text = Form3.cf;
            lblMF.Text = Form3.mf;
            lblSTot.Text = Form3.stot;
            lblDis.Text = Form3.discount;
            lblTot.Text = Form3.total1;
        }

        private void lblDate_Click(object sender, EventArgs e)
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

        private void Channel_Bill_KeyDown(object sender, KeyEventArgs e)
        {
            PrintScreen();
            printPreviewDialog1.ShowDialog();
        }

        private void Channel_Bill_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form3 newForm = new Form3();
            this.Hide();

            newForm.ShowDialog();
            this.Close();
        }  
    }
}
