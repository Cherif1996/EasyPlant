namespace EasyPlant.Commande
{
    partial class frmEnter
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
            this.dgListCodeLibelle = new System.Windows.Forms.DataGridView();
            this.CodeClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LibelleClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgListCodeLibelle)).BeginInit();
            this.SuspendLayout();
            // 
            // dgListCodeLibelle
            // 
            this.dgListCodeLibelle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListCodeLibelle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodeClient,
            this.LibelleClient});
            this.dgListCodeLibelle.Location = new System.Drawing.Point(1, -1);
            this.dgListCodeLibelle.Name = "dgListCodeLibelle";
            this.dgListCodeLibelle.Size = new System.Drawing.Size(240, 150);
            this.dgListCodeLibelle.TabIndex = 0;
            this.dgListCodeLibelle.DoubleClick += new System.EventHandler(this.dgListCodeLibelle_DoubleClick);
            // 
            // CodeClient
            // 
            this.CodeClient.DataPropertyName = "Code";
            this.CodeClient.HeaderText = "Code";
            this.CodeClient.Name = "CodeClient";
            // 
            // LibelleClient
            // 
            this.LibelleClient.DataPropertyName = "Libelle";
            this.LibelleClient.HeaderText = "Libelle";
            this.LibelleClient.Name = "LibelleClient";
            // 
            // frmEnter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 216);
            this.Controls.Add(this.dgListCodeLibelle);
            this.Name = "frmEnter";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEnter";
            this.Load += new System.EventHandler(this.frmEnter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgListCodeLibelle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgListCodeLibelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn LibelleClient;
    }
}