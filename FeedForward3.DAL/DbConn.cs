using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using MySql.Data.MySqlClient;

namespace FeedForward3.DAL
{
    class DbConn
    {
        static string connectionString = "Server=studmysql01.fhict.local;Uid=dbi437096;Database=dbi437096;Pwd=admin;";
        public static MySqlConnection connection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
