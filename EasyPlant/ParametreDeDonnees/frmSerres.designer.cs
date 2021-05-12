
namespace EasyPlant
{
    partial class frmSerres
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.textCapacite = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textSuperficie = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textCodeSerre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridSerre = new System.Windows.Forms.DataGridView();
            this.CodeSerre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Superficier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capacite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LibelleEmplacement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxLibelle = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSerre)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.SeaGreen;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDelete.Location = new System.Drawing.Point(611, 372);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(141, 34);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Supprimer";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCancel.Location = new System.Drawing.Point(416, 372);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(141, 34);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSave.Location = new System.Drawing.Point(198, 372);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(141, 34);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Enregistrer";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // textCapacite
            // 
            this.textCapacite.Location = new System.Drawing.Point(242, 267);
            this.textCapacite.Name = "textCapacite";
            this.textCapacite.Size = new System.Drawing.Size(141, 20);
            this.textCapacite.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(159, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Capacité ";
            // 
            // textSuperficie
            // 
            this.textSuperficie.Location = new System.Drawing.Point(591, 214);
            this.textSuperficie.Name = "textSuperficie";
            this.textSuperficie.Size = new System.Drawing.Size(141, 20);
            this.textSuperficie.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(501, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Superficier";
            // 
            // textCodeSerre
            // 
            this.textCodeSerre.Location = new System.Drawing.Point(242, 214);
            this.textCodeSerre.Name = "textCodeSerre";
            this.textCodeSerre.Size = new System.Drawing.Size(141, 20);
            this.textCodeSerre.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Code Serre";
            // 
            // dataGridSerre
            // 
            this.dataGridSerre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSerre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodeSerre,
            this.Superficier,
            this.Capacite,
            this.LibelleEmplacement});
            this.dataGridSerre.Location = new System.Drawing.Point(12, 12);
            this.dataGridSerre.Name = "dataGridSerre";
            this.dataGridSerre.Size = new System.Drawing.Size(863, 140);
            this.dataGridSerre.TabIndex = 10;
            this.dataGridSerre.Click += new System.EventHandler(this.dataGridSerre_Click);
            // 
            // CodeSerre
            // 
            this.CodeSerre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CodeSerre.DataPropertyName = "CodeSerre";
            this.CodeSerre.HeaderText = "Code Serre";
            this.CodeSerre.Name = "CodeSerre";
            // 
            // Superficier
            // 
            this.Superficier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Superficier.DataPropertyName = "Superficier";
            this.Superficier.HeaderText = "Superficier";
            this.Superficier.Name = "Superficier";
            // 
            // Capacite
            // 
            this.Capacite.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Capacite.DataPropertyName = "Capacite";
            this.Capacite.HeaderText = "Capacité";
            this.Capacite.Name = "Capacite";
            // 
            // LibelleEmplacement
            // 
            this.LibelleEmplacement.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LibelleEmplacement.DataPropertyName = "Libelle";
            this.LibelleEmplacement.HeaderText = "Libelle Emplacement";
            this.LibelleEmplacement.Name = "LibelleEmplacement";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(438, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 18);
            this.label4.TabIndex = 20;
            this.label4.Text = "Libelle Emplacement";
            // 
            // comboBoxLibelle
            // 
            this.comboBoxLibelle.FormattingEnabled = true;
            this.comboBoxLibelle.Location = new System.Drawing.Point(598, 267);
            this.comboBoxLibelle.Name = "comboBoxLibelle";
            this.comboBoxLibelle.Size = new System.Drawing.Size(133, 21);
            this.comboBoxLibelle.TabIndex = 21;
            // 
            // frmSerres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 450);
            this.Controls.Add(this.comboBoxLibelle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textCapacite);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textSuperficie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textCodeSerre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridSerre);
            this.Name = "frmSerres";
            this.Text = "frmSerres";
            this.Load += new System.EventHandler(this.frmSerres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSerre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox textCapacite;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textSuperficie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textCodeSerre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridSerre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeSerre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Superficier;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capacite;
        private System.Windows.Forms.DataGridViewTextBoxColumn LibelleEmplacement;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxLibelle;
    }
}