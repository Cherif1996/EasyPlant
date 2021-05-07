using EasyPlant.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyPlant
{
    public partial class Support : Form
    {
        EasyPlant.DAL.Support model = new EasyPlant.DAL.Support();
        BDPlant db = new BDPlant();
        int Code = 0;
        public Support()
        {
            InitializeComponent();
        }

      

       

        private void Support_Load(object sender, EventArgs e)
        {
            Clear();
            SuportDataGrid();
        }
        void Clear()
        {
            textcode.Text = textlibelle.Text = textdimension.Text = textmatiere.Text= textMarge.Text= textmottes.Text = textpoids.Text = textPrixAchatHT.Text = textPrixAchatTTC.Text = textPrixVenteHT.Text = textPrixVenteTTC.Text = textTVA.Text = textVolAlv.Text = string.Empty; ;
            btndelete.Enabled = true;
            btnsave.Text = "Enregistrer";
            Code = 0;

        }
        void SuportDataGrid()
        {
            SupportDataGrid.AutoGenerateColumns = false;
            SupportDataGrid.DataSource = db.Supports.ToList<DAL.Support>();

        } 

        private void btnsave_Click(object sender, EventArgs e)
        {
            model.CodeSupport = Convert.ToInt32(textcode.Text.Trim());
            model.Libelle = textlibelle.Text.Trim();
            model.Matiere= textmatiere.Text.Trim();
            model.Dimension = Convert.ToInt32(textdimension.Text.Trim());
            model.Poids = Convert.ToInt32(textpoids.Text.Trim());
            model.NbrAlv = Convert.ToInt32(textmottes.Text.Trim());
            model.VolAlv = Convert.ToInt32(textVolAlv.Text.Trim());
            model.PrixAchatHT = Convert.ToDecimal(textPrixAchatHT.Text.Trim());
            model.PrixAchatTTC = Convert.ToDecimal(textPrixAchatTTC.Text.Trim());
            model.PrixVenteHT = Convert.ToDecimal(textPrixVenteHT.Text.Trim());
            model.PrixVenteTTC = Convert.ToDecimal(textPrixVenteTTC.Text.Trim());
            model.TVA = Convert.ToInt32(textTVA.Text.Trim());
            model.Marge = Convert.ToInt32(textMarge.Text.Trim());
            if (Code > 0)
                db.Entry(model).State = EntityState.Modified;
            else
            {
                db.Supports.Add(model);
            }

            db.SaveChanges();
            Clear();
            SuportDataGrid();
            MessageBox.Show("Enregistrement avec succées");

        }

        private void SupportDataGrid_DoubleClick(object sender, EventArgs e)
        {
            if (SupportDataGrid.CurrentRow.Index != -1)
            {
                Code = Convert.ToInt32(SupportDataGrid.CurrentRow.Cells["CodeSupport"].Value);
                model = db.Supports.Where(x => x.CodeSupport == Code).FirstOrDefault();
                Code  = model.CodeSupport;
                textcode.Text = SupportDataGrid.CurrentRow.Cells["CodeSupport"].Value.ToString();
                textlibelle.Text = model.Libelle;
                textmatiere.Text = model.Matiere;
                textdimension.Text = model.Dimension.ToString();
                textpoids.Text = model.Poids.ToString();
                textmottes.Text = model.NbrAlv.ToString();
                textVolAlv.Text = model.VolAlv.ToString();
                textPrixAchatHT.Text = model.PrixAchatHT.ToString();
                textPrixAchatTTC.Text = model.PrixAchatTTC.ToString();
                textPrixVenteHT.Text = model.PrixVenteHT.ToString();
                textPrixVenteTTC.Text = model.PrixVenteTTC.ToString();
                textTVA.Text = model.TVA.ToString();
                textMarge.Text = model.Marge.ToString();



            }
            btnsave.Text = "Modifier";
            btndelete.Enabled = true;

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes-vous sûr de vouloir supprimer ce support ?", "Supprimer?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                db.Supports.Remove(model);
                db.SaveChanges();
                Clear();
                SuportDataGrid();
                MessageBox.Show("Support supprimé ");
            }
        }

        private void textPrixAchatHT_TextChanged(object sender, EventArgs e)
        {
            if (textPrixAchatHT.Text.Length > 0 )
            {
                textPrixAchatTTC.Text = Convert.ToString(Convert.ToDecimal(textPrixAchatHT.Text));
                textPrixVenteHT.Text = Convert.ToString(Convert.ToDecimal(textPrixAchatHT.Text));
                textPrixVenteTTC.Text = Convert.ToString(Convert.ToDecimal(textPrixAchatHT.Text));
            }
        }

        private void textTVA_TextChanged(object sender, EventArgs e)
        {
            if (textPrixAchatHT.Text.Length > 0 && textTVA.Text.Length > 0)
            {
                decimal pourcentage = ((Convert.ToDecimal(textTVA.Text) / 100) + 1 );
                textPrixAchatTTC.Text = Convert.ToString(Convert.ToDecimal(textPrixAchatHT.Text) * pourcentage);
                textPrixVenteTTC.Text = Convert.ToString(Convert.ToDecimal(textPrixAchatHT.Text) * pourcentage);

            }

        }

        private void textMarge_TextChanged(object sender, EventArgs e)
        {
            if (textPrixAchatHT.Text.Length > 0 && textMarge.Text.Length > 0)
            {
                decimal marge = ((Convert.ToDecimal(textMarge.Text) / 100) + 1);
                textPrixVenteHT.Text = Convert.ToString(Convert.ToDecimal(textPrixAchatTTC.Text) * marge);

            }

        }
    }
}
