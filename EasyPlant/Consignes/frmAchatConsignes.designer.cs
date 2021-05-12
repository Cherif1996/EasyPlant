
namespace EasyPlant
{
    partial class frmAchatConsignes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.textNumero = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboPointVente = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textQte = new System.Windows.Forms.TextBox();
            this.textPuTtc = new System.Windows.Forms.TextBox();
            this.textMntRemise = new System.Windows.Forms.TextBox();
            this.textTotHt = new System.Windows.Forms.TextBox();
            this.textToalTTc = new System.Windows.Forms.TextBox();
            this.textTVA = new System.Windows.Forms.TextBox();
            this.textRem = new System.Windows.Forms.TextBox();
            this.textPuHt = new System.Windows.Forms.TextBox();
            this.dataGridConsigne = new System.Windows.Forms.DataGridView();
            this.CodeFacture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PUht = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PUTTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remise = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MntRemise = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotHT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalTTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textNetTTc = new System.Windows.Forms.TextBox();
            this.textNetHt = new System.Windows.Forms.TextBox();
            this.textHT = new System.Windows.Forms.TextBox();
            this.textRemiseTot = new System.Windows.Forms.TextBox();
            this.texttimbe = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnTotale = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.textTVATot = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.comboBoxFourniseur = new System.Windows.Forms.ComboBox();
            this.comboBoxDesignation = new System.Windows.Forms.ComboBox();
            this.supportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supportBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnnNOUVEAU = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConsigne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supportBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numéro Facture";
            // 
            // textNumero
            // 
            this.textNumero.Location = new System.Drawing.Point(97, 24);
            this.textNumero.Name = "textNumero";
            this.textNumero.Size = new System.Drawing.Size(118, 20);
            this.textNumero.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(272, 24);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(115, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Forniseur";
            // 
            // comboPointVente
            // 
            this.comboPointVente.FormattingEnabled = true;
            this.comboPointVente.Location = new System.Drawing.Point(597, 27);
            this.comboPointVente.Name = "comboPointVente";
            this.comboPointVente.Size = new System.Drawing.Size(178, 21);
            this.comboPointVente.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(515, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Point de vente";
            // 
            // textQte
            // 
            this.textQte.Location = new System.Drawing.Point(44, 115);
            this.textQte.Name = "textQte";
            this.textQte.Size = new System.Drawing.Size(54, 20);
            this.textQte.TabIndex = 11;
            this.textQte.Text = "0";
            this.textQte.TextChanged += new System.EventHandler(this.textQte_TextChanged);
            // 
            // textPuTtc
            // 
            this.textPuTtc.Location = new System.Drawing.Point(597, 115);
            this.textPuTtc.Name = "textPuTtc";
            this.textPuTtc.Size = new System.Drawing.Size(54, 20);
            this.textPuTtc.TabIndex = 12;
            this.textPuTtc.Text = "0";
            // 
            // textMntRemise
            // 
            this.textMntRemise.Location = new System.Drawing.Point(490, 117);
            this.textMntRemise.Name = "textMntRemise";
            this.textMntRemise.Size = new System.Drawing.Size(54, 20);
            this.textMntRemise.TabIndex = 13;
            this.textMntRemise.Text = "0";
            this.textMntRemise.TextChanged += new System.EventHandler(this.textMntRemise_TextChanged);
            this.textMntRemise.MouseLeave += new System.EventHandler(this.textMntRemise_MouseLeave);
            // 
            // textTotHt
            // 
            this.textTotHt.Location = new System.Drawing.Point(709, 115);
            this.textTotHt.Name = "textTotHt";
            this.textTotHt.Size = new System.Drawing.Size(54, 20);
            this.textTotHt.TabIndex = 14;
            this.textTotHt.Text = "0";
            this.textTotHt.TextChanged += new System.EventHandler(this.textTotHt_TextChanged);
            // 
            // textToalTTc
            // 
            this.textToalTTc.Location = new System.Drawing.Point(890, 115);
            this.textToalTTc.Name = "textToalTTc";
            this.textToalTTc.Size = new System.Drawing.Size(82, 20);
            this.textToalTTc.TabIndex = 21;
            this.textToalTTc.Text = "0";
            // 
            // textTVA
            // 
            this.textTVA.Location = new System.Drawing.Point(254, 114);
            this.textTVA.Name = "textTVA";
            this.textTVA.Size = new System.Drawing.Size(54, 20);
            this.textTVA.TabIndex = 19;
            this.textTVA.Text = "0";
            this.textTVA.TextChanged += new System.EventHandler(this.textTVA_TextChanged_1);
            // 
            // textRem
            // 
            this.textRem.Location = new System.Drawing.Point(358, 115);
            this.textRem.Name = "textRem";
            this.textRem.Size = new System.Drawing.Size(54, 20);
            this.textRem.TabIndex = 18;
            this.textRem.Text = "0";
            this.textRem.TextChanged += new System.EventHandler(this.textRem_TextChanged);
            // 
            // textPuHt
            // 
            this.textPuHt.Location = new System.Drawing.Point(145, 115);
            this.textPuHt.Name = "textPuHt";
            this.textPuHt.Size = new System.Drawing.Size(54, 20);
            this.textPuHt.TabIndex = 17;
            this.textPuHt.Text = "0";
            this.textPuHt.TextChanged += new System.EventHandler(this.textPuHt_TextChanged);
            // 
            // dataGridConsigne
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dataGridConsigne.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridConsigne.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridConsigne.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridConsigne.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridConsigne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridConsigne.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodeFacture,
            this.Designation,
            this.PUht,
            this.PUTTC,
            this.TVA,
            this.Qte,
            this.Remise,
            this.MntRemise,
            this.TotHT,
            this.TotalTTC});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridConsigne.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridConsigne.EnableHeadersVisualStyles = false;
            this.dataGridConsigne.GridColor = System.Drawing.Color.DarkGreen;
            this.dataGridConsigne.Location = new System.Drawing.Point(15, 161);
            this.dataGridConsigne.Name = "dataGridConsigne";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridConsigne.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridConsigne.Size = new System.Drawing.Size(957, 110);
            this.dataGridConsigne.TabIndex = 22;
            this.dataGridConsigne.Click += new System.EventHandler(this.dataGridConsigne_Click);
            // 
            // CodeFacture
            // 
            this.CodeFacture.DataPropertyName = "CodeFacture";
            this.CodeFacture.HeaderText = "Code Facture";
            this.CodeFacture.Name = "CodeFacture";
            // 
            // Designation
            // 
            this.Designation.DataPropertyName = "LibelleSupport";
            this.Designation.HeaderText = "Désignation";
            this.Designation.Name = "Designation";
            // 
            // PUht
            // 
            this.PUht.DataPropertyName = "PUht";
            this.PUht.HeaderText = "PU HT";
            this.PUht.Name = "PUht";
            // 
            // PUTTC
            // 
            this.PUTTC.DataPropertyName = "PuTTC";
            this.PUTTC.HeaderText = "PU TTC";
            this.PUTTC.Name = "PUTTC";
            // 
            // TVA
            // 
            this.TVA.DataPropertyName = "TVA";
            this.TVA.HeaderText = "TVA";
            this.TVA.Name = "TVA";
            // 
            // Qte
            // 
            this.Qte.DataPropertyName = "Quantite";
            this.Qte.HeaderText = "Qté";
            this.Qte.Name = "Qte";
            // 
            // Remise
            // 
            this.Remise.DataPropertyName = "Remise";
            this.Remise.HeaderText = "Remise";
            this.Remise.Name = "Remise";
            // 
            // MntRemise
            // 
            this.MntRemise.DataPropertyName = "MntRemise";
            this.MntRemise.HeaderText = "Mnt Remise";
            this.MntRemise.Name = "MntRemise";
            // 
            // TotHT
            // 
            this.TotHT.DataPropertyName = "TotHt";
            this.TotHT.HeaderText = "TotHT";
            this.TotHT.Name = "TotHT";
            // 
            // TotalTTC
            // 
            this.TotalTTC.DataPropertyName = "TTC";
            this.TotalTTC.HeaderText = "Total TTC";
            this.TotalTTC.Name = "TotalTTC";
            // 
            // textNetTTc
            // 
            this.textNetTTc.Location = new System.Drawing.Point(890, 317);
            this.textNetTTc.Name = "textNetTTc";
            this.textNetTTc.Size = new System.Drawing.Size(82, 20);
            this.textNetTTc.TabIndex = 34;
            this.textNetTTc.Text = "0";
            // 
            // textNetHt
            // 
            this.textNetHt.Location = new System.Drawing.Point(425, 317);
            this.textNetHt.Name = "textNetHt";
            this.textNetHt.Size = new System.Drawing.Size(54, 20);
            this.textNetHt.TabIndex = 30;
            this.textNetHt.Text = "0";
            // 
            // textHT
            // 
            this.textHT.Location = new System.Drawing.Point(170, 317);
            this.textHT.Name = "textHT";
            this.textHT.Size = new System.Drawing.Size(54, 20);
            this.textHT.TabIndex = 29;
            this.textHT.Text = "0";
            // 
            // textRemiseTot
            // 
            this.textRemiseTot.Location = new System.Drawing.Point(307, 317);
            this.textRemiseTot.Name = "textRemiseTot";
            this.textRemiseTot.Size = new System.Drawing.Size(54, 20);
            this.textRemiseTot.TabIndex = 24;
            this.textRemiseTot.Text = "0";
            // 
            // texttimbe
            // 
            this.texttimbe.Location = new System.Drawing.Point(59, 317);
            this.texttimbe.Name = "texttimbe";
            this.texttimbe.Size = new System.Drawing.Size(54, 20);
            this.texttimbe.TabIndex = 23;
            this.texttimbe.Text = "0.600";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSave.Location = new System.Drawing.Point(118, 374);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(123, 43);
            this.btnSave.TabIndex = 35;
            this.btnSave.Text = "Enregistrer";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnTotale
            // 
            this.btnTotale.BackColor = System.Drawing.Color.SeaGreen;
            this.btnTotale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTotale.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotale.ForeColor = System.Drawing.SystemColors.Window;
            this.btnTotale.Location = new System.Drawing.Point(298, 374);
            this.btnTotale.Name = "btnTotale";
            this.btnTotale.Size = new System.Drawing.Size(123, 43);
            this.btnTotale.TabIndex = 36;
            this.btnTotale.Text = "Calculer Total";
            this.btnTotale.UseVisualStyleBackColor = false;
            this.btnTotale.Click += new System.EventHandler(this.btnTotale_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.SeaGreen;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDelete.Location = new System.Drawing.Point(747, 374);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(123, 43);
            this.btnDelete.TabIndex = 38;
            this.btnDelete.Text = "Supprimer";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // textTVATot
            // 
            this.textTVATot.Location = new System.Drawing.Point(676, 317);
            this.textTVATot.Name = "textTVATot";
            this.textTVATot.Size = new System.Drawing.Size(54, 20);
            this.textTVATot.TabIndex = 26;
            this.textTVATot.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(515, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Désignation";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "Qté";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(110, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "Pu ht";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(560, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 43;
            this.label10.Text = "Pu ttc";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(317, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 44;
            this.label11.Text = "Rem%";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(427, 119);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 45;
            this.label12.Text = "Mnt Remise";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(223, 119);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 13);
            this.label13.TabIndex = 46;
            this.label13.Text = "TVA";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(665, 119);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 47;
            this.label14.Text = "Tot HT";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(823, 119);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 13);
            this.label16.TabIndex = 49;
            this.label16.Text = "Totale TTC";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(14, 320);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 13);
            this.label15.TabIndex = 50;
            this.label15.Text = "Timbre";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(142, 321);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(22, 13);
            this.label17.TabIndex = 51;
            this.label17.Text = "HT";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(260, 320);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(42, 13);
            this.label18.TabIndex = 52;
            this.label18.Text = "Remise";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(378, 321);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(42, 13);
            this.label19.TabIndex = 53;
            this.label19.Text = "Net HT";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(643, 322);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(28, 13);
            this.label21.TabIndex = 55;
            this.label21.Text = "TVA";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(839, 320);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(48, 13);
            this.label22.TabIndex = 56;
            this.label22.Text = "Net TTC";
            // 
            // comboBoxFourniseur
            // 
            this.comboBoxFourniseur.FormattingEnabled = true;
            this.comboBoxFourniseur.Location = new System.Drawing.Point(97, 59);
            this.comboBoxFourniseur.Name = "comboBoxFourniseur";
            this.comboBoxFourniseur.Size = new System.Drawing.Size(290, 21);
            this.comboBoxFourniseur.TabIndex = 57;
            // 
            // comboBoxDesignation
            // 
            this.comboBoxDesignation.FormattingEnabled = true;
            this.comboBoxDesignation.Location = new System.Drawing.Point(597, 61);
            this.comboBoxDesignation.Name = "comboBoxDesignation";
            this.comboBoxDesignation.Size = new System.Drawing.Size(358, 21);
            this.comboBoxDesignation.TabIndex = 58;
            // 
            // supportBindingSource
            // 
            this.supportBindingSource.DataMember = "Support";
            // 
            // supportBindingSource1
            // 
            this.supportBindingSource1.DataMember = "Support";
            // 
            // btnnNOUVEAU
            // 
            this.btnnNOUVEAU.BackColor = System.Drawing.Color.SeaGreen;
            this.btnnNOUVEAU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnNOUVEAU.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnNOUVEAU.ForeColor = System.Drawing.SystemColors.Window;
            this.btnnNOUVEAU.Location = new System.Drawing.Point(575, 374);
            this.btnnNOUVEAU.Name = "btnnNOUVEAU";
            this.btnnNOUVEAU.Size = new System.Drawing.Size(123, 43);
            this.btnnNOUVEAU.TabIndex = 59;
            this.btnnNOUVEAU.Text = "Nouveau ";
            this.btnnNOUVEAU.UseVisualStyleBackColor = false;
            this.btnnNOUVEAU.Click += new System.EventHandler(this.btnnNOUVEAU_Click);
            // 
            // frmAchatConsignes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 450);
            this.Controls.Add(this.btnnNOUVEAU);
            this.Controls.Add(this.comboBoxDesignation);
            this.Controls.Add(this.comboBoxFourniseur);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnTotale);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textNetTTc);
            this.Controls.Add(this.textNetHt);
            this.Controls.Add(this.textHT);
            this.Controls.Add(this.textTVATot);
            this.Controls.Add(this.textRemiseTot);
            this.Controls.Add(this.texttimbe);
            this.Controls.Add(this.dataGridConsigne);
            this.Controls.Add(this.textToalTTc);
            this.Controls.Add(this.textTVA);
            this.Controls.Add(this.textRem);
            this.Controls.Add(this.textPuHt);
            this.Controls.Add(this.textTotHt);
            this.Controls.Add(this.textMntRemise);
            this.Controls.Add(this.textPuTtc);
            this.Controls.Add(this.textQte);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboPointVente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textNumero);
            this.Controls.Add(this.label1);
            this.Name = "frmAchatConsignes";
            this.Text = "Achat Consignes";
            this.Load += new System.EventHandler(this.frmAchatConsignes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConsigne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supportBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNumero;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboPointVente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textQte;
        private System.Windows.Forms.TextBox textPuTtc;
        private System.Windows.Forms.TextBox textMntRemise;
        private System.Windows.Forms.TextBox textTotHt;
        private System.Windows.Forms.TextBox textToalTTc;
        private System.Windows.Forms.TextBox textTVA;
        private System.Windows.Forms.TextBox textRem;
        private System.Windows.Forms.TextBox textPuHt;
        private System.Windows.Forms.DataGridView dataGridConsigne;
        private System.Windows.Forms.TextBox textNetTTc;
        private System.Windows.Forms.TextBox textNetHt;
        private System.Windows.Forms.TextBox textHT;
        private System.Windows.Forms.TextBox textRemiseTot;
        private System.Windows.Forms.TextBox texttimbe;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnTotale;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox textTVATot;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox comboBoxFourniseur;
        private System.Windows.Forms.ComboBox comboBoxDesignation;
       
        private System.Windows.Forms.BindingSource supportBindingSource;
        
       
        private System.Windows.Forms.BindingSource supportBindingSource1;
       
        private System.Windows.Forms.Button btnnNOUVEAU;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeFacture;
        private System.Windows.Forms.DataGridViewTextBoxColumn Designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn PUht;
        private System.Windows.Forms.DataGridViewTextBoxColumn PUTTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remise;
        private System.Windows.Forms.DataGridViewTextBoxColumn MntRemise;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotHT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalTTC;
    }
}