using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace InventorySolutions
{
    public class DatabaseConnection
    {
        public MySqlConnection DBConnect;
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter da = new MySqlDataAdapter();
        //MySqlDataReader dr = new MySqlDataReader();
        DataTable dt = new DataTable();

        public MySqlConnection DBConnection()
        {
            string connectionString = "datasource=localhost;username=root;password=;database=inventorysolution; SSLmode=none;";
            DBConnect = new MySqlConnection(connectionString);

            try
            {
                DBConnect.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return DBConnect;
        }
    }
}
