
namespace EasyPlant
{
    partial class frmParametrageProductions
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxlivraison = new System.Windows.Forms.TextBox();
            this.textBoxCapacite = new System.Windows.Forms.TextBox();
            this.textBoxSemis = new System.Windows.Forms.TextBox();
            this.textBoxSemisPorte = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxGreffage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Capacité de production";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rappel Livraison Client (nbr de jours)";
            // 
            // textBoxlivraison
            // 
            this.textBoxlivraison.Location = new System.Drawing.Point(399, 148);
            this.textBoxlivraison.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxlivraison.Name = "textBoxlivraison";
            this.textBoxlivraison.Size = new System.Drawing.Size(349, 27);
            this.textBoxlivraison.TabIndex = 2;
            // 
            // textBoxCapacite
            // 
            this.textBoxCapacite.Location = new System.Drawing.Point(399, 66);
            this.textBoxCapacite.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCapacite.Name = "textBoxCapacite";
            this.textBoxCapacite.Size = new System.Drawing.Size(349, 27);
            this.textBoxCapacite.TabIndex = 3;
            // 
            // textBoxSemis
            // 
            this.textBoxSemis.Location = new System.Drawing.Point(399, 224);
            this.textBoxSemis.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSemis.Name = "textBoxSemis";
            this.textBoxSemis.Size = new System.Drawing.Size(349, 27);
            this.textBoxSemis.TabIndex = 7;
            // 
            // textBoxSemisPorte
            // 
            this.textBoxSemisPorte.Location = new System.Drawing.Point(399, 306);
            this.textBoxSemisPorte.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSemisPorte.Name = "textBoxSemisPorte";
            this.textBoxSemisPorte.Size = new System.Drawing.Size(349, 27);
            this.textBoxSemisPorte.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 314);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(284, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rappel Semis Porte Greffe (nbr de jours)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(122, 224);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Rappel Semis Variétés (Nbr de jours)";
            // 
            // textBoxGreffage
            // 
            this.textBoxGreffage.Location = new System.Drawing.Point(399, 383);
            this.textBoxGreffage.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxGreffage.Name = "textBoxGreffage";
            this.textBoxGreffage.Size = new System.Drawing.Size(349, 27);
            this.textBoxGreffage.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(163, 391);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Rappel Greffage (nbr de jours)";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(559, 454);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(133, 48);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(378, 454);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(133, 48);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Enregistrer";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmParametrageProductions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 658);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.textBoxGreffage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxSemis);
            this.Controls.Add(this.textBoxSemisPorte);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxCapacite);
            this.Controls.Add(this.textBoxlivraison);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmParametrageProductions";
            this.Text = "frmParametrageProductions";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmParametrageProductions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxlivraison;
        private System.Windows.Forms.TextBox textBoxCapacite;
        private System.Windows.Forms.TextBox textBoxSemis;
        private System.Windows.Forms.TextBox textBoxSemisPorte;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxGreffage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}