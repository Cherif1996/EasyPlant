namespace EasyPlant
{
    partial class frmSemencier
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
            this.code = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.textpays = new System.Windows.Forms.TextBox();
            this.textweb = new System.Windows.Forms.TextBox();
            this.textlibelle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textcode = new System.Windows.Forms.TextBox();
            this.SemecierDataGrid = new System.Windows.Forms.DataGridView();
            this.CodeSemencier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Libelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SiteWeb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SemecierDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // code
            // 
            this.code.AutoSize = true;
            this.code.Location = new System.Drawing.Point(30, 36);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(38, 13);
            this.code.TabIndex = 1;
            this.code.Text = "Code :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btndelete);
            this.panel1.Controls.Add(this.btnsave);
            this.panel1.Controls.Add(this.btncancel);
            this.panel1.Controls.Add(this.textpays);
            this.panel1.Controls.Add(this.textweb);
            this.panel1.Controls.Add(this.textlibelle);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textcode);
            this.panel1.Controls.Add(this.code);
            this.panel1.Location = new System.Drawing.Point(12, 206);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 232);
            this.panel1.TabIndex = 2;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Green;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(455, 164);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(120, 47);
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
            this.btnsave.Location = new System.Drawing.Point(146, 164);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(123, 47);
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
            this.btncancel.Location = new System.Drawing.Point(300, 164);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(123, 47);
            this.btncancel.TabIndex = 11;
            this.btncancel.Text = "Annuler";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // textpays
            // 
            this.textpays.Location = new System.Drawing.Point(333, 100);
            this.textpays.Name = "textpays";
            this.textpays.Size = new System.Drawing.Size(100, 20);
            this.textpays.TabIndex = 8;
            // 
            // textweb
            // 
            this.textweb.Location = new System.Drawing.Point(530, 36);
            this.textweb.Name = "textweb";
            this.textweb.Size = new System.Drawing.Size(175, 20);
            this.textweb.TabIndex = 7;
            // 
            // textlibelle
            // 
            this.textlibelle.Location = new System.Drawing.Point(313, 36);
            this.textlibelle.Name = "textlibelle";
            this.textlibelle.Size = new System.Drawing.Size(148, 20);
            this.textlibelle.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Libelle :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(467, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Site Web :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pays :";
            // 
            // textcode
            // 
            this.textcode.Location = new System.Drawing.Point(74, 33);
            this.textcode.Name = "textcode";
            this.textcode.Size = new System.Drawing.Size(110, 20);
            this.textcode.TabIndex = 2;
            // 
            // SemecierDataGrid
            // 
            this.SemecierDataGrid.AllowUserToDeleteRows = false;
            this.SemecierDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SemecierDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodeSemencier,
            this.Libelle,
            this.SiteWeb,
            this.Pays});
            this.SemecierDataGrid.Location = new System.Drawing.Point(12, 12);
            this.SemecierDataGrid.Name = "SemecierDataGrid";
            this.SemecierDataGrid.ReadOnly = true;
            this.SemecierDataGrid.Size = new System.Drawing.Size(766, 188);
            this.SemecierDataGrid.TabIndex = 3;
            this.SemecierDataGrid.DoubleClick += new System.EventHandler(this.SemecierDataGrid_DoubleClick);
            // 
            // CodeSemencier
            // 
            this.CodeSemencier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CodeSemencier.DataPropertyName = "CodeSemencier";
            this.CodeSemencier.HeaderText = "Code";
            this.CodeSemencier.Name = "CodeSemencier";
            this.CodeSemencier.ReadOnly = true;
            // 
            // Libelle
            // 
            this.Libelle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Libelle.DataPropertyName = "Libelle";
            this.Libelle.HeaderText = "Libelle";
            this.Libelle.Name = "Libelle";
            this.Libelle.ReadOnly = true;
            // 
            // SiteWeb
            // 
            this.SiteWeb.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SiteWeb.DataPropertyName = "SiteWeb";
            this.SiteWeb.HeaderText = "Site Web";
            this.SiteWeb.Name = "SiteWeb";
            this.SiteWeb.ReadOnly = true;
            // 
            // Pays
            // 
            this.Pays.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Pays.DataPropertyName = "Pays";
            this.Pays.HeaderText = "Pays";
            this.Pays.Name = "Pays";
            this.Pays.ReadOnly = true;
            // 
            // frmSemencier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SemecierDataGrid);
            this.Controls.Add(this.panel1);
            this.Name = "frmSemencier";
            this.Text = "Semencier";
            this.Load += new System.EventHandler(this.frmSemencier_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SemecierDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label code;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textcode;
        private System.Windows.Forms.DataGridView SemecierDataGrid;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.TextBox textpays;
        private System.Windows.Forms.TextBox textweb;
        private System.Windows.Forms.TextBox textlibelle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeSemencier;
        private System.Windows.Forms.DataGridViewTextBoxColumn Libelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn SiteWeb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pays;
    }
}