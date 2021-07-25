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
    public partial class Select : Form
    {
        public Select()
        {
            InitializeComponent();
        }

        

        private void btn_pharmacy_Click(object sender, EventArgs e)
        {
            pharmacy newForm = new pharmacy();
            this.Hide();

            newForm.ShowDialog();
            this.Close();
        }

        private void btn_stock_Click(object sender, EventArgs e)
        {
            Stock newForm = new Stock();
            this.Hide();

            newForm.ShowDialog();
            this.Close();
        }

        private void btn_channel_KeyDown(object sender, KeyEventArgs e)
        {
            btn_channel.PerformClick();

            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }

        }

        private void btn_channel_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void btn_pharmacy_KeyDown(object sender, KeyEventArgs e)
        {
            btn_pharmacy.PerformClick();
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void btn_stock_KeyDown(object sender, KeyEventArgs e)
        {
            btn_stock.PerformClick();
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void btn_channel_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();
            this.Hide();

            newForm.ShowDialog();
            this.Close();
        }

        private void Select_Load(object sender, EventArgs e)
        {

        }
    }
}
