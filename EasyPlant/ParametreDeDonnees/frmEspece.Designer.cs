namespace EasyPlant.ParametreDeDonnees
{
    partial class frmEspece
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
            this.DataGridespece = new System.Windows.Forms.DataGridView();
            this.CodeEspece = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LibelleEspece = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Famille = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btndelete = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.combofamille = new System.Windows.Forms.ComboBox();
            this.textlibelle = new System.Windows.Forms.TextBox();
            this.famile = new System.Windows.Forms.Label();
            this.libele = new System.Windows.Forms.Label();
            this.textcode = new System.Windows.Forms.TextBox();
            this.code = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridespece)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridespece
            // 
            this.DataGridespece.AllowUserToDeleteRows = false;
            this.DataGridespece.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridespece.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodeEspece,
            this.LibelleEspece,
            this.Famille});
            this.DataGridespece.Location = new System.Drawing.Point(17, 12);
            this.DataGridespece.Name = "DataGridespece";
            this.DataGridespece.ReadOnly = true;
            this.DataGridespece.Size = new System.Drawing.Size(439, 188);
            this.DataGridespece.TabIndex = 5;
            this.DataGridespece.DoubleClick += new System.EventHandler(this.DataGridespece_DoubleClick);
            // 
            // CodeEspece
            // 
            this.CodeEspece.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CodeEspece.DataPropertyName = "CodeEspece";
            this.CodeEspece.HeaderText = "Code";
            this.CodeEspece.Name = "CodeEspece";
            this.CodeEspece.ReadOnly = true;
            // 
            // LibelleEspece
            // 
            this.LibelleEspece.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LibelleEspece.DataPropertyName = "LibelleEspece";
            this.LibelleEspece.HeaderText = "Libelle";
            this.LibelleEspece.Name = "LibelleEspece";
            this.LibelleEspece.ReadOnly = true;
            // 
            // Famille
            // 
            this.Famille.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Famille.DataPropertyName = "LibelleFamille";
            this.Famille.HeaderText = "Famille";
            this.Famille.Name = "Famille";
            this.Famille.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btndelete);
            this.panel1.Controls.Add(this.btncancel);
            this.panel1.Controls.Add(this.btnsave);
            this.panel1.Controls.Add(this.combofamille);
            this.panel1.Controls.Add(this.textlibelle);
            this.panel1.Controls.Add(this.famile);
            this.panel1.Controls.Add(this.libele);
            this.panel1.Controls.Add(this.textcode);
            this.panel1.Controls.Add(this.code);
            this.panel1.Location = new System.Drawing.Point(17, 206);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 232);
            this.panel1.TabIndex = 4;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Green;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(280, 166);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(126, 43);
            this.btndelete.TabIndex = 23;
            this.btndelete.Text = "Supprimer";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.Green;
            this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.ForeColor = System.Drawing.Color.White;
            this.btncancel.Location = new System.Drawing.Point(148, 166);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(126, 43);
            this.btncancel.TabIndex = 22;
            this.btncancel.Text = "Annuler";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Green;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Location = new System.Drawing.Point(16, 166);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(126, 43);
            this.btnsave.TabIndex = 21;
            this.btnsave.Text = "Enregistrer";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // combofamille
            // 
            this.combofamille.FormattingEnabled = true;
            this.combofamille.Location = new System.Drawing.Point(168, 102);
            this.combofamille.Name = "combofamille";
            this.combofamille.Size = new System.Drawing.Size(124, 21);
            this.combofamille.TabIndex = 5;
            // 
            // textlibelle
            // 
            this.textlibelle.Location = new System.Drawing.Point(168, 68);
            this.textlibelle.Name = "textlibelle";
            this.textlibelle.Size = new System.Drawing.Size(124, 20);
            this.textlibelle.TabIndex = 4;
            // 
            // famile
            // 
            this.famile.AutoSize = true;
            this.famile.Location = new System.Drawing.Point(115, 102);
            this.famile.Name = "famile";
            this.famile.Size = new System.Drawing.Size(45, 13);
            this.famile.TabIndex = 3;
            this.famile.Text = "Famille :";
            // 
            // libele
            // 
            this.libele.AutoSize = true;
            this.libele.Location = new System.Drawing.Point(115, 71);
            this.libele.Name = "libele";
            this.libele.Size = new System.Drawing.Size(43, 13);
            this.libele.TabIndex = 2;
            this.libele.Text = "Libelle :";
            // 
            // textcode
            // 
            this.textcode.Location = new System.Drawing.Point(168, 34);
            this.textcode.Name = "textcode";
            this.textcode.Size = new System.Drawing.Size(124, 20);
            this.textcode.TabIndex = 1;
            // 
            // code
            // 
            this.code.AutoSize = true;
            this.code.Location = new System.Drawing.Point(115, 37);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(38, 13);
            this.code.TabIndex = 0;
            this.code.Text = "Code :";
            // 
            // frmEspece
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 450);
            this.Controls.Add(this.DataGridespece);
            this.Controls.Add(this.panel1);
            this.Name = "frmEspece";
            this.Text = "frmEspece";
            this.Load += new System.EventHandler(this.frmEspece_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridespece)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DataGridespece;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textcode;
        private System.Windows.Forms.Label code;
        private System.Windows.Forms.ComboBox combofamille;
        private System.Windows.Forms.TextBox textlibelle;
        private System.Windows.Forms.Label famile;
        private System.Windows.Forms.Label libele;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeEspece;
        private System.Windows.Forms.DataGridViewTextBoxColumn LibelleEspece;
        private System.Windows.Forms.DataGridViewTextBoxColumn Famille;
    }
}