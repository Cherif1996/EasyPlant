using EasyPlant.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyPlant.ParametreDeDonnees
{
    public partial class frmVariete : Form
    {
        DAL.Variete model = new DAL.Variete();
        BDPlant db = new BDPlant();
        int Code = 0;
        public frmVariete()
        {
            InitializeComponent();
        }

        private void frmVariete_Load(object sender, EventArgs e)
        {
            Clear();
            varieteDataGrid();

            List<Espece> especes = db.Especes.ToList();
            comboespece.DataSource = especes;
            comboespece.DisplayMember = "LibelleEspece";
            comboespece.ValueMember = "CodeEspece";

            List<TypeProduction> typeprod = db.TypeProductions.ToList();
            comboprod.DataSource = typeprod;
            comboprod.DisplayMember = "Libelle";
            comboprod.ValueMember = "CodeTypeProd";
        }
        void Clear()
        {
            textcode.Text = textlibelle.Text = comboespece.Text = comboprod.Text =
            textmarge.Text = textmntmarge.Text = textprixvente.Text = textCG.Text =
            textCV.Text= textPG.Text = string.Empty; ;
            btndelete.Enabled = true;
            btnsave.Text = "Enregistrer";
            Code = 0;

        }
        void varieteDataGrid()
        {

            dataGridvariete.AutoGenerateColumns = false;
            dataGridvariete.DataSource = db.Varietes.ToList<DAL.Variete>();


        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            model.CodeVariete = Convert.ToInt32(textcode.Text.Trim());
            model.LibelleVariete = textlibelle.Text.Trim();
            model.Espece = (Espece)comboespece.SelectedItem;
            model.TypeProduction = (TypeProduction)comboprod.SelectedItem;
            model.NBjoursCG = Convert.ToInt32(textCV.Text.Trim());
            model.NBjoursCG = Convert.ToInt32(textCG.Text.Trim());
            model.NBjoursPG = Convert.ToInt32(textPG.Text.Trim());
            model.Marge = decimal.Parse(textmarge.Text, CultureInfo.InvariantCulture);
            model.MontantMarge = decimal.Parse(textmntmarge.Text, CultureInfo.InvariantCulture);
            model.PrixVente = decimal.Parse(textprixvente.Text, CultureInfo.InvariantCulture);
            if (Code > 0)
                db.Entry(model).State = EntityState.Modified;
            else
            {
                db.Varietes.Add(model);
            }
            db.SaveChanges();
            Clear();
            varieteDataGrid();
            MessageBox.Show("Enregistrement avec succées");
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes-vous sûr de vouloir supprimer cette varieté  ?", "Supprimer?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int codeParametrage = Convert.ToInt32(textcode.Text.Trim());
                string libelle = textlibelle.Text.Trim();

                if (MessageBox.Show("Etes-vous sûr de vouloir supprimer ce type?", "Supprimer?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Variete es = db.Varietes.ToList<DAL.Variete>().Where(w => w.CodeVariete == codeParametrage).FirstOrDefault();
                    GenericRepository<Variete> variete = new GenericRepository<Variete>(db);
                    variete.Delete(es);
                }
                db.SaveChanges();
                Clear();
                varieteDataGrid();
                MessageBox.Show("varietè supprimée ");
            }
        }

        private void dataGridvariete_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridvariete.CurrentRow.Index != -1)
            {

                textcode.Text = dataGridvariete.CurrentRow.Cells["CodeVariete"].Value.ToString();
                textlibelle.Text = dataGridvariete.CurrentRow.Cells["LibelleVariete"].Value.ToString();
                comboespece.Text = dataGridvariete.CurrentRow.Cells["TypeEspece"].Value.ToString();
                comboprod.Text = dataGridvariete.CurrentRow.Cells["TypeProd"].Value.ToString();
                textmarge.Text = dataGridvariete.CurrentRow.Cells["marge"].Value.ToString();
                textmntmarge.Text = dataGridvariete.CurrentRow.Cells["MntMarge"].Value.ToString();
                textprixvente.Text = dataGridvariete.CurrentRow.Cells["PrixVente"].Value.ToString();
                textCV.Text = dataGridvariete.CurrentRow.Cells["NbrCV"].Value.ToString();
                textCG.Text = dataGridvariete.CurrentRow.Cells["NbrCG"].Value.ToString();
                textPG.Text = dataGridvariete.CurrentRow.Cells["NbrPG"].Value.ToString();


            }
            btnsave.Text = "Modifier";
            btndelete.Enabled = true;

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Clear();

        }
    }
}

