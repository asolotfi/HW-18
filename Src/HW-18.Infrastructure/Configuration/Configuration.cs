﻿namespace HW_18.Infrastructure.Configuration
{
    public class Configuration
    {
        public static string configurationstring { get; set; }
        static Configuration()
        {
            //configurationstring = "Data Source=ASO-LOTFI\\SQLEXPRESS;Initial Catalog=LibraryDb;Integrated Security=True;TrustServerCertificate=True";
            //configurationstring = "Data Source=ASO\\SQLEXPRESS;Initial Catalog=LibraryDbcw13;Integrated Security=True;TrustServerCertificate=True";
            configurationstring = "Data Source= ASO-LOTFI\\SQLEXPRESS;Initial Catalog=Shopping;Integrated Security=True;TrustServerCertificate=True";
        }
    }
}
