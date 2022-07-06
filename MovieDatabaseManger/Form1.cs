using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace MovieDatabaseManger
{
    public partial class Form1 : Form
    {
        public static string linuser;
        public Form1()
        {
            InitializeComponent();
        }

        private void UserLoginBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = UserLoginBox.Text;
            string password = PasswordBox.Text;

            var conn = new SqliteConnection("Data Source=MovieDatabase.db; Pooling=False");
            conn.Open();

            if (username != "" && password != "")
            {
                string stm = "SELECT * FROM Users WHERE User_Name='" + username + "' AND User_Password='" + password + "' LIMIT 1";
                using var cmd = new SqliteCommand(stm, conn);

                using SqliteDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    if (rdr.GetString(1) != username && rdr.GetString(2) != password)
                    {
                        DialogResult res = MessageBox.Show("Username or Password is incorrect!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (rdr.GetString(3) == "1")
                    {
                        DialogResult res = MessageBox.Show("Your user account has been banned from SHU Movies!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (rdr.GetInt32(4) == 1)
                    {
                        var m = new AdminMainPage();
                        linuser = rdr.GetString(1);
                        m.Show();
                        this.Hide();
                    }
                    else if (rdr.GetInt32(4) == 0)
                    {
                        linuser = rdr.GetString(1);
                        var m = new UserMainPage();
                        m.Show();
                        this.Hide();
                    }
                }
            }
            else
            {
                DialogResult res = MessageBox.Show("Username or Password must not be blank", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SHUMoviesLogo_Click(object sender, EventArgs e)
        {

        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            var m = new SignUp();
            m.Show();
            this.Hide();
        }
    }
}