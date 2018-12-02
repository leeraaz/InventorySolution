using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySolutions
{
    public partial class LoginPanel : Form
    {
        DatabaseConnection db = new DatabaseConnection();
        public LoginPanel()
        {
            InitializeComponent();
            txtUser.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPwd.Text;

            db.DBConnect = db.DBConnection();
            DataTable tbl = new DataTable();
            MySqlDataAdapter adpt = new MySqlDataAdapter("select Username,Password from staff where Username ='" + user + "' and Password ='" + pass + "'", db.DBConnect);
            
            adpt.Fill(tbl);
            if(tbl.Rows.Count > 0)
            {
                string uname, upwd;
                uname = tbl.Rows[0][0].ToString();
                upwd = tbl.Rows[0][1].ToString();
                if (uname == user && upwd == pass)
                {
                    //MessageBox.Show("Your username is " + uname + " and password is " +upwd);
                    Form1 mainform = new Form1();
                    mainform.Show();
                    this.Hide();
                }    
            }
            else
            {
                MessageBox.Show("Incorrect username and password.");
            }
        }

        private void LoginPanel_Load(object sender, EventArgs e)
        {
            txtUser.Focus();
        }
    }
}
