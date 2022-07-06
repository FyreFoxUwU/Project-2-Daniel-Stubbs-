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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void SHUMoviesLogo_Click(object sender, EventArgs e)
        {

        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            string username = UserText.Text;
            string password = PassText.Text;
            string confirmpassword = PassConfirmText.Text;

            var conn = new SqliteConnection("Data Source=MovieDatabase.db; Pooling=False");
            conn.Open();

            string Movies = "SELECT * FROM Users WHERE User_Name = '"+ username + "' LIMIT 1";
            using var cmd = new SqliteCommand(Movies, conn);

            using SqliteDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                if (rdr.GetString(1) == username)
                {
                    DialogResult res = MessageBox.Show("Username is taken", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            conn.Close();
            if (username == "")
            {
                DialogResult res = MessageBox.Show("Username must not be blank", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (password == "" || confirmpassword == "")
            {
                DialogResult res = MessageBox.Show("Password must not be blank", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (password != confirmpassword)
            {
                DialogResult res = MessageBox.Show("Passwords do not match", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (password.Length < 9)
            {
                DialogResult res = MessageBox.Show("Password must be more than 8 characters", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var cons = new SqliteConnection("Data Source=MovieDatabase.db; Pooling=False");
                cons.Open();
                var command = cons.CreateCommand();
                command.CommandText = @"INSERT INTO Users(User_Name, User_Password, User_Banned, User_Rank) VALUES(@username, @password, @banned, @rank)";
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@banned", 0);
                command.Parameters.AddWithValue("@rank", 0);

                command.Prepare();
                command.ExecuteNonQuery();
                cons.Close();

                var me = new Form1();
                me.Show();
                this.Hide();
            }
        }
    }
}
