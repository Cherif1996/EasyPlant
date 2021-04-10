namespace EasyPlant.ParametreDeDonnees
{
    partial class frmVariete
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.code = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Codevariete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libellevariete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeprod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeespece = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbrCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbrcg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbrpg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mntmarge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixvente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelle = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.espece = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(66, 224);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // code
            // 
            this.code.AutoSize = true;
            this.code.Location = new System.Drawing.Point(19, 231);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(41, 13);
            this.code.TabIndex = 1;
            this.code.Text = "Code : ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codevariete,
            this.libellevariete,
            this.typeprod,
            this.typeespece,
            this.nbrCV,
            this.nbrcg,
            this.nbrpg,
            this.marge,
            this.mntmarge,
            this.prixvente});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(753, 168);
            this.dataGridView1.TabIndex = 2;
            // 
            // Codevariete
            // 
            this.Codevariete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Codevariete.DataPropertyName = "CodeVariete";
            this.Codevariete.HeaderText = "Code";
            this.Codevariete.Name = "Codevariete";
            // 
            // libellevariete
            // 
            this.libellevariete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.libellevariete.DataPropertyName = "LibelleVariete";
            this.libellevariete.HeaderText = "Libelle";
            this.libellevariete.Name = "libellevariete";
            // 
            // typeprod
            // 
            this.typeprod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.typeprod.DataPropertyName = "Libelle";
            this.typeprod.HeaderText = "Type Production";
            this.typeprod.Name = "typeprod";
            // 
            // typeespece
            // 
            this.typeespece.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.typeespece.DataPropertyName = "LibelleEspece";
            this.typeespece.HeaderText = "Espèces";
            this.typeespece.Name = "typeespece";
            // 
            // nbrCV
            // 
            this.nbrCV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nbrCV.DataPropertyName = "NBjoursCV";
            this.nbrCV.HeaderText = "Nbr.JoursCV";
            this.nbrCV.Name = "nbrCV";
            // 
            // nbrcg
            // 
            this.nbrcg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nbrcg.DataPropertyName = "NBjoursCG";
            this.nbrcg.HeaderText = "Nbr.JoursCG";
            this.nbrcg.Name = "nbrcg";
            // 
            // nbrpg
            // 
            this.nbrpg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nbrpg.DataPropertyName = "NBjoursPG";
            this.nbrpg.HeaderText = "Nbr.JoursPG";
            this.nbrpg.Name = "nbrpg";
            // 
            // marge
            // 
            this.marge.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.marge.DataPropertyName = "Marge";
            this.marge.HeaderText = "Marge";
            this.marge.Name = "marge";
            // 
            // mntmarge
            // 
            this.mntmarge.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mntmarge.DataPropertyName = "MontantMarge";
            this.mntmarge.HeaderText = "Montant Marge";
            this.mntmarge.Name = "mntmarge";
            // 
            // prixvente
            // 
            this.prixvente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prixvente.DataPropertyName = "PrixVente";
            this.prixvente.HeaderText = "Prix de Vente";
            this.prixvente.Name = "prixvente";
            // 
            // libelle
            // 
            this.libelle.AutoSize = true;
            this.libelle.Location = new System.Drawing.Point(182, 227);
            this.libelle.Name = "libelle";
            this.libelle.Size = new System.Drawing.Size(43, 13);
            this.libelle.TabIndex = 4;
            this.libelle.Text = "Libelle :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(232, 224);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // espece
            // 
            this.espece.AutoSize = true;
            this.espece.Location = new System.Drawing.Point(565, 223);
            this.espece.Name = "espece";
            this.espece.Size = new System.Drawing.Size(81, 13);
            this.espece.TabIndex = 6;
            this.espece.Text = "Type Espèces :";
            this.espece.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(125, 286);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(652, 219);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(98, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Type Production :";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(447, 223);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(99, 21);
            this.comboBox2.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Marge :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(122, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nbr.Jours.CV :";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(341, 286);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 13;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(561, 286);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(256, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Prix de Vente :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nbr.Jours.CG :";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(410, 343);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(531, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nbr.Jours.PG :";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(613, 343);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(470, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Montant Marge :";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(203, 340);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 201);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(753, 182);
            this.panel1.TabIndex = 22;
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Green;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Location = new System.Drawing.Point(138, 395);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(126, 43);
            this.btnsave.TabIndex = 23;
            this.btnsave.Text = "Enregistrer";
            this.btnsave.UseVisualStyleBackColor = false;
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Green;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.White;
            this.btnexit.Location = new System.Drawing.Point(302, 395);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(126, 43);
            this.btnexit.TabIndex = 24;
            this.btnexit.Text = "Anuuler";
            this.btnexit.UseVisualStyleBackColor = false;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Green;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(460, 395);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(126, 43);
            this.btndelete.TabIndex = 25;
            this.btndelete.Text = "Supprimer";
            this.btndelete.UseVisualStyleBackColor = false;
            // 
            // frmVariete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.espece);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.libelle);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.code);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Name = "frmVariete";
            this.Text = "Variete";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label code;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label libelle;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label espece;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codevariete;
        private System.Windows.Forms.DataGridViewTextBoxColumn libellevariete;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeprod;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeespece;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbrCV;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbrcg;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbrpg;
        private System.Windows.Forms.DataGridViewTextBoxColumn marge;
        private System.Windows.Forms.DataGridViewTextBoxColumn mntmarge;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixvente;
    }
}