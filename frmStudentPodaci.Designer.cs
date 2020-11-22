namespace DLWMS_Demo
{
    partial class frmStudentPodaci
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
            this.pbProfilnaStudenta = new System.Windows.Forms.PictureBox();
            this.btnChangePhoto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBrojIndeksa = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvPredmetiStudenta = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPrikaziPredmete = new System.Windows.Forms.Button();
            this.cmsMeni = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dodajPredmetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pogledajDetaljnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NazivPredmeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GodinaStudija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ofdSlika = new System.Windows.Forms.OpenFileDialog();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilnaStudenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPredmetiStudenta)).BeginInit();
            this.cmsMeni.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbProfilnaStudenta
            // 
            this.pbProfilnaStudenta.Location = new System.Drawing.Point(32, 49);
            this.pbProfilnaStudenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbProfilnaStudenta.Name = "pbProfilnaStudenta";
            this.pbProfilnaStudenta.Size = new System.Drawing.Size(175, 181);
            this.pbProfilnaStudenta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProfilnaStudenta.TabIndex = 1;
            this.pbProfilnaStudenta.TabStop = false;
            // 
            // btnChangePhoto
            // 
            this.btnChangePhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePhoto.Location = new System.Drawing.Point(61, 238);
            this.btnChangePhoto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChangePhoto.Name = "btnChangePhoto";
            this.btnChangePhoto.Size = new System.Drawing.Size(122, 28);
            this.btnChangePhoto.TabIndex = 2;
            this.btnChangePhoto.Text = "Change photo";
            this.btnChangePhoto.UseVisualStyleBackColor = true;
            this.btnChangePhoto.Click += new System.EventHandler(this.btnChangePhoto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Zilla Slab SemiBold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(257, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Broj Indeksa";
            // 
            // txtBrojIndeksa
            // 
            this.txtBrojIndeksa.Location = new System.Drawing.Point(237, 75);
            this.txtBrojIndeksa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBrojIndeksa.Name = "txtBrojIndeksa";
            this.txtBrojIndeksa.Size = new System.Drawing.Size(153, 23);
            this.txtBrojIndeksa.TabIndex = 4;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(563, 75);
            this.txtPrezime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(153, 23);
            this.txtPrezime.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Zilla Slab SemiBold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(600, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Prezime";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(725, 75);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(153, 23);
            this.txtEmail.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Zilla Slab SemiBold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(773, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Email";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(400, 75);
            this.txtIme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(153, 23);
            this.txtIme.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Zilla Slab SemiBold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(455, 49);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ime";
            // 
            // dgvPredmetiStudenta
            // 
            this.dgvPredmetiStudenta.AllowUserToAddRows = false;
            this.dgvPredmetiStudenta.AllowUserToDeleteRows = false;
            this.dgvPredmetiStudenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPredmetiStudenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NazivPredmeta,
            this.GodinaStudija});
            this.dgvPredmetiStudenta.Location = new System.Drawing.Point(412, 107);
            this.dgvPredmetiStudenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPredmetiStudenta.Name = "dgvPredmetiStudenta";
            this.dgvPredmetiStudenta.ReadOnly = true;
            this.dgvPredmetiStudenta.Size = new System.Drawing.Size(468, 224);
            this.dgvPredmetiStudenta.TabIndex = 11;
            this.dgvPredmetiStudenta.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPredmetiStudenta_CellMouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Zilla Slab", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(494, 335);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Vas ukupan prosjek je:";
            // 
            // btnPrikaziPredmete
            // 
            this.btnPrikaziPredmete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikaziPredmete.Location = new System.Drawing.Point(237, 196);
            this.btnPrikaziPredmete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrikaziPredmete.Name = "btnPrikaziPredmete";
            this.btnPrikaziPredmete.Size = new System.Drawing.Size(155, 34);
            this.btnPrikaziPredmete.TabIndex = 13;
            this.btnPrikaziPredmete.Text = "Prikazi predmete";
            this.btnPrikaziPredmete.UseVisualStyleBackColor = true;
            this.btnPrikaziPredmete.Click += new System.EventHandler(this.btnPrikaziPredmete_Click);
            // 
            // cmsMeni
            // 
            this.cmsMeni.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajPredmetToolStripMenuItem,
            this.pogledajDetaljnoToolStripMenuItem});
            this.cmsMeni.Name = "cmsMeni";
            this.cmsMeni.Size = new System.Drawing.Size(168, 48);
            // 
            // dodajPredmetToolStripMenuItem
            // 
            this.dodajPredmetToolStripMenuItem.Name = "dodajPredmetToolStripMenuItem";
            this.dodajPredmetToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.dodajPredmetToolStripMenuItem.Text = "Dodaj Predmet";
            // 
            // pogledajDetaljnoToolStripMenuItem
            // 
            this.pogledajDetaljnoToolStripMenuItem.Name = "pogledajDetaljnoToolStripMenuItem";
            this.pogledajDetaljnoToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.pogledajDetaljnoToolStripMenuItem.Text = "Pogledaj Detaljno";
            // 
            // NazivPredmeta
            // 
            this.NazivPredmeta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NazivPredmeta.DataPropertyName = "NazivPredmeta";
            this.NazivPredmeta.HeaderText = "Naziv Predmeta";
            this.NazivPredmeta.Name = "NazivPredmeta";
            this.NazivPredmeta.ReadOnly = true;
            // 
            // GodinaStudija
            // 
            this.GodinaStudija.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GodinaStudija.DataPropertyName = "GodinaStudija";
            this.GodinaStudija.HeaderText = "Godina studija";
            this.GodinaStudija.Name = "GodinaStudija";
            this.GodinaStudija.ReadOnly = true;
            // 
            // ofdSlika
            // 
            this.ofdSlika.FileName = "openFileDialog1";
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Font = new System.Drawing.Font("Zilla Slab", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanges.Location = new System.Drawing.Point(750, 335);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(130, 30);
            this.btnSaveChanges.TabIndex = 15;
            this.btnSaveChanges.Text = "Save changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            // 
            // frmStudentPodaci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 374);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.btnPrikaziPredmete);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvPredmetiStudenta);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBrojIndeksa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChangePhoto);
            this.Controls.Add(this.pbProfilnaStudenta);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmStudentPodaci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vasi podaci";
            this.Load += new System.EventHandler(this.frmStudentPodaci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilnaStudenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPredmetiStudenta)).EndInit();
            this.cmsMeni.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbProfilnaStudenta;
        private System.Windows.Forms.Button btnChangePhoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBrojIndeksa;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvPredmetiStudenta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPrikaziPredmete;
        private System.Windows.Forms.ContextMenuStrip cmsMeni;
        private System.Windows.Forms.ToolStripMenuItem dodajPredmetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pogledajDetaljnoToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivPredmeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn GodinaStudija;
        private System.Windows.Forms.OpenFileDialog ofdSlika;
        private System.Windows.Forms.Button btnSaveChanges;
    }
}