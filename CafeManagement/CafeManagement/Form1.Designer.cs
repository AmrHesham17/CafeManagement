namespace CafeManagement
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gunaGradient2Panel1 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.btnGuestCon = new Guna.UI.WinForms.GunaLinkLabel();
            this.btnLogin = new Guna.UI.WinForms.GunaButton();
            this.fieldPassword = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.fieldUsername = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.btnExit2 = new Guna.UI.WinForms.GunaButton();
            this.gunaGradient2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaGradient2Panel1
            // 
            this.gunaGradient2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradient2Panel1.Controls.Add(this.btnExit2);
            this.gunaGradient2Panel1.Controls.Add(this.btnGuestCon);
            this.gunaGradient2Panel1.Controls.Add(this.btnLogin);
            this.gunaGradient2Panel1.Controls.Add(this.fieldPassword);
            this.gunaGradient2Panel1.Controls.Add(this.gunaLabel4);
            this.gunaGradient2Panel1.Controls.Add(this.fieldUsername);
            this.gunaGradient2Panel1.Controls.Add(this.gunaLabel3);
            this.gunaGradient2Panel1.Controls.Add(this.gunaLabel2);
            this.gunaGradient2Panel1.Controls.Add(this.gunaLabel1);
            this.gunaGradient2Panel1.Controls.Add(this.gunaPictureBox1);
            this.gunaGradient2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaGradient2Panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gunaGradient2Panel1.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.gunaGradient2Panel1.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(72)))), ((int)(((byte)(115)))));
            this.gunaGradient2Panel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gunaGradient2Panel1.Location = new System.Drawing.Point(0, 0);
            this.gunaGradient2Panel1.Name = "gunaGradient2Panel1";
            this.gunaGradient2Panel1.Size = new System.Drawing.Size(900, 550);
            this.gunaGradient2Panel1.TabIndex = 0;
            // 
            // btnGuestCon
            // 
            this.btnGuestCon.ActiveLinkColor = System.Drawing.Color.Silver;
            this.btnGuestCon.AutoSize = true;
            this.btnGuestCon.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuestCon.LinkColor = System.Drawing.Color.White;
            this.btnGuestCon.Location = new System.Drawing.Point(332, 483);
            this.btnGuestCon.Name = "btnGuestCon";
            this.btnGuestCon.Size = new System.Drawing.Size(214, 32);
            this.btnGuestCon.TabIndex = 8;
            this.btnGuestCon.TabStop = true;
            this.btnGuestCon.Text = "Continue as Guest";
            this.btnGuestCon.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnGuestCon_LinkClicked);
            // 
            // btnLogin
            // 
            this.btnLogin.AnimationHoverSpeed = 1.5F;
            this.btnLogin.AnimationSpeed = 1.5F;
            this.btnLogin.BaseColor = System.Drawing.Color.White;
            this.btnLogin.BorderColor = System.Drawing.Color.Black;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogin.FocusedColor = System.Drawing.Color.Empty;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(72)))), ((int)(((byte)(115)))));
            this.btnLogin.Image = null;
            this.btnLogin.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLogin.Location = new System.Drawing.Point(356, 402);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnLogin.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLogin.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.btnLogin.OnHoverImage = null;
            this.btnLogin.OnPressedColor = System.Drawing.Color.Black;
            this.btnLogin.Size = new System.Drawing.Size(160, 42);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // fieldPassword
            // 
            this.fieldPassword.BaseColor = System.Drawing.Color.White;
            this.fieldPassword.BorderColor = System.Drawing.Color.Transparent;
            this.fieldPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fieldPassword.FocusedBaseColor = System.Drawing.Color.White;
            this.fieldPassword.FocusedBorderColor = System.Drawing.Color.Transparent;
            this.fieldPassword.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.fieldPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fieldPassword.ForeColor = System.Drawing.Color.LightGray;
            this.fieldPassword.Location = new System.Drawing.Point(222, 346);
            this.fieldPassword.Name = "fieldPassword";
            this.fieldPassword.PasswordChar = '*';
            this.fieldPassword.SelectedText = "";
            this.fieldPassword.Size = new System.Drawing.Size(429, 36);
            this.fieldPassword.TabIndex = 6;
            this.fieldPassword.Text = "Enter your password";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(217, 318);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(91, 25);
            this.gunaLabel4.TabIndex = 5;
            this.gunaLabel4.Text = "Password";
            // 
            // fieldUsername
            // 
            this.fieldUsername.BaseColor = System.Drawing.Color.White;
            this.fieldUsername.BorderColor = System.Drawing.Color.Transparent;
            this.fieldUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fieldUsername.FocusedBaseColor = System.Drawing.Color.White;
            this.fieldUsername.FocusedBorderColor = System.Drawing.Color.Transparent;
            this.fieldUsername.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.fieldUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fieldUsername.ForeColor = System.Drawing.Color.LightGray;
            this.fieldUsername.Location = new System.Drawing.Point(222, 271);
            this.fieldUsername.Name = "fieldUsername";
            this.fieldUsername.PasswordChar = '\0';
            this.fieldUsername.SelectedText = "";
            this.fieldUsername.Size = new System.Drawing.Size(429, 36);
            this.fieldUsername.TabIndex = 4;
            this.fieldUsername.Text = "Enter your username";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(217, 243);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(98, 25);
            this.gunaLabel3.TabIndex = 3;
            this.gunaLabel3.Text = "Username";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gunaLabel2.Location = new System.Drawing.Point(294, 180);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(299, 30);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "A New Experience Every Week!";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gunaLabel1.Location = new System.Drawing.Point(200, 64);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(489, 128);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Welcome!";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(21, 24);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(64, 54);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 1;
            this.gunaPictureBox1.TabStop = false;
            // 
            // btnExit2
            // 
            this.btnExit2.AnimationHoverSpeed = 0.07F;
            this.btnExit2.AnimationSpeed = 0.03F;
            this.btnExit2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.btnExit2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(72)))), ((int)(((byte)(115)))));
            this.btnExit2.BorderSize = 2;
            this.btnExit2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExit2.FocusedColor = System.Drawing.Color.Empty;
            this.btnExit2.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit2.ForeColor = System.Drawing.Color.White;
            this.btnExit2.Image = null;
            this.btnExit2.ImageSize = new System.Drawing.Size(20, 20);
            this.btnExit2.Location = new System.Drawing.Point(830, 43);
            this.btnExit2.Name = "btnExit2";
            this.btnExit2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(152)))), ((int)(((byte)(101)))));
            this.btnExit2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnExit2.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExit2.OnHoverImage = null;
            this.btnExit2.OnPressedColor = System.Drawing.Color.Black;
            this.btnExit2.Size = new System.Drawing.Size(26, 29);
            this.btnExit2.TabIndex = 9;
            this.btnExit2.Text = "x";
            this.btnExit2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExit2.Click += new System.EventHandler(this.btnExit2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.gunaGradient2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.gunaGradient2Panel1.ResumeLayout(false);
            this.gunaGradient2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox fieldUsername;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaTextBox fieldPassword;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaButton btnLogin;
        private Guna.UI.WinForms.GunaLinkLabel btnGuestCon;
        private Guna.UI.WinForms.GunaButton btnExit2;
    }
}

