using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryLibrary
{
   public class Hrana
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public double Cijena { get; set; }

        public string Restoran { get; set; }
        public string Narucioc { get; set; }
        public string BrojTelefona { get; set; }
        public string NazivCijena
        {
            get { return $"{Naziv} ({Cijena} KM)"; }
        }

    }
}
