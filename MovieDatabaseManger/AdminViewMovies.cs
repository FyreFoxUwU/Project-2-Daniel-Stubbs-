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
    public partial class AdminViewMovies : Form
    {
        public int currentID = 1;
        public AdminViewMovies()
        {
            InitializeComponent();
        }

        private void updateMovies(int id)
        {
            var conn = new SqliteConnection("Data Source=MovieDatabase.db; Pooling=False");
            conn.Open();

            string Movies = "SELECT * FROM Movies WHERE Movie_ID = " + id + " LIMIT 1";
            using var cmd = new SqliteCommand(Movies, conn);

            using SqliteDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                MovieName.Text = rdr.GetString(1);
                MovieDesc.Text = rdr.GetString(2);
                MovieDate.Text = rdr.GetString(3);


                MoviePoster.LoadAsync(rdr.GetString(4));
                MoviePoster.SizeMode = PictureBoxSizeMode.StretchImage;

                MovieStars.Text = rdr.GetString(5);
                MovieDir.Text = rdr.GetString(6);
                MovieRating.Text = rdr.GetString(7);

                string[] AgeRating = { "U", "PG", "12A", "12", "15", "18" };
                MovieAgeBox.Text = AgeRating[rdr.GetInt32(8)];
                MovieIMDB.Text = rdr.GetString(9);

            }

            conn.Close();

        }

        private void UserViewMovies_Load(object sender, EventArgs e)
        {
            updateMovies(currentID);
        }
        private void WatchBTN_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Coming soon!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var me = new AdminMainPage();
            me.Show();
            this.Hide();
        }

        private void NextMovieBTN_Click(object sender, EventArgs e)
        {
            currentID += 1;
            try
            {
                updateMovies(currentID);
            }
            catch
            {
                currentID = 1;
                updateMovies(currentID);
            }

        }

        private void PrevMovieBTN_Click(object sender, EventArgs e)
        {
            currentID -= 1;
            if (currentID == 0)
            {
                currentID = 1;
            }
            updateMovies(currentID);
        }

    }
}
