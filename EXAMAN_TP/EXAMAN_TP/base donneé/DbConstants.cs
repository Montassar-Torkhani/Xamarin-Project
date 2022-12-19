using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EXAMAN_TP.base_donneé
{
    class DbConstants
    {

        private static string DbFileName = "exmtp.db";

        public static string DataBasePath

        {
            get
            {
                string basfolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                return Path.Combine(basfolder, DbFileName);
            }

        }
    }
}
