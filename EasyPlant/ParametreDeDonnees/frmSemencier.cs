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
            MessageBox.Show("Enregistrement avec succées");
        }

        private void SemecierDataGrid_DoubleClick(object sender, EventArgs e)
        {
            if(SemecierDataGrid.CurrentRow.Index != -1)
            {
                Code = Convert.ToInt32(SemecierDataGrid.CurrentRow.Cells["CodeSemencier"].Value);
                model = db.Semenciers.Where(x => x.CodeSemencier == Code).FirstOrDefault();
                textlibelle.Text = model.Libelle;
                textweb.Text = model.SiteWeb;
                textpays.Text = model.Pays;
             }
             btnsave.Text = "Modifier";
             btndelete.Enabled = true;

            }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes-vous sûr de vouloir supprimer ce semencier ?", "Supprimer ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                db.Semenciers.Remove(model);
                db.SaveChanges();
                Clear();
                SemencierDataGrid();
                MessageBox.Show("Semencier supprimé ");
            }

        }
    }

}
