namespace DLWMS_Demo
{
    partial class ModUpravljanja
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lblInfoMod = new System.Windows.Forms.Label();
            this.lblAdministrator = new System.Windows.Forms.Label();
            this.lblStudent = new System.Windows.Forms.Label();
            this.lblLoginMod = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.pbStudent = new System.Windows.Forms.PictureBox();
            this.pbAdministrator = new System.Windows.Forms.PictureBox();
            this.pbDLWMS_logo = new System.Windows.Forms.PictureBox();
            this.btnChangeMod = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdministrator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDLWMS_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Zilla Slab", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to DLWMS_DEMO";
            // 
            // lblInfoMod
            // 
            this.lblInfoMod.AutoSize = true;
            this.lblInfoMod.Font = new System.Drawing.Font("Zilla Slab SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoMod.Location = new System.Drawing.Point(36, 94);
            this.lblInfoMod.Name = "lblInfoMod";
            this.lblInfoMod.Size = new System.Drawing.Size(247, 19);
            this.lblInfoMod.TabIndex = 2;
            this.lblInfoMod.Text = "Click the mode you want to control";
            // 
            // lblAdministrator
            // 
            this.lblAdministrator.AutoSize = true;
            this.lblAdministrator.Font = new System.Drawing.Font("Zilla Slab", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdministrator.Location = new System.Drawing.Point(194, 249);
            this.lblAdministrator.Name = "lblAdministrator";
            this.lblAdministrator.Size = new System.Drawing.Size(113, 15);
            this.lblAdministrator.TabIndex = 5;
            this.lblAdministrator.Text = "ADMINISTRATOR";
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Font = new System.Drawing.Font("Zilla Slab", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudent.Location = new System.Drawing.Point(72, 249);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(66, 15);
            this.lblStudent.TabIndex = 6;
            this.lblStudent.Text = "STUDENT";
            // 
            // lblLoginMod
            // 
            this.lblLoginMod.AutoSize = true;
            this.lblLoginMod.Font = new System.Drawing.Font("Zilla Slab", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginMod.Location = new System.Drawing.Point(377, 135);
            this.lblLoginMod.Name = "lblLoginMod";
            this.lblLoginMod.Size = new System.Drawing.Size(78, 18);
            this.lblLoginMod.TabIndex = 7;
            this.lblLoginMod.Text = "Username:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(380, 156);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(162, 20);
            this.txtUsername.TabIndex = 8;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(377, 200);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(165, 20);
            this.txtPassword.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Zilla Slab", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(374, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Password:";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLogin.FlatAppearance.BorderSize = 5;
            this.btnLogin.Font = new System.Drawing.Font("Zilla Slab Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(410, 239);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(109, 25);
            this.btnLogin.TabIndex = 11;
            this.btnLogin.Text = "Log in";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // pbStudent
            // 
            this.pbStudent.Image = global::DLWMS_Demo.Properties.Resources.Student_logo;
            this.pbStudent.Location = new System.Drawing.Point(40, 126);
            this.pbStudent.Name = "pbStudent";
            this.pbStudent.Size = new System.Drawing.Size(129, 120);
            this.pbStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStudent.TabIndex = 4;
            this.pbStudent.TabStop = false;
            this.pbStudent.Click += new System.EventHandler(this.pbStudent_Click);
            // 
            // pbAdministrator
            // 
            this.pbAdministrator.Image = global::DLWMS_Demo.Properties.Resources.SLIKA;
            this.pbAdministrator.Location = new System.Drawing.Point(183, 126);
            this.pbAdministrator.Name = "pbAdministrator";
            this.pbAdministrator.Size = new System.Drawing.Size(137, 120);
            this.pbAdministrator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAdministrator.TabIndex = 3;
            this.pbAdministrator.TabStop = false;
            this.pbAdministrator.Click += new System.EventHandler(this.pbAdministrator_Click);
            // 
            // pbDLWMS_logo
            // 
            this.pbDLWMS_logo.Image = global::DLWMS_Demo.Properties.Resources.DLWMS_Logo;
            this.pbDLWMS_logo.Location = new System.Drawing.Point(380, 13);
            this.pbDLWMS_logo.Name = "pbDLWMS_logo";
            this.pbDLWMS_logo.Size = new System.Drawing.Size(165, 70);
            this.pbDLWMS_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDLWMS_logo.TabIndex = 1;
            this.pbDLWMS_logo.TabStop = false;
            // 
            // btnChangeMod
            // 
            this.btnChangeMod.BackColor = System.Drawing.Color.White;
            this.btnChangeMod.Font = new System.Drawing.Font("Zilla Slab", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeMod.Location = new System.Drawing.Point(380, 109);
            this.btnChangeMod.Name = "btnChangeMod";
            this.btnChangeMod.Size = new System.Drawing.Size(162, 23);
            this.btnChangeMod.TabIndex = 12;
            this.btnChangeMod.Text = "Change mod";
            this.btnChangeMod.UseVisualStyleBackColor = false;
            this.btnChangeMod.Click += new System.EventHandler(this.btnChangeMod_Click);
            // 
            // ModUpravljanja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(557, 280);
            this.Controls.Add(this.btnChangeMod);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblLoginMod);
            this.Controls.Add(this.lblStudent);
            this.Controls.Add(this.lblAdministrator);
            this.Controls.Add(this.pbStudent);
            this.Controls.Add(this.pbAdministrator);
            this.Controls.Add(this.lblInfoMod);
            this.Controls.Add(this.pbDLWMS_logo);
            this.Controls.Add(this.label1);
            this.Name = "ModUpravljanja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Odaberite mod upravljanja";
            this.Load += new System.EventHandler(this.ModUpravljanja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdministrator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDLWMS_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbDLWMS_logo;
        private System.Windows.Forms.Label lblInfoMod;
        private System.Windows.Forms.PictureBox pbAdministrator;
        private System.Windows.Forms.PictureBox pbStudent;
        private System.Windows.Forms.Label lblAdministrator;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.Label lblLoginMod;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.Button btnChangeMod;
    }
}

