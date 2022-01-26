using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodDeliveryUI
{
    public partial class SecondCustomUserControl : UserControl
    {
        public SecondCustomUserControl()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            GusarForm frm = new GusarForm();

            frm.ShowDialog();
           



        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            KorzoForm frm = new KorzoForm();

            frm.ShowDialog();
        }
    }
}
