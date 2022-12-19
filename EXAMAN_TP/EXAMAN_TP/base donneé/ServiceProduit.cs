using EXAMAN_TP.Profile;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace EXAMAN_TP.base_donneé
{
    class ServiceProduit
    {
        public List<ProductV> GetProd()
        {
            DataBase usersBase = new DataBase();
            SQLiteConnection conn = usersBase.connection;
            return conn.Table<ProductV>().ToList();
        }

        public int insertProd(ProductV a)
        {
            DataBase usersBase = new DataBase();
            SQLiteConnection conn = usersBase.connection;
            return conn.Insert(a);
        }

        public bool FindIProd(string LogName)
        {
            DataBase usersBase = new DataBase();
            SQLiteConnection conn = usersBase.connection;

            var Listexiste = conn.Query<ProductV>("SELECT * FROM Users WHERE Email = ?", LogName);
            if (Listexiste.Count == 0) { return false; } else { return true; }
        }


        public bool UpdatProd(ProductV a)
        {
            DataBase usersBase = new DataBase();
            SQLiteConnection conn = usersBase.connection;
            Console.WriteLine("old etat: " + a.Id  ) ;
            
             return conn.Update(a) > 0;
        }

        public int DeletProd(ProductV a)
        {
            DataBase usersBase = new DataBase();
            SQLiteConnection conn = usersBase.connection;
            return conn.Delete(a);
        }


        public bool FindProductV(string LogName)
        {
            DataBase usersBase = new DataBase();
            SQLiteConnection conn = usersBase.connection;

            var Listexiste = conn.Query<ProductV>("SELECT * FROM ProductV WHERE Title = ?", LogName);
            if (Listexiste.Count == 0) { return false; } else { return true; }
        }

        public List<ProductV> FindObj(string LogName)
        {
            DataBase usersBase = new DataBase();
            SQLiteConnection conn = usersBase.connection;

            var Listexiste = conn.Query<ProductV>("SELECT * FROM ProductV WHERE Email = ?", LogName);
            return Listexiste;

        }


        public List<ProductV> GetProduitByCategorie(String catg)
        {
            DataBase usersBase = new DataBase();
            SQLiteConnection conn = usersBase.connection;
            var Listexiste = conn.Query<ProductV>("SELECT * FROM ProductV WHERE category = ?", catg);
            return Listexiste;
        }


    }
}

