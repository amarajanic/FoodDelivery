using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using FoodDeliveryLibrary;

namespace FoodDeliveryUI
{
    public partial class GusarPage : UserControl
    {
        List<Hrana> Menu = new List<Hrana>();

        public GusarPage()
        {
            InitializeComponent();
            PopulateMenu();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        void PopulateMenu()
        {
            Menu.Add(new Hrana { Id = 1, Naziv = "Pizza Margherita", Cijena = 6,Restoran="Pizzeria Gusar"});
            Menu.Add(new Hrana { Id = 2, Naziv = "Pizza Capriciosa", Cijena = 8 , Restoran = "Pizzeria Gusar" });
            Menu.Add(new Hrana { Id = 3, Naziv = "Pizza Al Tonno", Cijena = 9 , Restoran = "Pizzeria Gusar" });
            Menu.Add(new Hrana { Id = 4, Naziv = "Pizza Bianca", Cijena = 5 , Restoran = "Pizzeria Gusar"});
            Menu.Add(new Hrana { Id = 5, Naziv = "Pizza Popeye", Cijena = 7 , Restoran = "Pizzeria Gusar"});
            Menu.Add(new Hrana { Id = 6, Naziv = "Pizza Egg is Okay", Cijena = 10 , Restoran = "Pizzeria Gusar" });
            Menu.Add(new Hrana { Id = 7, Naziv = "Pizza Funghi", Cijena = 7 , Restoran = "Pizzeria Gusar" });
            Menu.Add(new Hrana { Id = 8, Naziv = "Pizza Ultra Meat", Cijena = 11 , Restoran = "Pizzeria Gusar"  });
            


            lbMenu.DataSource = Menu;
            lbMenu.DisplayMember = "NazivCijena";
        }

        private void cbMarSmall_CheckedChanged(object sender, EventArgs e)
        {
          


        }

        private void cbMarLarge_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

          
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Hrana hrana = lbMenu.SelectedItem as Hrana;

            var result=MessageBox.Show("Are you sure you want to order "+hrana.NazivCijena+"?","Food Order",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                hrana.Narucioc = tbImePrezime.Text;
                hrana.BrojTelefona = tbCell.Text;

                if (!string.IsNullOrEmpty(tbImePrezime.Text) && !string.IsNullOrEmpty(tbCell.Text))
                {
                    KonekcijaNaBazu.SaveOrder(hrana);
                    MessageBox.Show("You have succesfully ordered " + hrana.Naziv + "!");
                }

                else
                {
                    MessageBox.Show("Please enter valid Name or Phone number !");
                }
            }
            
        }
    }
}
