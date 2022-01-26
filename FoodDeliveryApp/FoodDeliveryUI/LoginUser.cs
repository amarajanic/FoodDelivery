using FoodDeliveryLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodDeliveryUI
{
    public partial class LoginUser : Form
    {
        Home frm = new Home(UserName);
        public static string UserName { get; set; } = "";
        public LoginUser()
        {
            InitializeComponent();
            frm.UgasiProgram += Frm_UgasiProgram;
           
        }

        private void Frm_UgasiProgram(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Narucioc> narucioci = KonekcijaNaBazu.LoadNarucioci();

            if(string.IsNullOrWhiteSpace(txtUser.Text) || string.IsNullOrWhiteSpace(txtPass.Text))
            {
                MessageBox.Show("Username or Password is not in a correct format!");
                return;
            }

            
            foreach (var narucioc in narucioci)
            {
                if(narucioc.UserName == txtUser.Text && narucioc.PassWord == txtPass.Text)
                {
                    
                    this.Visible = false;
                    UserName = txtUser.Text;
                    frm = new Home(UserName);
                    frm.ShowDialog();
                    return;
                }
            }
            MessageBox.Show("Username or Password is incorrect");


        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistracijaUser frm = new RegistracijaUser();

            frm.ShowDialog();
        }

        private void linkRestaurant_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RestaurantLogin frm = new RestaurantLogin();

            frm.ShowDialog();
        }
    }
}
