namespace Projet_v1
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.US = new MetroFramework.Controls.MetroTextBox();
            this.PS = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.Login = new MetroFramework.Controls.MetroButton();
            this.AdminUStext = new MetroFramework.Controls.MetroTextBox();
            this.AdminPWtext = new MetroFramework.Controls.MetroTextBox();
            this.AdminPW = new MetroFramework.Controls.MetroLabel();
            this.AdminUS = new MetroFramework.Controls.MetroLabel();
            this.AdminLogin = new MetroFramework.Controls.MetroButton();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(86, 133);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(78, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "UserName :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(86, 193);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(77, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "PassWord : ";
            // 
            // US
            // 
            this.US.Location = new System.Drawing.Point(218, 133);
            this.US.Name = "US";
            this.US.Size = new System.Drawing.Size(124, 23);
            this.US.TabIndex = 4;
            // 
            // PS
            // 
            this.PS.Location = new System.Drawing.Point(218, 189);
            this.PS.Name = "PS";
            this.PS.PasswordChar = '●';
            this.PS.Size = new System.Drawing.Size(124, 23);
            this.PS.TabIndex = 5;
            this.PS.UseSystemPasswordChar = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(218, 242);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(124, 36);
            this.metroButton1.TabIndex = 8;
            this.metroButton1.Text = "Register";
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(433, 149);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(148, 63);
            this.metroButton2.TabIndex = 9;
            this.metroButton2.Text = "Metro";
            this.metroButton2.Visible = false;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(452, 302);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(110, 31);
            this.metroButton3.TabIndex = 10;
            this.metroButton3.Text = "Admin Login";
            this.metroButton3.Visible = false;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(218, 297);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(124, 36);
            this.Login.TabIndex = 11;
            this.Login.Text = "Login";
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // AdminUStext
            // 
            this.AdminUStext.Location = new System.Drawing.Point(218, 73);
            this.AdminUStext.Name = "AdminUStext";
            this.AdminUStext.Size = new System.Drawing.Size(124, 23);
            this.AdminUStext.TabIndex = 15;
            this.AdminUStext.Visible = false;
            // 
            // AdminPWtext
            // 
            this.AdminPWtext.Location = new System.Drawing.Point(292, 218);
            this.AdminPWtext.Name = "AdminPWtext";
            this.AdminPWtext.PasswordChar = '●';
            this.AdminPWtext.Size = new System.Drawing.Size(124, 23);
            this.AdminPWtext.TabIndex = 14;
            this.AdminPWtext.UseSystemPasswordChar = true;
            this.AdminPWtext.Visible = false;
            // 
            // AdminPW
            // 
            this.AdminPW.AutoSize = true;
            this.AdminPW.Location = new System.Drawing.Point(53, 189);
            this.AdminPW.Name = "AdminPW";
            this.AdminPW.Size = new System.Drawing.Size(120, 19);
            this.AdminPW.TabIndex = 13;
            this.AdminPW.Text = "Admin PassWord : ";
            this.AdminPW.Visible = false;
            // 
            // AdminUS
            // 
            this.AdminUS.AutoSize = true;
            this.AdminUS.Location = new System.Drawing.Point(53, 133);
            this.AdminUS.Name = "AdminUS";
            this.AdminUS.Size = new System.Drawing.Size(121, 19);
            this.AdminUS.TabIndex = 12;
            this.AdminUS.Text = "Admin UserName :";
            this.AdminUS.Visible = false;
            // 
            // AdminLogin
            // 
            this.AdminLogin.Location = new System.Drawing.Point(280, 317);
            this.AdminLogin.Name = "AdminLogin";
            this.AdminLogin.Size = new System.Drawing.Size(124, 36);
            this.AdminLogin.TabIndex = 16;
            this.AdminLogin.Text = "Admin Login";
            this.AdminLogin.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(419, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(102, 20);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 96);
            this.richTextBox1.TabIndex = 18;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 376);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AdminLogin);
            this.Controls.Add(this.AdminUStext);
            this.Controls.Add(this.AdminPWtext);
            this.Controls.Add(this.AdminPW);
            this.Controls.Add(this.AdminUS);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.PS);
            this.Controls.Add(this.US);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Name = "Form1";
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox US;
        private MetroFramework.Controls.MetroTextBox PS;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton Login;
        private MetroFramework.Controls.MetroTextBox AdminUStext;
        private MetroFramework.Controls.MetroTextBox AdminPWtext;
        private MetroFramework.Controls.MetroLabel AdminPW;
        private MetroFramework.Controls.MetroLabel AdminUS;
        private MetroFramework.Controls.MetroButton AdminLogin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

