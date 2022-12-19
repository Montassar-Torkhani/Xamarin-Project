using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace EXAMAN_TP.Profile
{
    class Admin
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone_Number { get; set; }
    }
}
