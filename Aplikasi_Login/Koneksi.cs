using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikasi_Login
{
    class Koneksi
    {
        public static MySqlConnection Connection = null;

        public static MySqlConnection GetConnection()
        {
            if (Connection == null)
            {
                string constring = "Server=localhost; Database=db_login; Uid=root; Pwd=;";
                Connection = new MySqlConnection(constring);
                Connection.Open(); // Buka koneksi saat pertama kali dibuat
            }
            else if (Connection.State != System.Data.ConnectionState.Open)
            {
                Connection.Open(); // Buka koneksi jika belum terbuka
            }
            return Connection;
        }

        public static void Disconnect()
        {
            if (Connection != null && Connection.State != ConnectionState.Closed)
            {
                Connection.Close();
                Console.WriteLine("Koneksi Ditutup");
            }
        }
    }
}
