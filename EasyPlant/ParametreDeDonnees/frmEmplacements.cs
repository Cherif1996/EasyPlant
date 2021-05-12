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
    public partial class frmEmplacements : Form
    {
        EasyPlant.DAL.Emplacement model = new EasyPlant.DAL.Emplacement();
        BDPlant db = new BDPlant();
        int Code = 0;
        public frmEmplacements()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            model.CodeEmplacement = Convert.ToInt32(textBoxCodeEmpl.Text.Trim());
            model.Libelle = textBoxLibelle.Text.Trim();
            model.CapaciteEmplacement = Convert.ToInt32(textBoxCapaciteEmpl.Text.Trim());

            if (Code > 0)
                db.Entry(model).State = EntityState.Modified;
            else
            {
                db.Emplacements.Add(model);
            }

            db.SaveChanges();
            Clear();
            DataGridEmplacement();
            MessageBox.Show("Enregistrement avec succées");
        }

        private void frmEmplacements_Load(object sender, EventArgs e)
        {

            Clear();
            DataGridEmplacement();
        }
        void Clear()
        {
            textBoxCodeEmpl.Text = textBoxLibelle.Text = textBoxCapaciteEmpl.Text = string.Empty; ;
            btnDelete.Enabled = true;
            btnSave.Text = "Enregistrer";
            Code = 0;

        }
        public void DataGridEmplacement()
        {
            dataGridEmplacement.AutoGenerateColumns = false;
            dataGridEmplacement.DataSource = db.Emplacements.ToList<DAL.Emplacement>();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Etes-vous sûr de vouloir supprimer cet Emplacement ?", "Supprimer?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                db.Emplacements.Remove(model);
                db.SaveChanges();
                Clear();
                DataGridEmplacement();
                MessageBox.Show("Type semence supprimé ");
            }

        }

        private void dataGridEmplacement_Click(object sender, EventArgs e)
        {
            if (dataGridEmplacement.CurrentRow.Index != -1)
            {
                textBoxCodeEmpl.Text = dataGridEmplacement .CurrentRow.Cells["CodeEmplacement"].Value.ToString();
                textBoxCapaciteEmpl.Text = dataGridEmplacement.CurrentRow.Cells["CapaciteEmplacement"].Value.ToString();

                textBoxLibelle.Text = dataGridEmplacement.CurrentRow.Cells["Libelle"].Value.ToString();


            }
            btnSave.Text = "Modifier";
            btnDelete.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
