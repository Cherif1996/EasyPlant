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

namespace EasyPlant.DAL
{
    public partial class PointDeVente : Form
    {
        DAL.PointVente model = new DAL.PointVente();
        BDPlant db = new BDPlant();
        int Code = 0;
        public PointDeVente()
        {
            InitializeComponent();
        }

        private void PointDeVente_Load(object sender, EventArgs e)
        {
            Clear();
            VenteDataGrid();
        }
        void Clear()
        {
            textcode.Text = textlibelle.Text = textadresse.Text=textville.Text = string.Empty; ;
            btndelete.Enabled = true;
            btnsave.Text = "Enregistrer";
            Code = 0;

        }
        void VenteDataGrid()
        {
            PointVenteDataGrid.AutoGenerateColumns = false;
            PointVenteDataGrid.DataSource = db.PointVentes.ToList<DAL.PointVente>();

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            model.CodePointVente = Convert.ToInt32(textcode.Text.Trim());

            model.Libelle = textlibelle.Text.Trim();
            model.Adresse = textadresse.Text.Trim();
            model.Ville = textlibelle.Text.Trim();

            if (Code > 0)
                db.Entry(model).State = EntityState.Modified;
            else
            {
                db.PointVentes.Add(model);
            }

            db.SaveChanges();
            Clear();
            VenteDataGrid();
            MessageBox.Show("Enregistrement avec succées");
        }

        private void PointVenteDataGrid_DoubleClick(object sender, EventArgs e)
        {
            if (PointVenteDataGrid.CurrentRow.Index != -1)
            {
                Code = Convert.ToInt32(PointVenteDataGrid.CurrentRow.Cells["CodePointVente"].Value);
                model = db.PointVentes.Where(x => x.CodePointVente == Code).FirstOrDefault();
                Code = model.CodePointVente;
                textcode.Text = PointVenteDataGrid.CurrentRow.Cells["CodePointVente"].Value.ToString();
                textlibelle.Text = model.Libelle;
                textadresse.Text = model.Adresse;
                textville.Text = model.Ville;

            }
            btnsave.Text = "Modifier";
            btndelete.Enabled = true;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes-vous sûr de vouloir supprimer ce point de vente ?", "Supprimer?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                db.PointVentes.Remove(model);
                db.SaveChanges();
                Clear();
                VenteDataGrid();
                MessageBox.Show("Point de vente supprimé ");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
