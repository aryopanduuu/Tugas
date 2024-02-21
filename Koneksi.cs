using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiroomB
{
    public class Koneksi
    {
        public static MySqlConnection conn;
        public static void Connection()
        {
            string connStr = "" +
                "server=127.0.0.1;user=root;database=md;password=;";

            try
            {
                conn = new MySqlConnection(connStr);
                conn.Open();
                MessageBox.Show("Connection Open");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
