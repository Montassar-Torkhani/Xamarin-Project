using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace EXAMAN_TP.Profile
{
    public class ProductV
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string CodProd { get; set; }
        public string Title { get; set;  }
        public string Description { get; set; }
        public string category { get; set; }
        public string ImageUri { get; set; }
        public double Price { get; set; }

    }
}
