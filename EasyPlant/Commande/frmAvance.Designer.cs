namespace EasyPlant.Commande
{
    partial class frmAvance
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
            this.dateAvance = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textMntAvance = new System.Windows.Forms.TextBox();
            this.comboNatureAvance = new System.Windows.Forms.ComboBox();
            this.comboBanque = new System.Windows.Forms.ComboBox();
            this.textNoteAvance = new System.Windows.Forms.TextBox();
            this.textPce = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dateAvance
            // 
            this.dateAvance.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateAvance.Location = new System.Drawing.Point(64, 24);
            this.dateAvance.Name = "dateAvance";
            this.dateAvance.Size = new System.Drawing.Size(141, 20);
            this.dateAvance.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Montant :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nature :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "N° Pce :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Banque :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(393, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Note :";
            // 
            // textMntAvance
            // 
            this.textMntAvance.Location = new System.Drawing.Point(269, 25);
            this.textMntAvance.Name = "textMntAvance";
            this.textMntAvance.Size = new System.Drawing.Size(100, 20);
            this.textMntAvance.TabIndex = 8;
            // 
            // comboNatureAvance
            // 
            this.comboNatureAvance.FormattingEnabled = true;
            this.comboNatureAvance.Location = new System.Drawing.Point(63, 78);
            this.comboNatureAvance.Name = "comboNatureAvance";
            this.comboNatureAvance.Size = new System.Drawing.Size(305, 21);
            this.comboNatureAvance.TabIndex = 10;
            // 
            // comboBanque
            // 
            this.comboBanque.FormattingEnabled = true;
            this.comboBanque.Location = new System.Drawing.Point(252, 135);
            this.comboBanque.Name = "comboBanque";
            this.comboBanque.Size = new System.Drawing.Size(117, 21);
            this.comboBanque.TabIndex = 11;
            // 
            // textNoteAvance
            // 
            this.textNoteAvance.Location = new System.Drawing.Point(447, 28);
            this.textNoteAvance.Name = "textNoteAvance";
            this.textNoteAvance.Size = new System.Drawing.Size(173, 20);
            this.textNoteAvance.TabIndex = 12;
            // 
            // textPce
            // 
            this.textPce.Location = new System.Drawing.Point(64, 133);
            this.textPce.Name = "textPce";
            this.textPce.Size = new System.Drawing.Size(100, 20);
            this.textPce.TabIndex = 13;
            // 
            // frmAvance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 222);
            this.Controls.Add(this.textPce);
            this.Controls.Add(this.textNoteAvance);
            this.Controls.Add(this.comboBanque);
            this.Controls.Add(this.comboNatureAvance);
            this.Controls.Add(this.textMntAvance);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateAvance);
            this.Name = "frmAvance";
            this.Text = "Avance sur Commande";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateAvance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textMntAvance;
        private System.Windows.Forms.ComboBox comboNatureAvance;
        private System.Windows.Forms.ComboBox comboBanque;
        private System.Windows.Forms.TextBox textNoteAvance;
        private System.Windows.Forms.TextBox textPce;
    }
}