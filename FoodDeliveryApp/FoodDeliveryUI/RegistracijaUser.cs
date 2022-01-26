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
    public partial class RegistracijaUser : Form
    {
        public RegistracijaUser()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Narucioc n = new Narucioc();

            if(!string.IsNullOrEmpty(txtIme.Text))
            {
                n.Ime = txtIme.Text;
            }
            else
            {
                MessageBox.Show("Please insert valid first name!");
            }

            if (!string.IsNullOrEmpty(txtPrezime.Text))
            {
                n.Prezime = txtPrezime.Text;
            }
            else
            {
                MessageBox.Show("Please insert valid last name!");
            }

            if (!string.IsNullOrEmpty(txtBrTel.Text))
            {
                n.BrojTelefona = txtBrTel.Text;
            }
            else
            {
                MessageBox.Show("Please insert valid phone number!");
            }

            if (!string.IsNullOrEmpty(txtUser.Text))
            {
                n.UserName = txtUser.Text;
            }
            else
            {
                MessageBox.Show("Please insert valid user name!");
            }


            if (!string.IsNullOrEmpty(txtPass.Text))
            {
                n.PassWord = txtPass.Text;
            }
            else
            {
                MessageBox.Show("Please insert valid password!");
            }


            
            if(n.Ime != null && n.Prezime!=null && n.BrojTelefona!=null && n.UserName!=null && n.PassWord!=null)
            {
                KonekcijaNaBazu.SaveNarucioc(n);
                this.Close();
            }

            
        }
    }
}
