using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using Dapper;

namespace FoodDeliveryLibrary
{
    public class KonekcijaNaBazu
    {
        public static List<Narucioc> LoadNarucioci()
        {
            using(IDbConnection db = new SQLiteConnection(GetConnectionString("FoodDeliveryCnn")))
            {
              var output =  db.Query<Narucioc>("select * from Narucioc", new DynamicParameters()).ToList();
                return output;
            } 
        }

        public static List<Narudzba> LoadNarudzbe()
        {
            using (IDbConnection db = new SQLiteConnection(GetConnectionString("FoodDeliveryCnn")))
            {
                var output = db.Query<Narudzba>("select * from Narudzba", new DynamicParameters()).ToList();
                return output;
            }
        }

        public static void DeleteNarudzba(Narudzba narudzba)
        {
            using (IDbConnection db = new SQLiteConnection(GetConnectionString("FoodDeliveryCnn")))
            {
               // db.Execute("delete from Narudzba where NarudzbaId in ("+narudzba.Id+");", narudzba);
                //DELETE FROM "main"."Narudzba" WHERE _rowid_ IN ('1');

            }
        }

        public static List<Restoran> LoadRestorani()
        {
            using (IDbConnection db = new SQLiteConnection(GetConnectionString("FoodDeliveryCnn")))
            {
                var output = db.Query<Restoran>("select * from Restorani", new DynamicParameters()).ToList();
                return output;
            }
        }

        public static void SaveNarucioc(Narucioc narucioc)
        {
            using(IDbConnection db = new SQLiteConnection(GetConnectionString("FoodDeliveryCnn")))
            {
                db.Execute("insert into Narucioc (Ime, Prezime, BrojTelefona, UserName, PassWord) values (@Ime, @Prezime, @BrojTelefona, @UserName, @PassWord)",narucioc);
            }
        }

        public static void SaveOrder(Hrana hrana)
        {
            using (IDbConnection db = new SQLiteConnection(GetConnectionString("FoodDeliveryCnn")))
            {
                db.Execute("insert into Narudzba (Opis, Restoran, Narucioc , BrojTelefona) values (@Naziv, @Restoran, @Narucioc, @BrojTelefona)", hrana);
            }
        }





        public static string GetConnectionString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
