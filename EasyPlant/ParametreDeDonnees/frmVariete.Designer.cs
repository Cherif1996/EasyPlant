namespace EasyPlant.ParametreDeDonnees
{
    partial class frmVariete
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
            this.dataGridvariete = new System.Windows.Forms.DataGridView();
            this.CodeVariete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LibelleVariete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeEspece = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MntMarge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrixVente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NbrCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NbrCG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NbrPG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textcode = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textPG = new System.Windows.Forms.TextBox();
            this.textCG = new System.Windows.Forms.TextBox();
            this.textCV = new System.Windows.Forms.TextBox();
            this.textmarge = new System.Windows.Forms.TextBox();
            this.textprixvente = new System.Windows.Forms.TextBox();
            this.textmntmarge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboprod = new System.Windows.Forms.ComboBox();
            this.comboespece = new System.Windows.Forms.ComboBox();
            this.textlibelle = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridvariete)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Green;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(616, 414);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(126, 43);
            this.btndelete.TabIndex = 16;
            this.btndelete.Text = "Supprimer";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Green;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Location = new System.Drawing.Point(190, 414);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(126, 43);
            this.btnsave.TabIndex = 15;
            this.btnsave.Text = "Enregistrer";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.Green;
            this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.ForeColor = System.Drawing.Color.White;
            this.btncancel.Location = new System.Drawing.Point(411, 414);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(126, 43);
            this.btncancel.TabIndex = 14;
            this.btncancel.Text = "Annuler";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // dataGridvariete
            // 
            this.dataGridvariete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridvariete.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodeVariete,
            this.LibelleVariete,
            this.TypeProd,
            this.TypeEspece,
            this.marge,
            this.MntMarge,
            this.PrixVente,
            this.NbrCV,
            this.NbrCG,
            this.NbrPG});
            this.dataGridvariete.Location = new System.Drawing.Point(12, 25);
            this.dataGridvariete.Name = "dataGridvariete";
            this.dataGridvariete.Size = new System.Drawing.Size(889, 150);
            this.dataGridvariete.TabIndex = 17;
            this.dataGridvariete.DoubleClick += new System.EventHandler(this.dataGridvariete_DoubleClick);
            // 
            // CodeVariete
            // 
            this.CodeVariete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CodeVariete.DataPropertyName = "CodeVariete";
            this.CodeVariete.HeaderText = "Code";
            this.CodeVariete.Name = "CodeVariete";
            // 
            // LibelleVariete
            // 
            this.LibelleVariete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LibelleVariete.DataPropertyName = "LibelleVariete";
            this.LibelleVariete.HeaderText = "LibelleVariete";
            this.LibelleVariete.Name = "LibelleVariete";
            // 
            // TypeProd
            // 
            this.TypeProd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TypeProd.DataPropertyName = "Libelle";
            this.TypeProd.HeaderText = "Type Production";
            this.TypeProd.Name = "TypeProd";
            // 
            // TypeEspece
            // 
            this.TypeEspece.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TypeEspece.DataPropertyName = "LibelleEspece";
            this.TypeEspece.HeaderText = "LibelleEspece";
            this.TypeEspece.Name = "TypeEspece";
            // 
            // marge
            // 
            this.marge.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.marge.DataPropertyName = "Marge";
            this.marge.HeaderText = "Marge";
            this.marge.Name = "marge";
            // 
            // MntMarge
            // 
            this.MntMarge.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MntMarge.DataPropertyName = "MontantMarge";
            this.MntMarge.HeaderText = "Montant Marge";
            this.MntMarge.Name = "MntMarge";
            // 
            // PrixVente
            // 
            this.PrixVente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PrixVente.DataPropertyName = "PrixVente";
            this.PrixVente.HeaderText = "Prix de Vente";
            this.PrixVente.Name = "PrixVente";
            // 
            // NbrCV
            // 
            this.NbrCV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NbrCV.DataPropertyName = "NBjoursCV";
            this.NbrCV.HeaderText = "Nbr. CV";
            this.NbrCV.Name = "NbrCV";
            // 
            // NbrCG
            // 
            this.NbrCG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NbrCG.DataPropertyName = "NBjoursCG";
            this.NbrCG.HeaderText = "Nbr. CG";
            this.NbrCG.Name = "NbrCG";
            // 
            // NbrPG
            // 
            this.NbrPG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NbrPG.DataPropertyName = "NBjoursPG";
            this.NbrPG.HeaderText = "Nbr. PG";
            this.NbrPG.Name = "NbrPG";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Code :";
            // 
            // textcode
            // 
            this.textcode.Location = new System.Drawing.Point(66, 20);
            this.textcode.Name = "textcode";
            this.textcode.Size = new System.Drawing.Size(100, 20);
            this.textcode.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.textlibelle);
            this.panel1.Controls.Add(this.comboespece);
            this.panel1.Controls.Add(this.comboprod);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textmntmarge);
            this.panel1.Controls.Add(this.textprixvente);
            this.panel1.Controls.Add(this.textmarge);
            this.panel1.Controls.Add(this.textCV);
            this.panel1.Controls.Add(this.textCG);
            this.panel1.Controls.Add(this.textPG);
            this.panel1.Controls.Add(this.textcode);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 201);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(889, 184);
            this.panel1.TabIndex = 20;
            // 
            // textPG
            // 
            this.textPG.Location = new System.Drawing.Point(658, 142);
            this.textPG.Name = "textPG";
            this.textPG.Size = new System.Drawing.Size(100, 20);
            this.textPG.TabIndex = 20;
            // 
            // textCG
            // 
            this.textCG.Location = new System.Drawing.Point(449, 142);
            this.textCG.Name = "textCG";
            this.textCG.Size = new System.Drawing.Size(100, 20);
            this.textCG.TabIndex = 21;
            // 
            // textCV
            // 
            this.textCV.Location = new System.Drawing.Point(204, 142);
            this.textCV.Name = "textCV";
            this.textCV.Size = new System.Drawing.Size(100, 20);
            this.textCV.TabIndex = 22;
            // 
            // textmarge
            // 
            this.textmarge.Location = new System.Drawing.Point(178, 82);
            this.textmarge.Name = "textmarge";
            this.textmarge.Size = new System.Drawing.Size(100, 20);
            this.textmarge.TabIndex = 23;
            // 
            // textprixvente
            // 
            this.textprixvente.Location = new System.Drawing.Point(449, 78);
            this.textprixvente.Name = "textprixvente";
            this.textprixvente.Size = new System.Drawing.Size(100, 20);
            this.textprixvente.TabIndex = 24;
            // 
            // textmntmarge
            // 
            this.textmntmarge.Location = new System.Drawing.Point(658, 79);
            this.textmntmarge.Name = "textmntmarge";
            this.textmntmarge.Size = new System.Drawing.Size(100, 20);
            this.textmntmarge.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Nbr. CV :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Marge :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(567, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Montant Marge :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(601, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Nbr. PG :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(392, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Nbr. CG :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(424, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Type Production :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(367, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Prix de Vente :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(672, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Espèces :";
            // 
            // comboprod
            // 
            this.comboprod.FormattingEnabled = true;
            this.comboprod.Location = new System.Drawing.Point(531, 20);
            this.comboprod.Name = "comboprod";
            this.comboprod.Size = new System.Drawing.Size(121, 21);
            this.comboprod.TabIndex = 34;
            // 
            // comboespece
            // 
            this.comboespece.FormattingEnabled = true;
            this.comboespece.Location = new System.Drawing.Point(732, 20);
            this.comboespece.Name = "comboespece";
            this.comboespece.Size = new System.Drawing.Size(121, 21);
            this.comboespece.TabIndex = 35;
            // 
            // textlibelle
            // 
            this.textlibelle.Location = new System.Drawing.Point(274, 20);
            this.textlibelle.Name = "textlibelle";
            this.textlibelle.Size = new System.Drawing.Size(100, 20);
            this.textlibelle.TabIndex = 36;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(225, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Libelle :";
            // 
            // frmVariete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 494);
            this.Controls.Add(this.dataGridvariete);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.panel1);
            this.Name = "frmVariete";
            this.Text = "frmVariete";
            this.Load += new System.EventHandler(this.frmVariete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridvariete)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.DataGridView dataGridvariete;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeVariete;
        private System.Windows.Forms.DataGridViewTextBoxColumn LibelleVariete;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeEspece;
        private System.Windows.Forms.DataGridViewTextBoxColumn marge;
        private System.Windows.Forms.DataGridViewTextBoxColumn MntMarge;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrixVente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NbrCV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NbrCG;
        private System.Windows.Forms.DataGridViewTextBoxColumn NbrPG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textcode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textlibelle;
        private System.Windows.Forms.ComboBox comboespece;
        private System.Windows.Forms.ComboBox comboprod;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textmntmarge;
        private System.Windows.Forms.TextBox textprixvente;
        private System.Windows.Forms.TextBox textmarge;
        private System.Windows.Forms.TextBox textCV;
        private System.Windows.Forms.TextBox textCG;
        private System.Windows.Forms.TextBox textPG;
    }
}