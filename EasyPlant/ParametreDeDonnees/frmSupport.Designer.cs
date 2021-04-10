namespace EasyPlant
{
    partial class Support
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
            this.btndelete = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.textmatiere = new System.Windows.Forms.TextBox();
            this.textlibelle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textMarge = new System.Windows.Forms.TextBox();
            this.textPrixAchatTTC = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textPrixVenteTTC = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textTVA = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textPrixVenteHT = new System.Windows.Forms.TextBox();
            this.textPrixAchatHT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textVolAlv = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textmottes = new System.Windows.Forms.TextBox();
            this.textdimension = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textpoids = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textcode = new System.Windows.Forms.TextBox();
            this.code = new System.Windows.Forms.Label();
            this.SupportDataGrid = new System.Windows.Forms.DataGridView();
            this.CodeSupport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Libelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matiere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dimension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NbrAlv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VolAlv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Poids = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SupportDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Green;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(549, 186);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(126, 43);
            this.btndelete.TabIndex = 13;
            this.btndelete.Text = "Supprimer";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Green;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Location = new System.Drawing.Point(52, 186);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(126, 43);
            this.btnsave.TabIndex = 12;
            this.btnsave.Text = "Enregistrer";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.Green;
            this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.ForeColor = System.Drawing.Color.White;
            this.btncancel.Location = new System.Drawing.Point(300, 186);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(126, 43);
            this.btncancel.TabIndex = 11;
            this.btncancel.Text = "Annuler";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // textmatiere
            // 
            this.textmatiere.Location = new System.Drawing.Point(386, 45);
            this.textmatiere.Name = "textmatiere";
            this.textmatiere.Size = new System.Drawing.Size(211, 20);
            this.textmatiere.TabIndex = 7;
            // 
            // textlibelle
            // 
            this.textlibelle.Location = new System.Drawing.Point(388, 10);
            this.textlibelle.Name = "textlibelle";
            this.textlibelle.Size = new System.Drawing.Size(209, 20);
            this.textlibelle.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(315, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Libelle : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(315, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Matière  : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dimension  (mm) :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.textVolAlv);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textmottes);
            this.panel1.Controls.Add(this.textdimension);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textpoids);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btndelete);
            this.panel1.Controls.Add(this.btnsave);
            this.panel1.Controls.Add(this.btncancel);
            this.panel1.Controls.Add(this.textmatiere);
            this.panel1.Controls.Add(this.textlibelle);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textcode);
            this.panel1.Controls.Add(this.code);
            this.panel1.Location = new System.Drawing.Point(12, 193);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(761, 245);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textMarge);
            this.panel2.Controls.Add(this.textPrixAchatTTC);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.textPrixVenteTTC);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.textTVA);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.textPrixVenteHT);
            this.panel2.Controls.Add(this.textPrixAchatHT);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(0, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(758, 74);
            this.panel2.TabIndex = 22;
            // 
            // textMarge
            // 
            this.textMarge.Location = new System.Drawing.Point(485, 10);
            this.textMarge.Name = "textMarge";
            this.textMarge.Size = new System.Drawing.Size(71, 20);
            this.textMarge.TabIndex = 26;
            this.textMarge.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // textPrixAchatTTC
            // 
            this.textPrixAchatTTC.Location = new System.Drawing.Point(628, 42);
            this.textPrixAchatTTC.Name = "textPrixAchatTTC";
            this.textPrixAchatTTC.Size = new System.Drawing.Size(71, 20);
            this.textPrixAchatTTC.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(411, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 16);
            this.label12.TabIndex = 25;
            this.label12.Text = "Marge % :";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(502, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 16);
            this.label11.TabIndex = 29;
            this.label11.Text = "Prix d\'Achat TTC   :";
            // 
            // textPrixVenteTTC
            // 
            this.textPrixVenteTTC.Location = new System.Drawing.Point(408, 41);
            this.textPrixVenteTTC.Name = "textPrixVenteTTC";
            this.textPrixVenteTTC.Size = new System.Drawing.Size(71, 20);
            this.textPrixVenteTTC.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(276, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 16);
            this.label10.TabIndex = 27;
            this.label10.Text = "Prix de Vente  TTC  :";
            // 
            // textTVA
            // 
            this.textTVA.Location = new System.Drawing.Point(334, 9);
            this.textTVA.Name = "textTVA";
            this.textTVA.Size = new System.Drawing.Size(71, 20);
            this.textTVA.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(276, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 16);
            this.label9.TabIndex = 25;
            this.label9.Text = "TVA % :";
            // 
            // textPrixVenteHT
            // 
            this.textPrixVenteHT.Location = new System.Drawing.Point(160, 37);
            this.textPrixVenteHT.Name = "textPrixVenteHT";
            this.textPrixVenteHT.Size = new System.Drawing.Size(71, 20);
            this.textPrixVenteHT.TabIndex = 24;
            // 
            // textPrixAchatHT
            // 
            this.textPrixAchatHT.Location = new System.Drawing.Point(160, 9);
            this.textPrixAchatHT.Name = "textPrixAchatHT";
            this.textPrixAchatHT.Size = new System.Drawing.Size(71, 20);
            this.textPrixAchatHT.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(40, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "Prix de Vente  HT  :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "Prix d\'Achat HT :";
            // 
            // textVolAlv
            // 
            this.textVolAlv.Location = new System.Drawing.Point(617, 78);
            this.textVolAlv.Name = "textVolAlv";
            this.textVolAlv.Size = new System.Drawing.Size(71, 20);
            this.textVolAlv.TabIndex = 21;
            this.textVolAlv.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(450, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Volume Alvéoles ( cm3)  : ";
            // 
            // textmottes
            // 
            this.textmottes.Location = new System.Drawing.Point(386, 78);
            this.textmottes.Name = "textmottes";
            this.textmottes.Size = new System.Drawing.Size(53, 20);
            this.textmottes.TabIndex = 19;
            // 
            // textdimension
            // 
            this.textdimension.Location = new System.Drawing.Point(162, 80);
            this.textdimension.Name = "textdimension";
            this.textdimension.Size = new System.Drawing.Size(71, 20);
            this.textdimension.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(88, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Poids (g) :";
            // 
            // textpoids
            // 
            this.textpoids.Location = new System.Drawing.Point(162, 46);
            this.textpoids.Name = "textpoids";
            this.textpoids.Size = new System.Drawing.Size(71, 20);
            this.textpoids.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(317, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Mottes   : ";
            // 
            // textcode
            // 
            this.textcode.Location = new System.Drawing.Point(162, 10);
            this.textcode.Name = "textcode";
            this.textcode.Size = new System.Drawing.Size(71, 20);
            this.textcode.TabIndex = 2;
            // 
            // code
            // 
            this.code.AutoSize = true;
            this.code.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.code.Location = new System.Drawing.Point(109, 10);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(47, 16);
            this.code.TabIndex = 1;
            this.code.Text = "Code :";
            // 
            // SupportDataGrid
            // 
            this.SupportDataGrid.AllowUserToDeleteRows = false;
            this.SupportDataGrid.BackgroundColor = System.Drawing.Color.Beige;
            this.SupportDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SupportDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodeSupport,
            this.Libelle,
            this.Matiere,
            this.Dimension,
            this.NbrAlv,
            this.VolAlv,
            this.Poids});
            this.SupportDataGrid.Location = new System.Drawing.Point(12, 12);
            this.SupportDataGrid.Name = "SupportDataGrid";
            this.SupportDataGrid.ReadOnly = true;
            this.SupportDataGrid.Size = new System.Drawing.Size(766, 161);
            this.SupportDataGrid.TabIndex = 5;
            this.SupportDataGrid.DoubleClick += new System.EventHandler(this.SupportDataGrid_DoubleClick);
            // 
            // CodeSupport
            // 
            this.CodeSupport.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CodeSupport.DataPropertyName = "CodeSupport";
            this.CodeSupport.HeaderText = "Code";
            this.CodeSupport.Name = "CodeSupport";
            this.CodeSupport.ReadOnly = true;
            // 
            // Libelle
            // 
            this.Libelle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Libelle.DataPropertyName = "Libelle";
            this.Libelle.HeaderText = "Libelle";
            this.Libelle.Name = "Libelle";
            this.Libelle.ReadOnly = true;
            // 
            // Matiere
            // 
            this.Matiere.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Matiere.DataPropertyName = "Matiere";
            this.Matiere.HeaderText = "Matière";
            this.Matiere.Name = "Matiere";
            this.Matiere.ReadOnly = true;
            // 
            // Dimension
            // 
            this.Dimension.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Dimension.DataPropertyName = "Dimension";
            this.Dimension.HeaderText = "Dimension";
            this.Dimension.Name = "Dimension";
            this.Dimension.ReadOnly = true;
            // 
            // NbrAlv
            // 
            this.NbrAlv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NbrAlv.DataPropertyName = "NbrAlv";
            this.NbrAlv.HeaderText = "Nbr.Alv";
            this.NbrAlv.Name = "NbrAlv";
            this.NbrAlv.ReadOnly = true;
            // 
            // VolAlv
            // 
            this.VolAlv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VolAlv.DataPropertyName = "VolAlv";
            this.VolAlv.HeaderText = "Vol.ALV";
            this.VolAlv.Name = "VolAlv";
            this.VolAlv.ReadOnly = true;
            // 
            // Poids
            // 
            this.Poids.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Poids.DataPropertyName = "Poids";
            this.Poids.HeaderText = "Poids";
            this.Poids.Name = "Poids";
            this.Poids.ReadOnly = true;
            // 
            // Support
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SupportDataGrid);
            this.Controls.Add(this.panel1);
            this.Name = "Support";
            this.Text = "Support";
            this.Load += new System.EventHandler(this.Support_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SupportDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.TextBox textmatiere;
        private System.Windows.Forms.TextBox textlibelle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textcode;
        private System.Windows.Forms.Label code;
        private System.Windows.Forms.TextBox textVolAlv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textmottes;
        private System.Windows.Forms.TextBox textdimension;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textpoids;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textMarge;
        private System.Windows.Forms.TextBox textPrixAchatTTC;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textPrixVenteTTC;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textTVA;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textPrixVenteHT;
        private System.Windows.Forms.TextBox textPrixAchatHT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView SupportDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeSupport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Libelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matiere;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dimension;
        private System.Windows.Forms.DataGridViewTextBoxColumn NbrAlv;
        private System.Windows.Forms.DataGridViewTextBoxColumn VolAlv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Poids;
    }
}