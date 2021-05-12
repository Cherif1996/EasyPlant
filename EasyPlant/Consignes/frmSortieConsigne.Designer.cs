
namespace EasyPlant.Consignes
{
    partial class frmSortieConsigne
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textNumSortie = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxLivreur = new System.Windows.Forms.ComboBox();
            this.comboBoxMoyenTrans = new System.Windows.Forms.ComboBox();
            this.comboboxDestination = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textNote = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textCodeSupport = new System.Windows.Forms.TextBox();
            this.textlibelle = new System.Windows.Forms.TextBox();
            this.textQte = new System.Windows.Forms.TextBox();
            this.textPrixTot = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridSortieConsigne = new System.Windows.Forms.DataGridView();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrixUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrixTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dateSortie = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textPrixUnit = new System.Windows.Forms.TextBox();
            this.btnValider = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSortieConsigne)).BeginInit();
            this.SuspendLayout();
            // 
            // textNumSortie
            // 
            this.textNumSortie.Location = new System.Drawing.Point(84, 17);
            this.textNumSortie.Name = "textNumSortie";
            this.textNumSortie.Size = new System.Drawing.Size(156, 23);
            this.textNumSortie.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numéro";
            // 
            // comboBoxLivreur
            // 
            this.comboBoxLivreur.FormattingEnabled = true;
            this.comboBoxLivreur.Location = new System.Drawing.Point(84, 65);
            this.comboBoxLivreur.Name = "comboBoxLivreur";
            this.comboBoxLivreur.Size = new System.Drawing.Size(179, 23);
            this.comboBoxLivreur.TabIndex = 3;
            // 
            // comboBoxMoyenTrans
            // 
            this.comboBoxMoyenTrans.FormattingEnabled = true;
            this.comboBoxMoyenTrans.Location = new System.Drawing.Point(838, 72);
            this.comboBoxMoyenTrans.Name = "comboBoxMoyenTrans";
            this.comboBoxMoyenTrans.Size = new System.Drawing.Size(179, 23);
            this.comboBoxMoyenTrans.TabIndex = 4;
            // 
            // comboboxDestination
            // 
            this.comboboxDestination.FormattingEnabled = true;
            this.comboboxDestination.Location = new System.Drawing.Point(838, 17);
            this.comboboxDestination.Name = "comboboxDestination";
            this.comboboxDestination.Size = new System.Drawing.Size(179, 23);
            this.comboboxDestination.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(695, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Source/Destination";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(695, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Moyen de Transport ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Livreur";
            // 
            // textNote
            // 
            this.textNote.Location = new System.Drawing.Point(84, 106);
            this.textNote.Name = "textNote";
            this.textNote.Size = new System.Drawing.Size(936, 23);
            this.textNote.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Note";
            // 
            // textCodeSupport
            // 
            this.textCodeSupport.Location = new System.Drawing.Point(84, 161);
            this.textCodeSupport.Name = "textCodeSupport";
            this.textCodeSupport.Size = new System.Drawing.Size(133, 23);
            this.textCodeSupport.TabIndex = 11;
            // 
            // textlibelle
            // 
            this.textlibelle.Location = new System.Drawing.Point(284, 161);
            this.textlibelle.Name = "textlibelle";
            this.textlibelle.Size = new System.Drawing.Size(191, 23);
            this.textlibelle.TabIndex = 12;
            // 
            // textQte
            // 
            this.textQte.Location = new System.Drawing.Point(569, 161);
            this.textQte.Name = "textQte";
            this.textQte.Size = new System.Drawing.Size(87, 23);
            this.textQte.TabIndex = 13;
            // 
            // textPrixTot
            // 
            this.textPrixTot.Location = new System.Drawing.Point(950, 161);
            this.textPrixTot.Name = "textPrixTot";
            this.textPrixTot.Size = new System.Drawing.Size(117, 23);
            this.textPrixTot.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Code";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(235, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Libellé";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(507, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "Qunatité";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(890, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "Prix Total";
            // 
            // dataGridSortieConsigne
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dataGridSortieConsigne.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridSortieConsigne.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridSortieConsigne.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridSortieConsigne.ColumnHeadersHeight = 35;
            this.dataGridSortieConsigne.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.Designation,
            this.PrixUnit,
            this.Qte,
            this.PrixTotal});
            this.dataGridSortieConsigne.EnableHeadersVisualStyles = false;
            this.dataGridSortieConsigne.GridColor = System.Drawing.Color.DarkGreen;
            this.dataGridSortieConsigne.Location = new System.Drawing.Point(38, 256);
            this.dataGridSortieConsigne.Name = "dataGridSortieConsigne";
            this.dataGridSortieConsigne.Size = new System.Drawing.Size(1029, 213);
            this.dataGridSortieConsigne.TabIndex = 19;
            // 
            // Code
            // 
            this.Code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Code.DataPropertyName = "CodeSupport";
            this.Code.HeaderText = "Code";
            this.Code.Name = "Code";
            // 
            // Designation
            // 
            this.Designation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Designation.DataPropertyName = "Designation";
            this.Designation.HeaderText = "Désignation";
            this.Designation.Name = "Designation";
            // 
            // PrixUnit
            // 
            this.PrixUnit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PrixUnit.DataPropertyName = "PrixUnit";
            this.PrixUnit.HeaderText = "Prix Unit";
            this.PrixUnit.Name = "PrixUnit";
            // 
            // Qte
            // 
            this.Qte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Qte.DataPropertyName = "Qte";
            this.Qte.HeaderText = "Qte";
            this.Qte.Name = "Qte";
            // 
            // PrixTotal
            // 
            this.PrixTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PrixTotal.DataPropertyName = "PrixTot";
            this.PrixTotal.HeaderText = "Prix Total";
            this.PrixTotal.Name = "PrixTotal";
            // 
            // btnNouveau
            // 
            this.btnNouveau.BackColor = System.Drawing.Color.SeaGreen;
            this.btnNouveau.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNouveau.ForeColor = System.Drawing.SystemColors.Window;
            this.btnNouveau.Location = new System.Drawing.Point(35, 486);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(177, 50);
            this.btnNouveau.TabIndex = 20;
            this.btnNouveau.Text = "Nouveau";
            this.btnNouveau.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSave.Location = new System.Drawing.Point(219, 486);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(177, 50);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Enregistrer";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SeaGreen;
            this.button3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Window;
            this.button3.Location = new System.Drawing.Point(899, 486);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(177, 50);
            this.button3.TabIndex = 22;
            this.button3.Text = "Imrimper";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.SeaGreen;
            this.btncancel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.ForeColor = System.Drawing.SystemColors.Window;
            this.btncancel.Location = new System.Drawing.Point(525, 486);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(177, 50);
            this.btncancel.TabIndex = 23;
            this.btncancel.Text = "Annuler";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.SeaGreen;
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDelete.Location = new System.Drawing.Point(709, 486);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(177, 50);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "Supprimer";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dateSortie
            // 
            this.dateSortie.Location = new System.Drawing.Point(318, 17);
            this.dateSortie.Name = "dateSortie";
            this.dateSortie.Size = new System.Drawing.Size(201, 23);
            this.dateSortie.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(276, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 15);
            this.label10.TabIndex = 26;
            this.label10.Text = "Date";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(671, 163);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 15);
            this.label11.TabIndex = 28;
            this.label11.Text = "Prix Unitaire";
            // 
            // textPrixUnit
            // 
            this.textPrixUnit.Location = new System.Drawing.Point(750, 161);
            this.textPrixUnit.Name = "textPrixUnit";
            this.textPrixUnit.Size = new System.Drawing.Size(117, 23);
            this.textPrixUnit.TabIndex = 27;
            this.textPrixUnit.TextChanged += new System.EventHandler(this.textPrixUnit_TextChanged);
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnValider.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnValider.Location = new System.Drawing.Point(890, 199);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(177, 50);
            this.btnValider.TabIndex = 29;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // frmSortieConsigne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 553);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textPrixUnit);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dateSortie);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNouveau);
            this.Controls.Add(this.dataGridSortieConsigne);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textPrixTot);
            this.Controls.Add(this.textQte);
            this.Controls.Add(this.textlibelle);
            this.Controls.Add(this.textCodeSupport);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textNote);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboboxDestination);
            this.Controls.Add(this.comboBoxMoyenTrans);
            this.Controls.Add(this.comboBoxLivreur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textNumSortie);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmSortieConsigne";
            this.Text = "frmSortieConsigne";
            this.Load += new System.EventHandler(this.frmSortieConsigne_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSortieConsigne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNumSortie;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxLivreur;
        private System.Windows.Forms.ComboBox comboBoxMoyenTrans;
        private System.Windows.Forms.ComboBox comboboxDestination;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textNote;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textCodeSupport;
        private System.Windows.Forms.TextBox textlibelle;
        private System.Windows.Forms.TextBox textQte;
        private System.Windows.Forms.TextBox textPrixTot;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridSortieConsigne;
        private System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DateTimePicker dateSortie;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textPrixUnit;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrixUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qte;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrixTotal;
    }
}