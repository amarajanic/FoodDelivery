using FoodDeliveryLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodDeliveryUI
{
    public partial class RestaurantLogin : Form
    {
        RestoranDashBoard frm = new RestoranDashBoard();
        public RestaurantLogin()
        {
            InitializeComponent();
        }

        private void linkRestaurant_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            List<Restoran> restorani = KonekcijaNaBazu.LoadRestorani();

            if (string.IsNullOrWhiteSpace(txtRest.Text) || string.IsNullOrWhiteSpace(txtPass.Text))
            {
                MessageBox.Show("Username or Password is not in a correct format!");
                return;
            }


            foreach (var restoran in restorani)
            {
                if (restoran.NazivLogin == txtRest.Text && restoran.Sifra == txtPass.Text)
                {

                    this.Visible = false;
                    //UserName = txtUser.Text;
                    frm.ShowDialog();
                    return;
                }
            }
            MessageBox.Show("Username or Password is incorrect");
        }
    }
}
