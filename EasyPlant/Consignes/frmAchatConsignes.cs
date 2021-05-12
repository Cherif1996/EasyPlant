using EasyPlant.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyPlant
{
    public partial class frmAchatConsignes : Form

    {
        FactureConsigne model = new FactureConsigne();
        List<FactureConsigne> listeFactureConsignes = new List<FactureConsigne>();
        BDPlant db = new BDPlant();

        int Code = 0;
      
        public frmAchatConsignes()
        {
            InitializeComponent();
        }

        private void frmAchatConsignes_Load(object sender, EventArgs e)
        {
            List<DAL.PointVente> pointVentes = db.PointVentes.ToList();
            comboPointVente.DataSource = pointVentes;
            comboPointVente.DisplayMember = "Libelle";
            comboPointVente.ValueMember = "CodePointVente";

        
            List<DAL.Fourniseur> Fourniseurs = db.Fourniseurs.ToList();
            comboBoxFourniseur.DataSource = Fourniseurs;
            comboBoxFourniseur.DisplayMember = "CodeFourniseur";
            comboBoxFourniseur.ValueMember = "NomFourniseur";

            List<DAL.Support> Supports = db.Supports.ToList();
            comboBoxDesignation.DataSource = Supports;
            comboBoxDesignation.DisplayMember = "Libelle" ;
            comboBoxDesignation.ValueMember = "CodeSupport";
           
            Clear();
          //  ConsigneDataGrid();
           

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int nbreFacture=0;
            nbreFacture = db.FactureConsignes.ToList().Where(x => x.CodeFacture == Convert.ToInt32(textNumero.Text.Trim())).Count();
            if (nbreFacture > 0)
                MessageBox.Show("Facture existe déjà");
            else
            {
                foreach(FactureConsigne item in listeFactureConsignes)
                {
                    db.FactureConsignes.Add(item);
                }
                
            }
            db.SaveChanges();
            Clear();
            MessageBox.Show("Enregistrement avec succées");

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes-vous sûr de vouloir supprimer cet consigne ?", "Supprimer?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                db.FactureConsignes.Remove(model);
                db.SaveChanges();
                Clear();
                ConsigneDataGrid();
                MessageBox.Show("client supprimé avec succées");
            }
        }
        void Clear()
        {
            textNumero.Text = textMntRemise.Text = textHT.Text =
            textNetHt.Text = textNetTTc.Text = textPuHt.Text = textPuTtc.Text = textQte.Text = textRem.Text =
            textRemiseTot.Text = comboBoxDesignation.Text = comboBoxFourniseur.Text =
            comboPointVente.Text = texttimbe.Text = textToalTTc.Text = textTotHt.Text = textTVA.Text = textTVATot.Text = string.Empty;
            btnDelete.Enabled = true;
            btnSave.Text = "Enregistrer";
            Code = 0;

        }
        void ConsigneDataGrid()
        {
          
            model.CodeFacture = Convert.ToInt32(textNumero.Text.Trim());
            model.DateFacture = DateTime.Parse(dateTimePicker1.Text);
            model.PUht = Convert.ToDecimal(textPuHt.Text);
            model.PuTTC = Convert.ToDecimal(textPuTtc.Text);
            model.Remise = Convert.ToDecimal(textRem.Text);
            model.FodecArticle = Convert.ToDecimal(textMntRemise.Text);
            model.TVA = Convert.ToDecimal(textTVA.Text);
            model.TotHt = String.IsNullOrEmpty(textTotHt.Text.ToString()) ? 0 : Convert.ToDecimal(textTotHt.Text);
            model.TTC = String.IsNullOrEmpty(textToalTTc.Text.ToString()) ? 0 : Convert.ToDecimal(textToalTTc.Text);
            model.Timbre = String.IsNullOrEmpty(texttimbe.Text.ToString()) ? 0 : Convert.ToDecimal(texttimbe.Text);
            model.Ht = String.IsNullOrEmpty(textHT.Text.ToString()) ? 0 : Convert.ToDecimal(textHT.Text);
            model.TotRemise = String.IsNullOrEmpty(textRemiseTot.Text.ToString()) ? 0 : Convert.ToDecimal(textRemiseTot.Text);
            model.MntRemise = model.TTC - model.TTC * model.Remise / 100;
            model.NetHt = String.IsNullOrEmpty(textNetHt.Text.ToString()) ? 0 : Convert.ToDecimal(textNetHt.Text);
            model.TotTva = String.IsNullOrEmpty(textTVATot.Text.ToString()) ? 0 : (Convert.ToDecimal(textTVA.Text) * Convert.ToDecimal(textPuHt.Text)) / 100; 
            model.NetTTc = String.IsNullOrEmpty(textNetTTc.Text.ToString()) ? 0 : Convert.ToDecimal(textNetTTc.Text);
            model.Quantite = String.IsNullOrEmpty(textQte.Text.ToString()) ? 0 : Convert.ToInt32(textQte.Text.Trim());
            model.Fourniseur = (DAL.Fourniseur)comboBoxFourniseur.SelectedItem;
            model.PointVente = (DAL.PointVente)comboPointVente.SelectedItem;
            model.Support = (DAL.Support)comboBoxDesignation.SelectedItem;
            listeFactureConsignes.Add(model);
            if (listeFactureConsignes.Count > 0)
            {
                dataGridConsigne.AutoGenerateColumns = false;
                dataGridConsigne.DataSource = listeFactureConsignes.ToList();
            }

        }

        private void dataGridConsigne_Click(object sender, EventArgs e)
        {
            if (dataGridConsigne.CurrentRow.Index != -1)
            {
                Code = Convert.ToInt32(dataGridConsigne.CurrentRow.Cells["CodeFacture"].Value);
                model = db.FactureConsignes.Where(x => x.CodeFacture == Code).FirstOrDefault();
  
                textQte.Text = dataGridConsigne.CurrentRow.Cells["Qte"].Value.ToString();
                textMntRemise.Text = dataGridConsigne.CurrentRow.Cells["MntRemise"].Value.ToString();
                textPuHt.Text = model.PUht.ToString();
                textPuTtc.Text = model.PuTTC.ToString();
                textTVA.Text = model.TVA.ToString();
                textRem.Text = model.Remise.ToString();
                textTotHt.Text = model.TotHt.ToString();
                textToalTTc.Text = model.TTC.ToString();
                foreach (DAL.Support d in comboBoxDesignation.Items)
                {
                    if (d.Libelle == dataGridConsigne.CurrentRow.Cells["Designation"].Value.ToString())
                    {
                        comboBoxDesignation.SelectedItem = d;
                        break;
                    }
                }

            }
            btnSave.Text = "Modifier";
            btnDelete.Enabled = true;
        }

        private void btnTotale_Click(object sender, EventArgs e)
        {
            int totalht = dataGridConsigne.Rows.Cast<DataGridViewRow>()
                .Sum(t => Convert.ToInt32(t.Cells["PUht"].Value));
            textHT.Text = totalht.ToString();

            int totalRemise = dataGridConsigne.Rows.Cast<DataGridViewRow>()
               .Sum(t => Convert.ToInt32(t.Cells["Remise"].Value));
            textRemiseTot.Text = totalRemise.ToString();


            int totalNetTTc = dataGridConsigne.Rows.Cast<DataGridViewRow>()
               .Sum(t => Convert.ToInt32(t.Cells["TotalTTC"].Value));
            textTVATot.Text = totalNetTTc.ToString();


            int totalTVA = dataGridConsigne.Rows.Cast<DataGridViewRow>()
               .Sum(t => Convert.ToInt32(t.Cells["TVA"].Value));
            textTVATot.Text = totalTVA.ToString();


            int NetHt = dataGridConsigne.Rows.Cast<DataGridViewRow>()
               .Sum(t => Convert.ToInt32(t.Cells["TotHT"].Value));
            textNetHt.Text = NetHt.ToString();

            int nettc = (totalTVA + totalht) - totalRemise;
            textNetTTc.Text = nettc.ToString();

        }

        private void textQte_TextChanged(object sender, EventArgs e)
        {
            if (textQte.Text.Length > 0 && textPuHt.Text.Length > 0)
            {
                textTotHt.Text = Convert.ToString(Convert.ToInt32(textQte.Text) * Convert.ToDecimal(textPuHt.Text));              
            }
        }

        private void textPuHt_TextChanged(object sender, EventArgs e)
        {
            if (textQte.Text.Length > 0 && textPuHt.Text.Length > 0 )
            {
                textTotHt.Text = Convert.ToString(Convert.ToInt32(textQte.Text) * Convert.ToDecimal(textPuHt.Text));
            
            }

        }

        private void textTotHt_TextChanged(object sender, EventArgs e)
        {
            if (textQte.Text.Length > 0 && textPuHt.Text.Length > 0 && textMntRemise.Text.Length > 0 && textRem.Text.Length > 0 && textPuTtc.Text.Length > 0 && textTVA.Text.Length > 0)
            {
                textTotHt.Text = Convert.ToString(Convert.ToInt32(textQte.Text) * Convert.ToDecimal(textPuHt.Text));
              
            }
        }

        private void textTVA_TextChanged_1(object sender, EventArgs e)
        {
            if (textPuHt.Text.Length > 0  && textTVA.Text.Length > 0)
            {
    
                decimal TVA = (Convert.ToDecimal(textTVA.Text) * Convert.ToDecimal(textPuHt.Text)) / 100;
                textPuTtc.Text = Convert.ToString(Convert.ToDecimal(textPuHt.Text)) + TVA;
               
            }
        }

        private void textRem_TextChanged(object sender, EventArgs e)
        {
            if (  textRem.Text.Length > 0 && textTVA.Text.Length > 0 && textTotHt.Text.Length > 0 && textPuTtc.Text.Length > 0 && textMntRemise.Text.Length > 0)
            {
             
                decimal TVA = (Convert.ToDecimal(textTVA.Text) * Convert.ToDecimal(textPuHt.Text)) / 100;
                textPuTtc.Text = Convert.ToString(Convert.ToDecimal(textPuHt.Text)) + TVA;
                decimal totale = Convert.ToDecimal(textTotHt.Text) + TVA;
                decimal PourcentageRemise = (Convert.ToDecimal(textRem.Text) * totale) / 100;
                textToalTTc.Text = Convert.ToString(totale - PourcentageRemise - Convert.ToDecimal(textMntRemise.Text));

            }
        }

        private void textMntRemise_TextChanged(object sender, EventArgs e)
        {
            if (textRem.Text.Length > 0 && textTVA.Text.Length > 0 && textTotHt.Text.Length > 0 && textPuTtc.Text.Length > 0 && textMntRemise.Text.Length > 0)
            {

                decimal TVA = (Convert.ToDecimal(textTVA.Text) * Convert.ToDecimal(textPuHt.Text)) / 100;
                textPuTtc.Text = Convert.ToString(Convert.ToDecimal(textPuHt.Text)) + TVA;
                decimal totale = Convert.ToDecimal(textTotHt.Text) + TVA;
                decimal PourcentageRemise = (Convert.ToDecimal(textRem.Text) * totale) / 100;
                textToalTTc.Text = Convert.ToString(totale - PourcentageRemise - Convert.ToDecimal(textMntRemise.Text));

            }
        }

        private void textMntRemise_MouseLeave(object sender, EventArgs e)
        {
            if (textQte.Text.Length > 0 && textPuHt.Text.Length > 0 && textMntRemise.Text.Length > 0 && textRem.Text.Length > 0 && textPuTtc.Text.Length > 0 && textTVA.Text.Length > 0)
            {
                textTotHt.Text = Convert.ToString(Convert.ToInt32(textQte.Text) * Convert.ToDecimal(textPuHt.Text));
                decimal TVA = (Convert.ToDecimal(textTVA.Text) * Convert.ToDecimal(textPuHt.Text)) / 100;
                textPuTtc.Text = Convert.ToString(Convert.ToDecimal(textPuHt.Text)) + TVA;
                decimal totale = Convert.ToDecimal(textTotHt.Text) + TVA;
                decimal PourcentageRemise = (Convert.ToDecimal(textRem.Text) * totale) / 100;
                textToalTTc.Text = Convert.ToString(totale - PourcentageRemise - Convert.ToDecimal(textMntRemise.Text));
                ConsigneDataGrid();
                // Clear();
            }
        }

        private void btnnNOUVEAU_Click(object sender, EventArgs e)
        {
            Clear();

        }

    }
}