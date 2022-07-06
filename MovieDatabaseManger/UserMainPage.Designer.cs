namespace MovieDatabaseManger
{
    partial class UserMainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMainPage));
            this.SHUMoviesLogo = new System.Windows.Forms.Label();
            this.MoviesButton = new System.Windows.Forms.Button();
            this.ReqMovieButton = new System.Windows.Forms.Button();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.SearchMoviesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SHUMoviesLogo
            // 
            this.SHUMoviesLogo.AutoSize = true;
            this.SHUMoviesLogo.BackColor = System.Drawing.Color.Transparent;
            this.SHUMoviesLogo.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SHUMoviesLogo.ForeColor = System.Drawing.Color.White;
            this.SHUMoviesLogo.Location = new System.Drawing.Point(318, 20);
            this.SHUMoviesLogo.Name = "SHUMoviesLogo";
            this.SHUMoviesLogo.Size = new System.Drawing.Size(601, 128);
            this.SHUMoviesLogo.TabIndex = 2;
            this.SHUMoviesLogo.Text = "SHU Movies";
            // 
            // MoviesButton
            // 
            this.MoviesButton.BackColor = System.Drawing.Color.Black;
            this.MoviesButton.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MoviesButton.ForeColor = System.Drawing.Color.White;
            this.MoviesButton.Location = new System.Drawing.Point(477, 173);
            this.MoviesButton.Name = "MoviesButton";
            this.MoviesButton.Size = new System.Drawing.Size(272, 99);
            this.MoviesButton.TabIndex = 14;
            this.MoviesButton.Text = "View Movies";
            this.MoviesButton.UseVisualStyleBackColor = false;
            this.MoviesButton.Click += new System.EventHandler(this.MoviesButton_Click);
            // 
            // ReqMovieButton
            // 
            this.ReqMovieButton.BackColor = System.Drawing.Color.Black;
            this.ReqMovieButton.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReqMovieButton.ForeColor = System.Drawing.Color.White;
            this.ReqMovieButton.Location = new System.Drawing.Point(477, 433);
            this.ReqMovieButton.Name = "ReqMovieButton";
            this.ReqMovieButton.Size = new System.Drawing.Size(272, 99);
            this.ReqMovieButton.TabIndex = 15;
            this.ReqMovieButton.Text = "Request Movies";
            this.ReqMovieButton.UseVisualStyleBackColor = false;
            this.ReqMovieButton.Click += new System.EventHandler(this.ReqMovieButton_Click);
            // 
            // LogOutButton
            // 
            this.LogOutButton.BackColor = System.Drawing.Color.Black;
            this.LogOutButton.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LogOutButton.ForeColor = System.Drawing.Color.White;
            this.LogOutButton.Location = new System.Drawing.Point(1056, 20);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(196, 64);
            this.LogOutButton.TabIndex = 16;
            this.LogOutButton.Text = "Logout";
            this.LogOutButton.UseVisualStyleBackColor = false;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // SearchMoviesButton
            // 
            this.SearchMoviesButton.BackColor = System.Drawing.Color.Black;
            this.SearchMoviesButton.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchMoviesButton.ForeColor = System.Drawing.Color.White;
            this.SearchMoviesButton.Location = new System.Drawing.Point(477, 304);
            this.SearchMoviesButton.Name = "SearchMoviesButton";
            this.SearchMoviesButton.Size = new System.Drawing.Size(272, 99);
            this.SearchMoviesButton.TabIndex = 17;
            this.SearchMoviesButton.Text = "Search Movies";
            this.SearchMoviesButton.UseVisualStyleBackColor = false;
            this.SearchMoviesButton.Click += new System.EventHandler(this.SearchMoviesButton_Click);
            // 
            // UserMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.SearchMoviesButton);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.ReqMovieButton);
            this.Controls.Add(this.MoviesButton);
            this.Controls.Add(this.SHUMoviesLogo);
            this.Name = "UserMainPage";
            this.Text = "UserMainPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label SHUMoviesLogo;
        private Button MoviesButton;
        private Button ReqMovieButton;
        private Button LogOutButton;
        private Button SearchMoviesButton;
    }
}