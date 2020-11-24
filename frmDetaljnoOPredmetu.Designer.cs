namespace DLWMS_Demo
{
    partial class frmDetaljnoOPredmetu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNazivPredmeta = new System.Windows.Forms.Label();
            this.lblPredavac = new System.Windows.Forms.Label();
            this.lblECTS = new System.Windows.Forms.Label();
            this.lblBrojSati = new System.Windows.Forms.Label();
            this.dgvOcjenePredmeta = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.Ocjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOcjenePredmeta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Zilla Slab", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv predmeta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Zilla Slab", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Predavac na predmetu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Zilla Slab", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(104, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Broj sati:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Zilla Slab", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(124, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "ECTS:";
            // 
            // lblNazivPredmeta
            // 
            this.lblNazivPredmeta.AutoSize = true;
            this.lblNazivPredmeta.Font = new System.Drawing.Font("Zilla Slab", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNazivPredmeta.Location = new System.Drawing.Point(172, 55);
            this.lblNazivPredmeta.Name = "lblNazivPredmeta";
            this.lblNazivPredmeta.Size = new System.Drawing.Size(52, 19);
            this.lblNazivPredmeta.TabIndex = 4;
            this.lblNazivPredmeta.Text = "label5";
            // 
            // lblPredavac
            // 
            this.lblPredavac.AutoSize = true;
            this.lblPredavac.Font = new System.Drawing.Font("Zilla Slab", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPredavac.Location = new System.Drawing.Point(171, 95);
            this.lblPredavac.Name = "lblPredavac";
            this.lblPredavac.Size = new System.Drawing.Size(53, 19);
            this.lblPredavac.TabIndex = 5;
            this.lblPredavac.Text = "label6";
            // 
            // lblECTS
            // 
            this.lblECTS.AutoSize = true;
            this.lblECTS.Font = new System.Drawing.Font("Zilla Slab", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblECTS.Location = new System.Drawing.Point(173, 175);
            this.lblECTS.Name = "lblECTS";
            this.lblECTS.Size = new System.Drawing.Size(52, 19);
            this.lblECTS.TabIndex = 6;
            this.lblECTS.Text = "label7";
            // 
            // lblBrojSati
            // 
            this.lblBrojSati.AutoSize = true;
            this.lblBrojSati.Font = new System.Drawing.Font("Zilla Slab", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrojSati.Location = new System.Drawing.Point(172, 135);
            this.lblBrojSati.Name = "lblBrojSati";
            this.lblBrojSati.Size = new System.Drawing.Size(53, 19);
            this.lblBrojSati.TabIndex = 7;
            this.lblBrojSati.Text = "label8";
            // 
            // dgvOcjenePredmeta
            // 
            this.dgvOcjenePredmeta.AllowUserToAddRows = false;
            this.dgvOcjenePredmeta.AllowUserToDeleteRows = false;
            this.dgvOcjenePredmeta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOcjenePredmeta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ocjena});
            this.dgvOcjenePredmeta.Location = new System.Drawing.Point(308, 66);
            this.dgvOcjenePredmeta.Name = "dgvOcjenePredmeta";
            this.dgvOcjenePredmeta.ReadOnly = true;
            this.dgvOcjenePredmeta.Size = new System.Drawing.Size(146, 177);
            this.dgvOcjenePredmeta.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Zilla Slab", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(309, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ocjene iz predmeta";
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnGoBack.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGoBack.Font = new System.Drawing.Font("Zilla Slab SemiBold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGoBack.Location = new System.Drawing.Point(12, 12);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(85, 27);
            this.btnGoBack.TabIndex = 10;
            this.btnGoBack.Text = "<< Go Back";
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // Ocjena
            // 
            this.Ocjena.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ocjena.DataPropertyName = "string";
            this.Ocjena.HeaderText = "Ocjena";
            this.Ocjena.Name = "Ocjena";
            this.Ocjena.ReadOnly = true;
            // 
            // frmDetaljnoOPredmetu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 254);
            this.ControlBox = false;
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvOcjenePredmeta);
            this.Controls.Add(this.lblBrojSati);
            this.Controls.Add(this.lblECTS);
            this.Controls.Add(this.lblPredavac);
            this.Controls.Add(this.lblNazivPredmeta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDetaljnoOPredmetu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detaljan prikaz";
            this.Load += new System.EventHandler(this.frmDetaljnoOPredmetu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOcjenePredmeta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNazivPredmeta;
        private System.Windows.Forms.Label lblPredavac;
        private System.Windows.Forms.Label lblECTS;
        private System.Windows.Forms.Label lblBrojSati;
        private System.Windows.Forms.DataGridView dgvOcjenePredmeta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocjena;
    }
}