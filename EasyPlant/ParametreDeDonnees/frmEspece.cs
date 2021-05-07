using EasyPlant.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyPlant.ParametreDeDonnees
{
    public partial class frmEspece : Form
    {
        DAL.Espece model = new DAL.Espece();
        BDPlant db = new BDPlant();
        int Code = 0;
        public frmEspece()
        {
            InitializeComponent();
        }

        private void frmEspece_Load(object sender, EventArgs e)
        {
            Clear();
            especeDataGrid();

            List<Famille> familles = db.Familles.ToList();
            combofamille.DataSource = familles;
            combofamille.DisplayMember = "LibelleFamille";
            combofamille.ValueMember = "CodeFamille";
        }
        void Clear()
        {
            textcode.Text = textlibelle.Text = combofamille.Text = string.Empty; ;
            btndelete.Enabled = true;
            btnsave.Text = "Enregistrer";
            Code = 0;

        }
        void especeDataGrid()
        {


            DataGridespece.AutoGenerateColumns = false;
            DataGridespece.DataSource = db.Especes.ToList<DAL.Espece>();


        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            model.CodeEspece = Convert.ToInt32(textcode.Text.Trim());
            model.LibelleEspece = textlibelle.Text.Trim();
            model.Famille = (Famille)combofamille.SelectedItem;
            if (Code > 0)
                db.Entry(model).State = EntityState.Modified;
            else
            {
                db.Especes.Add(model);
            }
            db.SaveChanges();
            Clear();
            especeDataGrid();
            MessageBox.Show("Enregistrement avec succées");
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes-vous sûr de vouloir supprimer cet espèce ?", "Supprimer?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int codeParametrage = Convert.ToInt32(textcode.Text.Trim());
                string libelle = textlibelle.Text.Trim();

                if (MessageBox.Show("Etes-vous sûr de vouloir supprimer ce type?", "Supprimer?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Espece es = db.Especes.ToList<DAL.Espece>().Where(w => w.CodeEspece == codeParametrage).FirstOrDefault();
                    GenericRepository<Espece> espece = new GenericRepository<Espece>(db);
                    espece.Delete(es);
                }   
                db.SaveChanges();
                Clear();
                especeDataGrid();
                MessageBox.Show("espèce supprimé ");
            }
        }

        private void DataGridespece_DoubleClick(object sender, EventArgs e)
        {
            if (DataGridespece.CurrentRow.Index != -1)
            {
                
                textcode.Text = DataGridespece.CurrentRow.Cells["CodeEspece"].Value.ToString();
                textlibelle.Text = DataGridespece.CurrentRow.Cells["LibelleEspece"].Value.ToString();
                combofamille.Text = DataGridespece.CurrentRow.Cells["Famille"].Value.ToString();

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
