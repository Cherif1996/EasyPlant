namespace EasyPlant.DAL
{
    partial class PointDeVente
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textville = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textadresse = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textlibelle = new System.Windows.Forms.TextBox();
            this.textcode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PointVenteDataGrid = new System.Windows.Forms.DataGridView();
            this.CodePointVente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Libelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ville = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PointVenteDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Green;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(350, 346);
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
            this.btnsave.Location = new System.Drawing.Point(16, 346);
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
            this.btncancel.Location = new System.Drawing.Point(186, 346);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(126, 43);
            this.btncancel.TabIndex = 19;
            this.btncancel.Text = "Annuler";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textville);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textadresse);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textlibelle);
            this.panel1.Controls.Add(this.textcode);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(16, 176);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 149);
            this.panel1.TabIndex = 18;
            // 
            // textville
            // 
            this.textville.Location = new System.Drawing.Point(170, 117);
            this.textville.Name = "textville";
            this.textville.Size = new System.Drawing.Size(154, 20);
            this.textville.TabIndex = 7;
            this.textville.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(107, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ville : ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textadresse
            // 
            this.textadresse.Location = new System.Drawing.Point(170, 81);
            this.textadresse.Name = "textadresse";
            this.textadresse.Size = new System.Drawing.Size(154, 20);
            this.textadresse.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(107, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Adresse : ";
            // 
            // textlibelle
            // 
            this.textlibelle.Location = new System.Drawing.Point(170, 47);
            this.textlibelle.Name = "textlibelle";
            this.textlibelle.Size = new System.Drawing.Size(154, 20);
            this.textlibelle.TabIndex = 3;
            // 
            // textcode
            // 
            this.textcode.Location = new System.Drawing.Point(170, 15);
            this.textcode.Name = "textcode";
            this.textcode.Size = new System.Drawing.Size(56, 20);
            this.textcode.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Libelle : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code :";
            // 
            // PointVenteDataGrid
            // 
            this.PointVenteDataGrid.AllowUserToDeleteRows = false;
            this.PointVenteDataGrid.BackgroundColor = System.Drawing.Color.Beige;
            this.PointVenteDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PointVenteDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodePointVente,
            this.Libelle,
            this.Adresse,
            this.Ville});
            this.PointVenteDataGrid.Location = new System.Drawing.Point(12, 12);
            this.PointVenteDataGrid.Name = "PointVenteDataGrid";
            this.PointVenteDataGrid.ReadOnly = true;
            this.PointVenteDataGrid.Size = new System.Drawing.Size(460, 150);
            this.PointVenteDataGrid.TabIndex = 17;
            this.PointVenteDataGrid.DoubleClick += new System.EventHandler(this.PointVenteDataGrid_DoubleClick);
            // 
            // CodePointVente
            // 
            this.CodePointVente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CodePointVente.DataPropertyName = "CodePointVente";
            this.CodePointVente.HeaderText = "Code";
            this.CodePointVente.Name = "CodePointVente";
            this.CodePointVente.ReadOnly = true;
            // 
            // Libelle
            // 
            this.Libelle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Libelle.DataPropertyName = "Libelle";
            this.Libelle.HeaderText = "Libelle";
            this.Libelle.Name = "Libelle";
            this.Libelle.ReadOnly = true;
            // 
            // Adresse
            // 
            this.Adresse.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Adresse.DataPropertyName = "Adresse";
            this.Adresse.HeaderText = "Adresse";
            this.Adresse.Name = "Adresse";
            this.Adresse.ReadOnly = true;
            // 
            // Ville
            // 
            this.Ville.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ville.DataPropertyName = "Ville";
            this.Ville.HeaderText = "Ville";
            this.Ville.Name = "Ville";
            this.Ville.ReadOnly = true;
            // 
            // PointDeVente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 450);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PointVenteDataGrid);
            this.Name = "PointDeVente";
            this.Text = "Point De Vente";
            this.Load += new System.EventHandler(this.PointDeVente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PointVenteDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textlibelle;
        private System.Windows.Forms.TextBox textcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView PointVenteDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodePointVente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Libelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ville;
        private System.Windows.Forms.TextBox textville;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textadresse;
        private System.Windows.Forms.Label label3;
    }
}