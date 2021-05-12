
namespace EasyPlant.Dossier
{
    partial class frmGestionProfils
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.textcodeUtilisateur = new System.Windows.Forms.TextBox();
            this.textnom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textprenom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxprofil = new System.Windows.Forms.ComboBox();
            this.dataGridUtilisateur = new System.Windows.Forms.DataGridView();
            this.CodeUtilisateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Etat = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.textpassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.labelLogin = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxEtat = new System.Windows.Forms.ComboBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUtilisateur)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // textcodeUtilisateur
            // 
            this.textcodeUtilisateur.Location = new System.Drawing.Point(130, 227);
            this.textcodeUtilisateur.Name = "textcodeUtilisateur";
            this.textcodeUtilisateur.Size = new System.Drawing.Size(100, 20);
            this.textcodeUtilisateur.TabIndex = 1;
            // 
            // textnom
            // 
            this.textnom.Location = new System.Drawing.Point(130, 290);
            this.textnom.Name = "textnom";
            this.textnom.Size = new System.Drawing.Size(100, 20);
            this.textnom.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 2;
            // 
            // textprenom
            // 
            this.textprenom.Location = new System.Drawing.Point(349, 290);
            this.textprenom.Name = "textprenom";
            this.textprenom.Size = new System.Drawing.Size(100, 20);
            this.textprenom.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(499, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 6;
            // 
            // comboBoxprofil
            // 
            this.comboBoxprofil.FormattingEnabled = true;
            this.comboBoxprofil.Location = new System.Drawing.Point(598, 288);
            this.comboBoxprofil.Name = "comboBoxprofil";
            this.comboBoxprofil.Size = new System.Drawing.Size(121, 21);
            this.comboBoxprofil.TabIndex = 7;
            // 
            // dataGridUtilisateur
            // 
            this.dataGridUtilisateur.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dataGridUtilisateur.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridUtilisateur.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridUtilisateur.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridUtilisateur.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridUtilisateur.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridUtilisateur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUtilisateur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodeUtilisateur,
            this.Login,
            this.Nom,
            this.Prenom,
            this.Profil,
            this.Etat});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridUtilisateur.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridUtilisateur.EnableHeadersVisualStyles = false;
            this.dataGridUtilisateur.GridColor = System.Drawing.Color.DarkGreen;
            this.dataGridUtilisateur.Location = new System.Drawing.Point(-2, -1);
            this.dataGridUtilisateur.Name = "dataGridUtilisateur";
            this.dataGridUtilisateur.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridUtilisateur.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridUtilisateur.Size = new System.Drawing.Size(804, 201);
            this.dataGridUtilisateur.TabIndex = 8;
            this.dataGridUtilisateur.Click += new System.EventHandler(this.dataGridUtilisateur_Click);
            // 
            // CodeUtilisateur
            // 
            this.CodeUtilisateur.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CodeUtilisateur.DataPropertyName = "CodeUtilisateur";
            this.CodeUtilisateur.HeaderText = "CodeUtilisateur";
            this.CodeUtilisateur.Name = "CodeUtilisateur";
            this.CodeUtilisateur.ReadOnly = true;
            // 
            // Login
            // 
            this.Login.DataPropertyName = "Login";
            this.Login.HeaderText = "Login";
            this.Login.Name = "Login";
            this.Login.ReadOnly = true;
            // 
            // Nom
            // 
            this.Nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nom.DataPropertyName = "Nom";
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            // 
            // Prenom
            // 
            this.Prenom.DataPropertyName = "Prenom";
            this.Prenom.HeaderText = "Prénom ";
            this.Prenom.Name = "Prenom";
            this.Prenom.ReadOnly = true;
            // 
            // Profil
            // 
            this.Profil.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Profil.DataPropertyName = "LibelleProfil";
            this.Profil.HeaderText = "Profil";
            this.Profil.Name = "Profil";
            this.Profil.ReadOnly = true;
            // 
            // Etat
            // 
            this.Etat.DataPropertyName = "EtatCheckBox";
            this.Etat.HeaderText = "Etat";
            this.Etat.Name = "Etat";
            this.Etat.ReadOnly = true;
            // 
            // textpassword
            // 
            this.textpassword.Location = new System.Drawing.Point(619, 226);
            this.textpassword.Name = "textpassword";
            this.textpassword.Size = new System.Drawing.Size(100, 20);
            this.textpassword.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(464, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 9;
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.SeaGreen;
            this.btnsave.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btnsave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsave.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.SystemColors.Window;
            this.btnsave.Location = new System.Drawing.Point(137, 373);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(114, 39);
            this.btnsave.TabIndex = 12;
            this.btnsave.Text = "Enregistrer ";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.SeaGreen;
            this.btncancel.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btncancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncancel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.ForeColor = System.Drawing.SystemColors.Window;
            this.btncancel.Location = new System.Drawing.Point(328, 373);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(114, 39);
            this.btncancel.TabIndex = 13;
            this.btncancel.Text = "Annuler";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.SeaGreen;
            this.btndelete.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btndelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndelete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.SystemColors.Window;
            this.btndelete.Location = new System.Drawing.Point(507, 373);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(114, 39);
            this.btndelete.TabIndex = 14;
            this.btndelete.Text = "Supprimer";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(271, 250);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(0, 13);
            this.labelLogin.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(64, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 19);
            this.label6.TabIndex = 17;
            this.label6.Text = "Code";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(287, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 19);
            this.label7.TabIndex = 18;
            this.label7.Text = "Login";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(494, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 19);
            this.label8.TabIndex = 19;
            this.label8.Text = "Mot de pass";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(64, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 19);
            this.label9.TabIndex = 20;
            this.label9.Text = "Nom";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(274, 291);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 19);
            this.label10.TabIndex = 21;
            this.label10.Text = "Prénom";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(541, 288);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 19);
            this.label11.TabIndex = 22;
            this.label11.Text = "Profil";
            // 
            // comboBoxEtat
            // 
            this.comboBoxEtat.FormattingEnabled = true;
            this.comboBoxEtat.Items.AddRange(new object[] {
            "Active",
            "Desactive"});
            this.comboBoxEtat.Location = new System.Drawing.Point(598, 336);
            this.comboBoxEtat.Name = "comboBoxEtat";
            this.comboBoxEtat.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEtat.TabIndex = 23;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(349, 227);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(100, 20);
            this.txtLogin.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(540, 338);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 19);
            this.label12.TabIndex = 24;
            this.label12.Text = "Etat ";
            // 
            // frmGestionProfils
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboBoxEtat);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.textpassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridUtilisateur);
            this.Controls.Add(this.comboBoxprofil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textprenom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textnom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textcodeUtilisateur);
            this.Controls.Add(this.label1);
            this.Name = "frmGestionProfils";
            this.Text = "Gestion de Profils";
            this.Load += new System.EventHandler(this.frmGestionProfils_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUtilisateur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textcodeUtilisateur;
        private System.Windows.Forms.TextBox textnom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textprenom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxprofil;
        private System.Windows.Forms.DataGridView dataGridUtilisateur;
      
        private System.Windows.Forms.TextBox textpassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeUtilisateur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profil;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Etat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxEtat;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label12;
    }
}