namespace EasyPlant
{
    partial class frmCodeLibelle
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
            this.LivreurDataGrid = new System.Windows.Forms.DataGridView();
            this.CodeLivreur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LibelleGd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textlibelle = new System.Windows.Forms.TextBox();
            this.textcode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LivreurDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LivreurDataGrid
            // 
            this.LivreurDataGrid.AllowUserToDeleteRows = false;
            this.LivreurDataGrid.BackgroundColor = System.Drawing.Color.Beige;
            this.LivreurDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LivreurDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodeLivreur,
            this.LibelleGd});
            this.LivreurDataGrid.Location = new System.Drawing.Point(12, 12);
            this.LivreurDataGrid.Name = "LivreurDataGrid";
            this.LivreurDataGrid.ReadOnly = true;
            this.LivreurDataGrid.Size = new System.Drawing.Size(460, 150);
            this.LivreurDataGrid.TabIndex = 17;
            this.LivreurDataGrid.DoubleClick += new System.EventHandler(this.LivreurDataGrid_DoubleClick);
            // 
            // CodeLivreur
            // 
            this.CodeLivreur.DataPropertyName = "Code";
            this.CodeLivreur.HeaderText = "Code";
            this.CodeLivreur.Name = "CodeLivreur";
            this.CodeLivreur.ReadOnly = true;
            // 
            // LibelleGd
            // 
            this.LibelleGd.DataPropertyName = "Libelle";
            this.LibelleGd.HeaderText = "Libelle";
            this.LibelleGd.Name = "LibelleGd";
            this.LibelleGd.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textlibelle);
            this.panel1.Controls.Add(this.textcode);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 191);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 125);
            this.panel1.TabIndex = 18;
            // 
            // textlibelle
            // 
            this.textlibelle.Location = new System.Drawing.Point(119, 66);
            this.textlibelle.Name = "textlibelle";
            this.textlibelle.Size = new System.Drawing.Size(154, 20);
            this.textlibelle.TabIndex = 3;
            // 
            // textcode
            // 
            this.textcode.Location = new System.Drawing.Point(119, 23);
            this.textcode.Name = "textcode";
            this.textcode.Size = new System.Drawing.Size(154, 20);
            this.textcode.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Libelle : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code :";
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Green;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(346, 344);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(126, 43);
            this.btndelete.TabIndex = 21;
            this.btndelete.Text = "Supprimer";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Green;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Location = new System.Drawing.Point(12, 344);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(126, 43);
            this.btnsave.TabIndex = 20;
            this.btnsave.Text = "Enregistrer";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.Green;
            this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.ForeColor = System.Drawing.Color.White;
            this.btncancel.Location = new System.Drawing.Point(182, 344);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(126, 43);
            this.btncancel.TabIndex = 19;
            this.btncancel.Text = "Annuler";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.Green;
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.ForeColor = System.Drawing.Color.White;
            this.btnModifier.Location = new System.Drawing.Point(12, 344);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(126, 43);
            this.btnModifier.TabIndex = 22;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Visible = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // frmCodeLibelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 450);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.LivreurDataGrid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btncancel);
            this.Name = "frmCodeLibelle";
            this.Text = "Livreur";
            this.Load += new System.EventHandler(this.frmCodeLibelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LivreurDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView LivreurDataGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textlibelle;
        private System.Windows.Forms.TextBox textcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeLivreur;
        private System.Windows.Forms.DataGridViewTextBoxColumn LibelleGd;
        private System.Windows.Forms.Button btnModifier;
    }
}