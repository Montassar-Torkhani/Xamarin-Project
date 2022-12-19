using EXAMAN_TP.Profile;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace EXAMAN_TP.base_donneé
{
    class Service
    {

        public List<Admin> GetUsers()
        {
            DataBase usersBase = new DataBase();
            SQLiteConnection conn = usersBase.connection;
            return conn.Table<Admin>().ToList();
        }

        public int insertUsers(Admin a)
        {
            DataBase usersBase = new DataBase();
            SQLiteConnection conn = usersBase.connection;
            return conn.Insert(a);
        }

        public bool FindInscri(string LogName)
        {
            DataBase usersBase = new DataBase();
            SQLiteConnection conn = usersBase.connection;

            var Listexiste = conn.Query<Admin>("SELECT * FROM Users WHERE Email = ?", LogName);
            if (Listexiste.Count == 0) { return false; } else { return true; }
        }


        public int UpdateUsers(Admin a)
        {
            DataBase usersBase = new DataBase();
            SQLiteConnection conn = usersBase.connection;
            return conn.Update(a);
        }

        public int DeletUsers(Admin a)
        {
            DataBase usersBase = new DataBase();
            SQLiteConnection conn = usersBase.connection;
            return conn.Delete(a);
        }


        public bool FindAdmin(string LogName)
        {
            DataBase usersBase = new DataBase();
            SQLiteConnection conn = usersBase.connection;

            var Listexiste = conn.Query<Admin>("SELECT * FROM Admin WHERE Email = ?", LogName);
            if (Listexiste.Count == 0) { return false; } else { return true; }
        }

        public List<Admin> FindObj(string LogName)
        {
            DataBase usersBase = new DataBase();
            SQLiteConnection conn = usersBase.connection;

            var Listexiste = conn.Query<Admin>("SELECT * FROM Admin WHERE Email = ?", LogName);
            return Listexiste ;
            
        }

        public bool FindAdminPwd(string LogName, string pname)
        {
            DataBase usersBase = new DataBase();
            SQLiteConnection conn = usersBase.connection;

            var Listexiste = conn.Query<Admin>("SELECT * FROM Admin WHERE Email = ? and Password = ?", LogName, pname);
            if (Listexiste.Count == 0) { return false; } else { return true; }
        }


        public bool UpdateMP(string LogName, String PSW)
        {
            DataBase usersBase = new DataBase();
            SQLiteConnection conn = usersBase.connection;

            var Listexiste = conn.Execute("UPDATE Admin SET Password = ? WHERE Email = ? ", PSW, LogName);
            if (Listexiste == 0) { return false; } else { return true; }
        }

    }
}
