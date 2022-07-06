namespace MovieDatabaseManger
{
    partial class AdminViewMovies
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminViewMovies));
            this.NextMovieBTN = new System.Windows.Forms.Button();
            this.PrevMovieBTN = new System.Windows.Forms.Button();
            this.MovieAgeBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SHUMoviesLogo = new System.Windows.Forms.Label();
            this.WatchBTN = new System.Windows.Forms.Button();
            this.MovieIMDB = new System.Windows.Forms.TextBox();
            this.IMDBLinkLabel = new System.Windows.Forms.Label();
            this.AgeRatingLabel = new System.Windows.Forms.Label();
            this.MovieRating = new System.Windows.Forms.TextBox();
            this.RatingLabel = new System.Windows.Forms.Label();
            this.MovieDir = new System.Windows.Forms.TextBox();
            this.DirectorsLabel = new System.Windows.Forms.Label();
            this.MovieStars = new System.Windows.Forms.TextBox();
            this.StarsLabel = new System.Windows.Forms.Label();
            this.MoviePoster = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MovieDesc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MovieGenreLabel = new System.Windows.Forms.Label();
            this.MovieNameLabel = new System.Windows.Forms.Label();
            this.MovieDate = new System.Windows.Forms.TextBox();
            this.MovieName = new System.Windows.Forms.TextBox();
            this.AdminPageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePoster)).BeginInit();
            this.SuspendLayout();
            // 
            // NextMovieBTN
            // 
            this.NextMovieBTN.BackColor = System.Drawing.Color.Black;
            this.NextMovieBTN.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NextMovieBTN.ForeColor = System.Drawing.Color.White;
            this.NextMovieBTN.Location = new System.Drawing.Point(181, 455);
            this.NextMovieBTN.Name = "NextMovieBTN";
            this.NextMovieBTN.Size = new System.Drawing.Size(107, 74);
            this.NextMovieBTN.TabIndex = 124;
            this.NextMovieBTN.Text = ">";
            this.NextMovieBTN.UseVisualStyleBackColor = false;
            this.NextMovieBTN.Click += new System.EventHandler(this.NextMovieBTN_Click);
            // 
            // PrevMovieBTN
            // 
            this.PrevMovieBTN.BackColor = System.Drawing.Color.Black;
            this.PrevMovieBTN.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PrevMovieBTN.ForeColor = System.Drawing.Color.White;
            this.PrevMovieBTN.Location = new System.Drawing.Point(49, 455);
            this.PrevMovieBTN.Name = "PrevMovieBTN";
            this.PrevMovieBTN.Size = new System.Drawing.Size(107, 74);
            this.PrevMovieBTN.TabIndex = 123;
            this.PrevMovieBTN.Text = "<";
            this.PrevMovieBTN.UseVisualStyleBackColor = false;
            this.PrevMovieBTN.Click += new System.EventHandler(this.PrevMovieBTN_Click);
            // 
            // MovieAgeBox
            // 
            this.MovieAgeBox.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MovieAgeBox.Location = new System.Drawing.Point(1091, 518);
            this.MovieAgeBox.Name = "MovieAgeBox";
            this.MovieAgeBox.ReadOnly = true;
            this.MovieAgeBox.Size = new System.Drawing.Size(158, 44);
            this.MovieAgeBox.TabIndex = 122;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(49, 580);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 74);
            this.button1.TabIndex = 121;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SHUMoviesLogo
            // 
            this.SHUMoviesLogo.AutoSize = true;
            this.SHUMoviesLogo.BackColor = System.Drawing.Color.Transparent;
            this.SHUMoviesLogo.Font = new System.Drawing.Font("Segoe UI", 56F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SHUMoviesLogo.ForeColor = System.Drawing.Color.White;
            this.SHUMoviesLogo.Location = new System.Drawing.Point(15, 27);
            this.SHUMoviesLogo.Name = "SHUMoviesLogo";
            this.SHUMoviesLogo.Size = new System.Drawing.Size(470, 100);
            this.SHUMoviesLogo.TabIndex = 120;
            this.SHUMoviesLogo.Text = "SHU Movies";
            // 
            // WatchBTN
            // 
            this.WatchBTN.BackColor = System.Drawing.Color.Black;
            this.WatchBTN.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WatchBTN.ForeColor = System.Drawing.Color.White;
            this.WatchBTN.Location = new System.Drawing.Point(49, 342);
            this.WatchBTN.Name = "WatchBTN";
            this.WatchBTN.Size = new System.Drawing.Size(239, 74);
            this.WatchBTN.TabIndex = 119;
            this.WatchBTN.Text = "Watch Now";
            this.WatchBTN.UseVisualStyleBackColor = false;
            this.WatchBTN.Click += new System.EventHandler(this.WatchBTN_Click);
            // 
            // MovieIMDB
            // 
            this.MovieIMDB.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MovieIMDB.Location = new System.Drawing.Point(797, 592);
            this.MovieIMDB.Name = "MovieIMDB";
            this.MovieIMDB.ReadOnly = true;
            this.MovieIMDB.Size = new System.Drawing.Size(452, 44);
            this.MovieIMDB.TabIndex = 118;
            // 
            // IMDBLinkLabel
            // 
            this.IMDBLinkLabel.AutoSize = true;
            this.IMDBLinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.IMDBLinkLabel.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IMDBLinkLabel.ForeColor = System.Drawing.Color.White;
            this.IMDBLinkLabel.Location = new System.Drawing.Point(603, 594);
            this.IMDBLinkLabel.Name = "IMDBLinkLabel";
            this.IMDBLinkLabel.Size = new System.Drawing.Size(188, 42);
            this.IMDBLinkLabel.TabIndex = 117;
            this.IMDBLinkLabel.Text = "IMDB Link";
            // 
            // AgeRatingLabel
            // 
            this.AgeRatingLabel.AutoSize = true;
            this.AgeRatingLabel.BackColor = System.Drawing.Color.Transparent;
            this.AgeRatingLabel.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AgeRatingLabel.ForeColor = System.Drawing.Color.White;
            this.AgeRatingLabel.Location = new System.Drawing.Point(885, 520);
            this.AgeRatingLabel.Name = "AgeRatingLabel";
            this.AgeRatingLabel.Size = new System.Drawing.Size(200, 42);
            this.AgeRatingLabel.TabIndex = 115;
            this.AgeRatingLabel.Text = "Age Rating";
            // 
            // MovieRating
            // 
            this.MovieRating.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MovieRating.Location = new System.Drawing.Point(797, 518);
            this.MovieRating.Name = "MovieRating";
            this.MovieRating.ReadOnly = true;
            this.MovieRating.Size = new System.Drawing.Size(72, 44);
            this.MovieRating.TabIndex = 114;
            // 
            // RatingLabel
            // 
            this.RatingLabel.AutoSize = true;
            this.RatingLabel.BackColor = System.Drawing.Color.Transparent;
            this.RatingLabel.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RatingLabel.ForeColor = System.Drawing.Color.White;
            this.RatingLabel.Location = new System.Drawing.Point(667, 516);
            this.RatingLabel.Name = "RatingLabel";
            this.RatingLabel.Size = new System.Drawing.Size(124, 42);
            this.RatingLabel.TabIndex = 113;
            this.RatingLabel.Text = "Rating";
            // 
            // MovieDir
            // 
            this.MovieDir.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MovieDir.Location = new System.Drawing.Point(797, 455);
            this.MovieDir.Name = "MovieDir";
            this.MovieDir.ReadOnly = true;
            this.MovieDir.Size = new System.Drawing.Size(452, 44);
            this.MovieDir.TabIndex = 112;
            // 
            // DirectorsLabel
            // 
            this.DirectorsLabel.AutoSize = true;
            this.DirectorsLabel.BackColor = System.Drawing.Color.Transparent;
            this.DirectorsLabel.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DirectorsLabel.ForeColor = System.Drawing.Color.White;
            this.DirectorsLabel.Location = new System.Drawing.Point(617, 455);
            this.DirectorsLabel.Name = "DirectorsLabel";
            this.DirectorsLabel.Size = new System.Drawing.Size(164, 42);
            this.DirectorsLabel.TabIndex = 111;
            this.DirectorsLabel.Text = "Directors";
            // 
            // MovieStars
            // 
            this.MovieStars.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MovieStars.Location = new System.Drawing.Point(797, 376);
            this.MovieStars.Name = "MovieStars";
            this.MovieStars.ReadOnly = true;
            this.MovieStars.Size = new System.Drawing.Size(452, 44);
            this.MovieStars.TabIndex = 110;
            // 
            // StarsLabel
            // 
            this.StarsLabel.AutoSize = true;
            this.StarsLabel.BackColor = System.Drawing.Color.Transparent;
            this.StarsLabel.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StarsLabel.ForeColor = System.Drawing.Color.White;
            this.StarsLabel.Location = new System.Drawing.Point(678, 374);
            this.StarsLabel.Name = "StarsLabel";
            this.StarsLabel.Size = new System.Drawing.Size(103, 42);
            this.StarsLabel.TabIndex = 109;
            this.StarsLabel.Text = "Stars";
            // 
            // MoviePoster
            // 
            this.MoviePoster.Location = new System.Drawing.Point(317, 280);
            this.MoviePoster.Name = "MoviePoster";
            this.MoviePoster.Size = new System.Drawing.Size(221, 337);
            this.MoviePoster.TabIndex = 116;
            this.MoviePoster.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(368, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 42);
            this.label2.TabIndex = 108;
            this.label2.Text = "Poster";
            // 
            // MovieDesc
            // 
            this.MovieDesc.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MovieDesc.Location = new System.Drawing.Point(797, 141);
            this.MovieDesc.Multiline = true;
            this.MovieDesc.Name = "MovieDesc";
            this.MovieDesc.ReadOnly = true;
            this.MovieDesc.Size = new System.Drawing.Size(452, 139);
            this.MovieDesc.TabIndex = 107;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(590, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 42);
            this.label1.TabIndex = 106;
            this.label1.Text = "Description";
            // 
            // MovieGenreLabel
            // 
            this.MovieGenreLabel.AutoSize = true;
            this.MovieGenreLabel.BackColor = System.Drawing.Color.Transparent;
            this.MovieGenreLabel.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MovieGenreLabel.ForeColor = System.Drawing.Color.White;
            this.MovieGenreLabel.Location = new System.Drawing.Point(544, 303);
            this.MovieGenreLabel.Name = "MovieGenreLabel";
            this.MovieGenreLabel.Size = new System.Drawing.Size(237, 42);
            this.MovieGenreLabel.TabIndex = 105;
            this.MovieGenreLabel.Text = "Release Date";
            // 
            // MovieNameLabel
            // 
            this.MovieNameLabel.AutoSize = true;
            this.MovieNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.MovieNameLabel.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MovieNameLabel.ForeColor = System.Drawing.Color.White;
            this.MovieNameLabel.Location = new System.Drawing.Point(569, 74);
            this.MovieNameLabel.Name = "MovieNameLabel";
            this.MovieNameLabel.Size = new System.Drawing.Size(222, 42);
            this.MovieNameLabel.TabIndex = 104;
            this.MovieNameLabel.Text = "Movie Name";
            // 
            // MovieDate
            // 
            this.MovieDate.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MovieDate.Location = new System.Drawing.Point(797, 305);
            this.MovieDate.Name = "MovieDate";
            this.MovieDate.ReadOnly = true;
            this.MovieDate.Size = new System.Drawing.Size(452, 44);
            this.MovieDate.TabIndex = 103;
            // 
            // MovieName
            // 
            this.MovieName.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MovieName.Location = new System.Drawing.Point(797, 74);
            this.MovieName.Name = "MovieName";
            this.MovieName.ReadOnly = true;
            this.MovieName.Size = new System.Drawing.Size(452, 44);
            this.MovieName.TabIndex = 102;
            // 
            // AdminPageLabel
            // 
            this.AdminPageLabel.AutoSize = true;
            this.AdminPageLabel.BackColor = System.Drawing.Color.Transparent;
            this.AdminPageLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point);
            this.AdminPageLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.AdminPageLabel.Location = new System.Drawing.Point(150, 104);
            this.AdminPageLabel.Name = "AdminPageLabel";
            this.AdminPageLabel.Size = new System.Drawing.Size(183, 40);
            this.AdminPageLabel.TabIndex = 147;
            this.AdminPageLabel.Text = "Admin Page";
            // 
            // AdminViewMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.AdminPageLabel);
            this.Controls.Add(this.NextMovieBTN);
            this.Controls.Add(this.PrevMovieBTN);
            this.Controls.Add(this.MovieAgeBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SHUMoviesLogo);
            this.Controls.Add(this.WatchBTN);
            this.Controls.Add(this.MovieIMDB);
            this.Controls.Add(this.IMDBLinkLabel);
            this.Controls.Add(this.AgeRatingLabel);
            this.Controls.Add(this.MovieRating);
            this.Controls.Add(this.RatingLabel);
            this.Controls.Add(this.MovieDir);
            this.Controls.Add(this.DirectorsLabel);
            this.Controls.Add(this.MovieStars);
            this.Controls.Add(this.StarsLabel);
            this.Controls.Add(this.MoviePoster);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MovieDesc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MovieGenreLabel);
            this.Controls.Add(this.MovieNameLabel);
            this.Controls.Add(this.MovieDate);
            this.Controls.Add(this.MovieName);
            this.Name = "AdminViewMovies";
            this.Text = "AdminViewMovies";
            ((System.ComponentModel.ISupportInitialize)(this.MoviePoster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button NextMovieBTN;
        private Button PrevMovieBTN;
        private TextBox MovieAgeBox;
        private Button button1;
        private Label SHUMoviesLogo;
        private Button WatchBTN;
        private TextBox MovieIMDB;
        private Label IMDBLinkLabel;
        private Label AgeRatingLabel;
        private TextBox MovieRating;
        private Label RatingLabel;
        private TextBox MovieDir;
        private Label DirectorsLabel;
        private TextBox MovieStars;
        private Label StarsLabel;
        private PictureBox MoviePoster;
        private Label label2;
        private TextBox MovieDesc;
        private Label label1;
        private Label MovieGenreLabel;
        private Label MovieNameLabel;
        private TextBox MovieDate;
        private TextBox MovieName;
        private Label AdminPageLabel;
    }
}