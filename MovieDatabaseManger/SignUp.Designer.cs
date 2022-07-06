namespace MovieDatabaseManger
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.SignUpButton = new System.Windows.Forms.Button();
            this.PassConfirmText = new System.Windows.Forms.TextBox();
            this.PassText = new System.Windows.Forms.TextBox();
            this.UserText = new System.Windows.Forms.TextBox();
            this.PassConfirmLabel = new System.Windows.Forms.Label();
            this.PassLabel = new System.Windows.Forms.Label();
            this.UserLabel = new System.Windows.Forms.Label();
            this.SHUSignUp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SignUpButton
            // 
            this.SignUpButton.BackColor = System.Drawing.Color.Black;
            this.SignUpButton.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SignUpButton.ForeColor = System.Drawing.Color.White;
            this.SignUpButton.Location = new System.Drawing.Point(532, 504);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(234, 82);
            this.SignUpButton.TabIndex = 19;
            this.SignUpButton.Text = "Sign Up";
            this.SignUpButton.UseVisualStyleBackColor = false;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // PassConfirmText
            // 
            this.PassConfirmText.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PassConfirmText.Location = new System.Drawing.Point(624, 387);
            this.PassConfirmText.Name = "PassConfirmText";
            this.PassConfirmText.PasswordChar = '*';
            this.PassConfirmText.Size = new System.Drawing.Size(357, 48);
            this.PassConfirmText.TabIndex = 18;
            // 
            // PassText
            // 
            this.PassText.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PassText.Location = new System.Drawing.Point(624, 325);
            this.PassText.Name = "PassText";
            this.PassText.PasswordChar = '*';
            this.PassText.Size = new System.Drawing.Size(357, 48);
            this.PassText.TabIndex = 17;
            // 
            // UserText
            // 
            this.UserText.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserText.Location = new System.Drawing.Point(624, 247);
            this.UserText.Name = "UserText";
            this.UserText.Size = new System.Drawing.Size(357, 48);
            this.UserText.TabIndex = 15;
            // 
            // PassConfirmLabel
            // 
            this.PassConfirmLabel.AutoSize = true;
            this.PassConfirmLabel.BackColor = System.Drawing.Color.Transparent;
            this.PassConfirmLabel.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PassConfirmLabel.ForeColor = System.Drawing.Color.White;
            this.PassConfirmLabel.Location = new System.Drawing.Point(305, 390);
            this.PassConfirmLabel.Name = "PassConfirmLabel";
            this.PassConfirmLabel.Size = new System.Drawing.Size(298, 40);
            this.PassConfirmLabel.TabIndex = 14;
            this.PassConfirmLabel.Text = "Confirm Password";
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.BackColor = System.Drawing.Color.Transparent;
            this.PassLabel.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PassLabel.ForeColor = System.Drawing.Color.White;
            this.PassLabel.Location = new System.Drawing.Point(305, 328);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(168, 40);
            this.PassLabel.TabIndex = 13;
            this.PassLabel.Text = "Password";
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.BackColor = System.Drawing.Color.Transparent;
            this.UserLabel.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserLabel.ForeColor = System.Drawing.Color.White;
            this.UserLabel.Location = new System.Drawing.Point(299, 247);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(174, 40);
            this.UserLabel.TabIndex = 11;
            this.UserLabel.Text = "Username";
            // 
            // SHUSignUp
            // 
            this.SHUSignUp.AutoSize = true;
            this.SHUSignUp.BackColor = System.Drawing.Color.Transparent;
            this.SHUSignUp.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SHUSignUp.ForeColor = System.Drawing.Color.White;
            this.SHUSignUp.Location = new System.Drawing.Point(129, 29);
            this.SHUSignUp.Name = "SHUSignUp";
            this.SHUSignUp.Size = new System.Drawing.Size(980, 128);
            this.SHUSignUp.TabIndex = 20;
            this.SHUSignUp.Text = "SHU Movies Sign Up";
            this.SHUSignUp.Click += new System.EventHandler(this.SHUMoviesLogo_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.SHUSignUp);
            this.Controls.Add(this.SignUpButton);
            this.Controls.Add(this.PassConfirmText);
            this.Controls.Add(this.PassText);
            this.Controls.Add(this.UserText);
            this.Controls.Add(this.PassConfirmLabel);
            this.Controls.Add(this.PassLabel);
            this.Controls.Add(this.UserLabel);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button SignUpButton;
        private TextBox PassConfirmText;
        private TextBox PassText;
        private TextBox UserText;
        private Label PassConfirmLabel;
        private Label PassLabel;
        private Label UserLabel;
        private Label SHUSignUp;
    }
}