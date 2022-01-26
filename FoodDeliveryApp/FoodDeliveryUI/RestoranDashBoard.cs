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
    public partial class RestoranDashBoard : Form
    {
        List<Narudzba> narudzbe = KonekcijaNaBazu.LoadNarudzbe();
        public RestoranDashBoard()
        {
            InitializeComponent();

            PopulateNarudzbe();
           
        }

        void PopulateNarudzbe()
        {
            lbNarudzbe.DataSource = narudzbe;
            lbNarudzbe.DisplayMember = "JeloNaruciocBrojTel";
        }

        private void lbNarudzbe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnFinishOrder_Click(object sender, EventArgs e)
        {
            foreach(var narudzba in narudzbe)
            {
                if (lbNarudzbe.SelectedItem==narudzba)
                {
                    narudzbe.Remove(narudzba);
                    lbNarudzbe.DataSource = null;
                    lbNarudzbe.DataSource = narudzbe;
                    lbNarudzbe.DisplayMember = "JeloNaruciocBrojTel";
                    //KonekcijaNaBazu.DeleteNarudzba(narudzba);
                    return;


                }

            }
        }
    }
}
