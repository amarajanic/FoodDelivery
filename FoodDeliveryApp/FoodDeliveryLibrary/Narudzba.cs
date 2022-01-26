using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryLibrary
{
    public class Narudzba
    {
        public int Id { get; set; }
        public string Opis { get; set; }
      
       
        public string Restoran { get; set; }
        public string Narucioc { get; set; }
        public string BrojTelefona { get; set; }

        public string JeloNaruciocBrojTel {
            get
            {
                return $"{Opis} | {Narucioc} ({BrojTelefona})";
            }
        }
    }
}
