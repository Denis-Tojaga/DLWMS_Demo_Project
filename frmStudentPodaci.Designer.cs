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
            this.btnChangePhoto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBrojIndeksa = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmsMeni = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.checkDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ofdSlika = new System.Windows.Forms.OpenFileDialog();
            this.msMeni = new System.Windows.Forms.MenuStrip();
            this.postavkeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urediPodatkeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbPodaci = new System.Windows.Forms.GroupBox();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.lblBrojPolozenih = new System.Windows.Forms.Label();
            this.dgvPredmetiStudenta = new System.Windows.Forms.DataGridView();
            this.NazivPredmeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GodinaStudija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pbProfilnaStudenta = new System.Windows.Forms.PictureBox();
            this.gbNovaFotografija = new System.Windows.Forms.GroupBox();
            this.txtPutanjaDoSlike = new System.Windows.Forms.TextBox();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.err2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnBack = new System.Windows.Forms.Button();
            this.cmsMeni.SuspendLayout();
            this.msMeni.SuspendLayout();
            this.gbPodaci.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPredmetiStudenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilnaStudenta)).BeginInit();
            this.gbNovaFotografija.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChangePhoto
            // 
            this.btnChangePhoto.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnChangePhoto.Font = new System.Drawing.Font("Zilla Slab", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePhoto.ForeColor = System.Drawing.Color.White;
            this.btnChangePhoto.Location = new System.Drawing.Point(616, 51);
            this.btnChangePhoto.Margin = new System.Windows.Forms.Padding(4);
            this.btnChangePhoto.Name = "btnChangePhoto";
            this.btnChangePhoto.Size = new System.Drawing.Size(103, 25);
            this.btnChangePhoto.TabIndex = 2;
            this.btnChangePhoto.Text = "Postavi";
            this.btnChangePhoto.UseVisualStyleBackColor = false;
            this.btnChangePhoto.Click += new System.EventHandler(this.btnChangePhoto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Zilla Slab SemiBold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Broj Indeksa";
            // 
            // txtBrojIndeksa
            // 
            this.txtBrojIndeksa.Location = new System.Drawing.Point(279, 84);
            this.txtBrojIndeksa.Margin = new System.Windows.Forms.Padding(4);
            this.txtBrojIndeksa.Name = "txtBrojIndeksa";
            this.txtBrojIndeksa.Size = new System.Drawing.Size(153, 23);
            this.txtBrojIndeksa.TabIndex = 4;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(605, 84);
            this.txtPrezime.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(153, 23);
            this.txtPrezime.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Zilla Slab SemiBold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(642, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Prezime";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(767, 84);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(153, 23);
            this.txtEmail.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Zilla Slab SemiBold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(815, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Email";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(442, 84);
            this.txtIme.Margin = new System.Windows.Forms.Padding(4);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(153, 23);
            this.txtIme.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Zilla Slab SemiBold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(497, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ime";
            // 
            // cmsMeni
            // 
            this.cmsMeni.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkDetailsToolStripMenuItem});
            this.cmsMeni.Name = "cmsMeni";
            this.cmsMeni.Size = new System.Drawing.Size(146, 26);
            // 
            // checkDetailsToolStripMenuItem
            // 
            this.checkDetailsToolStripMenuItem.Name = "checkDetailsToolStripMenuItem";
            this.checkDetailsToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.checkDetailsToolStripMenuItem.Text = "Check Details";
            this.checkDetailsToolStripMenuItem.Click += new System.EventHandler(this.checkDetailsToolStripMenuItem_Click);
            // 
            // ofdSlika
            // 
            this.ofdSlika.FileName = "openFileDialog1";
            // 
            // msMeni
            // 
            this.msMeni.Font = new System.Drawing.Font("Zilla Slab", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msMeni.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.postavkeToolStripMenuItem,
            this.urediPodatkeToolStripMenuItem});
            this.msMeni.Location = new System.Drawing.Point(0, 0);
            this.msMeni.Name = "msMeni";
            this.msMeni.Size = new System.Drawing.Size(1075, 31);
            this.msMeni.TabIndex = 16;
            this.msMeni.Text = "menuStrip1";
            // 
            // postavkeToolStripMenuItem
            // 
            this.postavkeToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.postavkeToolStripMenuItem.CheckOnClick = true;
            this.postavkeToolStripMenuItem.Name = "postavkeToolStripMenuItem";
            this.postavkeToolStripMenuItem.Size = new System.Drawing.Size(162, 27);
            this.postavkeToolStripMenuItem.Text = "Prikazi Predmete";
            this.postavkeToolStripMenuItem.Click += new System.EventHandler(this.postavkeToolStripMenuItem_Click);
            // 
            // urediPodatkeToolStripMenuItem
            // 
            this.urediPodatkeToolStripMenuItem.Name = "urediPodatkeToolStripMenuItem";
            this.urediPodatkeToolStripMenuItem.Size = new System.Drawing.Size(137, 27);
            this.urediPodatkeToolStripMenuItem.Text = "Uredi podatke";
            this.urediPodatkeToolStripMenuItem.Click += new System.EventHandler(this.urediPodatkeToolStripMenuItem_Click);
            // 
            // gbPodaci
            // 
            this.gbPodaci.BackColor = System.Drawing.Color.Gainsboro;
            this.gbPodaci.Controls.Add(this.btnSaveChanges);
            this.gbPodaci.Controls.Add(this.lblBrojPolozenih);
            this.gbPodaci.Controls.Add(this.dgvPredmetiStudenta);
            this.gbPodaci.Controls.Add(this.label11);
            this.gbPodaci.Controls.Add(this.label5);
            this.gbPodaci.Controls.Add(this.label9);
            this.gbPodaci.Controls.Add(this.label10);
            this.gbPodaci.Controls.Add(this.pbProfilnaStudenta);
            this.gbPodaci.Controls.Add(this.label1);
            this.gbPodaci.Controls.Add(this.txtBrojIndeksa);
            this.gbPodaci.Controls.Add(this.label2);
            this.gbPodaci.Controls.Add(this.txtPrezime);
            this.gbPodaci.Controls.Add(this.txtEmail);
            this.gbPodaci.Controls.Add(this.label4);
            this.gbPodaci.Controls.Add(this.label3);
            this.gbPodaci.Controls.Add(this.txtIme);
            this.gbPodaci.Location = new System.Drawing.Point(48, 71);
            this.gbPodaci.Name = "gbPodaci";
            this.gbPodaci.Size = new System.Drawing.Size(989, 405);
            this.gbPodaci.TabIndex = 17;
            this.gbPodaci.TabStop = false;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSaveChanges.Font = new System.Drawing.Font("Zilla Slab SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanges.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSaveChanges.Location = new System.Drawing.Point(780, 364);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(140, 31);
            this.btnSaveChanges.TabIndex = 22;
            this.btnSaveChanges.Text = "Spasi promjene";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // lblBrojPolozenih
            // 
            this.lblBrojPolozenih.AutoSize = true;
            this.lblBrojPolozenih.Font = new System.Drawing.Font("Zilla Slab", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrojPolozenih.Location = new System.Drawing.Point(275, 372);
            this.lblBrojPolozenih.Name = "lblBrojPolozenih";
            this.lblBrojPolozenih.Size = new System.Drawing.Size(226, 22);
            this.lblBrojPolozenih.TabIndex = 21;
            this.lblBrojPolozenih.Text = "Broj polozenih predmeta je: ";
            // 
            // dgvPredmetiStudenta
            // 
            this.dgvPredmetiStudenta.AllowUserToAddRows = false;
            this.dgvPredmetiStudenta.AllowUserToDeleteRows = false;
            this.dgvPredmetiStudenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPredmetiStudenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NazivPredmeta,
            this.Profesor,
            this.GodinaStudija,
            this.Ocjena});
            this.dgvPredmetiStudenta.Location = new System.Drawing.Point(279, 135);
            this.dgvPredmetiStudenta.Name = "dgvPredmetiStudenta";
            this.dgvPredmetiStudenta.ReadOnly = true;
            this.dgvPredmetiStudenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPredmetiStudenta.Size = new System.Drawing.Size(641, 226);
            this.dgvPredmetiStudenta.TabIndex = 20;
            this.dgvPredmetiStudenta.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvPredmetiStudenta_MouseClick);
            // 
            // NazivPredmeta
            // 
            this.NazivPredmeta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NazivPredmeta.DataPropertyName = "NazivPredmeta";
            this.NazivPredmeta.HeaderText = "NazivPredmeta";
            this.NazivPredmeta.Name = "NazivPredmeta";
            this.NazivPredmeta.ReadOnly = true;
            // 
            // Profesor
            // 
            this.Profesor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Profesor.DataPropertyName = "PredavacPredmeta";
            this.Profesor.HeaderText = "Profesor";
            this.Profesor.Name = "Profesor";
            this.Profesor.ReadOnly = true;
            // 
            // GodinaStudija
            // 
            this.GodinaStudija.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GodinaStudija.DataPropertyName = "GodinaStudija";
            this.GodinaStudija.HeaderText = "Godina studija";
            this.GodinaStudija.Name = "GodinaStudija";
            this.GodinaStudija.ReadOnly = true;
            // 
            // Ocjena
            // 
            this.Ocjena.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ocjena.DataPropertyName = "OcjenaPredmeta";
            this.Ocjena.HeaderText = "Ocjena";
            this.Ocjena.Name = "Ocjena";
            this.Ocjena.ReadOnly = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Zilla Slab", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(92, 301);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 22);
            this.label11.TabIndex = 19;
            this.label11.Text = "1.1.2000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Zilla Slab", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(67, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 19);
            this.label5.TabIndex = 18;
            this.label5.Text = "Datum rodjenja";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Zilla Slab", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label9.Location = new System.Drawing.Point(9, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 18);
            this.label9.TabIndex = 17;
            this.label9.Text = "Licni podaci";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label10.Location = new System.Drawing.Point(9, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(977, 1);
            this.label10.TabIndex = 16;
            // 
            // pbProfilnaStudenta
            // 
            this.pbProfilnaStudenta.Location = new System.Drawing.Point(36, 61);
            this.pbProfilnaStudenta.Margin = new System.Windows.Forms.Padding(4);
            this.pbProfilnaStudenta.Name = "pbProfilnaStudenta";
            this.pbProfilnaStudenta.Size = new System.Drawing.Size(183, 217);
            this.pbProfilnaStudenta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProfilnaStudenta.TabIndex = 1;
            this.pbProfilnaStudenta.TabStop = false;
            // 
            // gbNovaFotografija
            // 
            this.gbNovaFotografija.BackColor = System.Drawing.Color.LightGray;
            this.gbNovaFotografija.Controls.Add(this.txtPutanjaDoSlike);
            this.gbNovaFotografija.Controls.Add(this.btnChooseFile);
            this.gbNovaFotografija.Controls.Add(this.btnChangePhoto);
            this.gbNovaFotografija.Controls.Add(this.label8);
            this.gbNovaFotografija.Controls.Add(this.label7);
            this.gbNovaFotografija.Controls.Add(this.label6);
            this.gbNovaFotografija.Location = new System.Drawing.Point(48, 482);
            this.gbNovaFotografija.Name = "gbNovaFotografija";
            this.gbNovaFotografija.Size = new System.Drawing.Size(989, 100);
            this.gbNovaFotografija.TabIndex = 18;
            this.gbNovaFotografija.TabStop = false;
            // 
            // txtPutanjaDoSlike
            // 
            this.txtPutanjaDoSlike.Font = new System.Drawing.Font("Zilla Slab", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPutanjaDoSlike.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPutanjaDoSlike.Location = new System.Drawing.Point(379, 52);
            this.txtPutanjaDoSlike.Name = "txtPutanjaDoSlike";
            this.txtPutanjaDoSlike.ReadOnly = true;
            this.txtPutanjaDoSlike.Size = new System.Drawing.Size(235, 23);
            this.txtPutanjaDoSlike.TabIndex = 4;
            this.txtPutanjaDoSlike.Text = "No file chosen";
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(298, 51);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(75, 24);
            this.btnChooseFile.TabIndex = 3;
            this.btnChooseFile.Text = "Choose file";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Zilla Slab", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 18);
            this.label8.TabIndex = 2;
            this.label8.Text = "Fotografija:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Zilla Slab", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Location = new System.Drawing.Point(6, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "Nova fotografija";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(6, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(977, 1);
            this.label6.TabIndex = 0;
            // 
            // err2
            // 
            this.err2.ContainerControl = this;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBack.Font = new System.Drawing.Font("Zilla Slab SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(12, 34);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(65, 30);
            this.btnBack.TabIndex = 19;
            this.btnBack.Text = "<<Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmStudentPodaci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1075, 606);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gbNovaFotografija);
            this.Controls.Add(this.gbPodaci);
            this.Controls.Add(this.msMeni);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.msMeni;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmStudentPodaci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmStudentPodaci_Load);
            this.cmsMeni.ResumeLayout(false);
            this.msMeni.ResumeLayout(false);
            this.msMeni.PerformLayout();
            this.gbPodaci.ResumeLayout(false);
            this.gbPodaci.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPredmetiStudenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilnaStudenta)).EndInit();
            this.gbNovaFotografija.ResumeLayout(false);
            this.gbNovaFotografija.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err2)).EndInit();
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
        private System.Windows.Forms.ContextMenuStrip cmsMeni;
        private System.Windows.Forms.OpenFileDialog ofdSlika;
        private System.Windows.Forms.MenuStrip msMeni;
        private System.Windows.Forms.ToolStripMenuItem postavkeToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbPodaci;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox gbNovaFotografija;
        private System.Windows.Forms.TextBox txtPutanjaDoSlike;
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvPredmetiStudenta;
        private System.Windows.Forms.Label lblBrojPolozenih;
        private System.Windows.Forms.ToolStripMenuItem checkDetailsToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivPredmeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profesor;
        private System.Windows.Forms.DataGridViewTextBoxColumn GodinaStudija;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocjena;
        private System.Windows.Forms.ToolStripMenuItem urediPodatkeToolStripMenuItem;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.ErrorProvider err2;
        private System.Windows.Forms.Button btnBack;
    }
}