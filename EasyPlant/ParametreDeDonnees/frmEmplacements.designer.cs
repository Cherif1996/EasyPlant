
namespace EasyPlant
{
    partial class frmEmplacements
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
            this.dataGridEmplacement = new System.Windows.Forms.DataGridView();
            this.CodeEmplacement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Libelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CapaciteEmplacement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCodeEmpl = new System.Windows.Forms.TextBox();
            this.textBoxLibelle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCapaciteEmpl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmplacement)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridEmplacement
            // 
            this.dataGridEmplacement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEmplacement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodeEmplacement,
            this.Libelle,
            this.CapaciteEmplacement});
            this.dataGridEmplacement.Location = new System.Drawing.Point(12, 12);
            this.dataGridEmplacement.Name = "dataGridEmplacement";
            this.dataGridEmplacement.Size = new System.Drawing.Size(863, 140);
            this.dataGridEmplacement.TabIndex = 0;
            this.dataGridEmplacement.Click += new System.EventHandler(this.dataGridEmplacement_Click);
            // 
            // CodeEmplacement
            // 
            this.CodeEmplacement.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CodeEmplacement.DataPropertyName = "CodeEmplacement";
            this.CodeEmplacement.HeaderText = "Code Emplacement ";
            this.CodeEmplacement.Name = "CodeEmplacement";
            // 
            // Libelle
            // 
            this.Libelle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Libelle.DataPropertyName = "Libelle";
            this.Libelle.HeaderText = "Libelle";
            this.Libelle.Name = "Libelle";
            // 
            // CapaciteEmplacement
            // 
            this.CapaciteEmplacement.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CapaciteEmplacement.DataPropertyName = "CapaciteEmplacement";
            this.CapaciteEmplacement.HeaderText = "Capacte Emplacement";
            this.CapaciteEmplacement.Name = "CapaciteEmplacement";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Code Emplacement";
            // 
            // textBoxCodeEmpl
            // 
            this.textBoxCodeEmpl.Location = new System.Drawing.Point(164, 236);
            this.textBoxCodeEmpl.Name = "textBoxCodeEmpl";
            this.textBoxCodeEmpl.Size = new System.Drawing.Size(141, 20);
            this.textBoxCodeEmpl.TabIndex = 2;
            // 
            // textBoxLibelle
            // 
            this.textBoxLibelle.Location = new System.Drawing.Point(382, 236);
            this.textBoxLibelle.Name = "textBoxLibelle";
            this.textBoxLibelle.Size = new System.Drawing.Size(141, 20);
            this.textBoxLibelle.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(327, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Libelle";
            // 
            // textBoxCapaciteEmpl
            // 
            this.textBoxCapaciteEmpl.Location = new System.Drawing.Point(713, 234);
            this.textBoxCapaciteEmpl.Name = "textBoxCapaciteEmpl";
            this.textBoxCapaciteEmpl.Size = new System.Drawing.Size(141, 20);
            this.textBoxCapaciteEmpl.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(560, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Capacité Emplacement";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSave.Location = new System.Drawing.Point(164, 340);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(141, 34);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Enregistrer";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCancel.Location = new System.Drawing.Point(382, 340);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(141, 34);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.SeaGreen;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDelete.Location = new System.Drawing.Point(577, 340);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(141, 34);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Supprimer";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmEmplacements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textBoxCapaciteEmpl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxLibelle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCodeEmpl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridEmplacement);
            this.Name = "frmEmplacements";
            this.Text = "Listes Emplacement";
            this.Load += new System.EventHandler(this.frmEmplacements_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmplacement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridEmplacement;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeEmplacement;
        private System.Windows.Forms.DataGridViewTextBoxColumn Libelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn CapaciteEmplacement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCodeEmpl;
        private System.Windows.Forms.TextBox textBoxLibelle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCapaciteEmpl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
    }
}