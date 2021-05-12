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
    public partial class frmSerres : Form
    {
        EasyPlant.DAL.Serre model = new EasyPlant.DAL.Serre();
        BDPlant db = new BDPlant();

        int Code = 0;
        public frmSerres()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            model.CodeSerre = Convert.ToInt32(textCodeSerre.Text.Trim());
            model.Superficier = Convert.ToInt32(textSuperficie.Text.Trim());
            model.Capacite = Convert.ToInt32(textCapacite.Text.Trim());
            model.Emplacement = (Emplacement)comboBoxLibelle.SelectedItem;

            if (Code > 0)
                db.Entry(model).State = EntityState.Modified;
            else
            {
                db.Serres.Add(model);
            }

            db.SaveChanges();



            Clear();
            datagridserre();
            MessageBox.Show("Enregistrement avec succées");
        }

        private void frmSerres_Load(object sender, EventArgs e)
        {
            Clear();
            datagridserre();
            List<Emplacement> emplacements  = db.Emplacements.ToList();
            comboBoxLibelle.DataSource = emplacements;
            comboBoxLibelle.DisplayMember = "Libelle";
            comboBoxLibelle.ValueMember = "CodeEmplacement";
        }
        void Clear()
        {
            textCapacite.Text = textCodeSerre.Text = comboBoxLibelle.Text = textSuperficie.Text = string.Empty;
            btnDelete.Enabled = true;
            btnSave.Text = "Enregistrer";
            Code = 0;
            

        }
        void datagridserre()
        {
            dataGridSerre.AutoGenerateColumns = false;
            dataGridSerre.DataSource = db.Serres.ToList<DAL.Serre>();

        }
        private void dataGridSerre_Click(object sender, EventArgs e)
        {
            if (dataGridSerre.CurrentRow.Index != -1)
            {
                textCodeSerre.Text = dataGridSerre.CurrentRow.Cells["CodeSerre"].Value.ToString();
                model = db.Serres.Where(x => x.CodeSerre == Code).FirstOrDefault();
                textCapacite.Text = dataGridSerre.CurrentRow.Cells["Capacite"].Value.ToString();
                textSuperficie .Text = dataGridSerre.CurrentRow.Cells["Superficier"].Value.ToString();
              
                foreach (Emplacement d in comboBoxLibelle.Items)
                {
                    if (d.Libelle == dataGridSerre.CurrentRow.Cells["LibelleEmplacement"].Value.ToString())
                    {
                        comboBoxLibelle.SelectedItem = d;
                        break;
                    }
                }

            }
            btnSave.Text = "Modifier";
            btnDelete.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int codeSer = Convert.ToInt32(textCodeSerre.Text.Trim());
            int cap = Convert.ToInt32(textCapacite.Text.Trim());
            int sup = Convert.ToInt32(textSuperficie.Text.Trim());

            string lib = comboBoxLibelle.Text.Trim();

            if (MessageBox.Show("Etes-vous sûr de vouloir supprimer cette Serre?", "Supprimer?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Serre s = db.Serres .ToList<DAL.Serre>().Where(w => w.CodeSerre == codeSer).FirstOrDefault();
                GenericRepository<Serre> ser = new GenericRepository<Serre>(db);
               ser.Delete(s);

                db.SaveChanges();
                Clear();
                datagridserre();
                MessageBox.Show("utilisateur supprimé");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
    

