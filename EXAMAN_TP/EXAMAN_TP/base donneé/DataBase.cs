using EXAMAN_TP.Profile;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace EXAMAN_TP.base_donneé
{
    class DataBase
    {
        public SQLiteConnection connection { get; set; }

        public DataBase()
        {
            initialise();
        }

        private void initialise()
        {
            connection = new SQLiteConnection(DbConstants.DataBasePath, SQLiteOpenFlags.Create | SQLiteOpenFlags.ReadWrite);
            connection.CreateTable<Admin>(CreateFlags.None);
            connection.CreateTable<ProductV>(CreateFlags.None);
        }

       

    }
}
