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
    public partial class frmSemencier : Form
    {
        EasyPlant.DAL.Semencier model = new EasyPlant.DAL.Semencier();
        BDPlant db = new BDPlant();
        int Code = 0;

        public frmSemencier()
        {
            InitializeComponent();
        }

        private void frmSemencier_Load(object sender, EventArgs e)
        {
            Clear();
            SemencierDataGrid();
        }

      
        

        private void btncancel_Click(object sender, EventArgs e)
        {
            Clear();

        }
        
        void Clear()
        {
            textcode.Text = textlibelle.Text = textpays.Text = textweb.Text = "";
            btnsave.Text = "Enregistrer";
            btndelete.Enabled = true;
            Code = 0;

        }
        void SemencierDataGrid()
        {
            SemecierDataGrid.AutoGenerateColumns = false;
            SemecierDataGrid.DataSource = db.Semenciers.ToList<DAL.Semencier>();

        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            model.CodeSemencier = Convert.ToInt32(textcode.Text.Trim());
            model.Libelle = textlibelle.Text.Trim();
            model.Pays = textpays.Text.Trim();
            model.SiteWeb = textweb.Text.Trim();

            if (Code > 0)
                db.Entry(model).State = EntityState.Modified;
            else
            {
                db.Semenciers.Add(model);
            }
            
            
            db.SaveChanges();
            Clear();
            SemencierDataGrid();
            MessageBox.Show("Enregistrement avec succées");
        }

        private void SemecierDataGrid_DoubleClick(object sender, EventArgs e)
        {
            if(SemecierDataGrid.CurrentRow.Index != -1)
            {
                
                textcode.Text = SemecierDataGrid.CurrentRow.Cells["CodeSemencier"].Value.ToString();
                textlibelle.Text = SemecierDataGrid.CurrentRow.Cells["Libelle"].Value.ToString();
                textpays.Text = SemecierDataGrid.CurrentRow.Cells["Pays"].Value.ToString();
                textweb.Text = SemecierDataGrid.CurrentRow.Cells["SiteWeb"].Value.ToString();

               
             }
             btnsave.Text = "Modifier";
             btndelete.Enabled = true;

            }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes-vous sûr de vouloir supprimer cet semencier?", "Supprimer?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int codeParametrage = Convert.ToInt32(textcode.Text.Trim());
                string libelle = textlibelle.Text.Trim();

                if (MessageBox.Show("Etes-vous sûr de vouloir supprimer ce type?", "Supprimer?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Semencier es = db.Semenciers.ToList<DAL.Semencier>().Where(w => w.CodeSemencier == codeParametrage).FirstOrDefault();
                    GenericRepository<Semencier> sem = new GenericRepository<Semencier>(db);
                    sem.Delete(es);
                }
                db.SaveChanges();
                Clear();
                SemencierDataGrid();
                MessageBox.Show("semencier supprimé ");
            }

        }
    }

}
