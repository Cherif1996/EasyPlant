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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

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
            model.PrixAchatHT = Convert.ToInt32(textPrixAchatHT.Text.Trim());
            model.PrixAchatTTC = Convert.ToInt32(textPrixAchatTTC.Text.Trim());
            model.PrixVenteHT = Convert.ToInt32(textPrixVenteHT.Text.Trim());
            model.PrixVenteTTC = Convert.ToInt32(textPrixVenteTTC.Text.Trim());
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
                textlibelle.Text = model.Libelle;
                textmatiere.Text = model.Matiere;
               // Convert.ToInt32(textdimension.Text) = model.Dimension;

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
    }
}
