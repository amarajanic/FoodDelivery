using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodDeliveryUI
{
    public partial class Home : Form
    {
        public event EventHandler UgasiProgram;
       
        public Home(string user)
        {
            InitializeComponent();
            sidePanel1.Height = btnHome.Height;
            sidePanel1.Top = btnHome.Top;
            firstCustomUserControl1.BringToFront();
            lblUserName.Text = user;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
            this.Close();
            CloseAll();


            
        }
        public void CloseAll()
        {
            UgasiProgram?.Invoke(this, null);
        }

        private void lblRights_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            sidePanel1.Height = btnHome.Height;
            sidePanel1.Top = btnHome.Top;
            firstCustomUserControl1.BringToFront();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            sidePanel1.Height = btnOrder.Height;
            sidePanel1.Top = btnOrder.Top;
            secondCustomUserControl1.BringToFront();
           
           
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            
          pictureBox2.BackColor = Color.Silver;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
           pictureBox2.BackColor = Color.White;
        }

        private void secondCustomUserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
