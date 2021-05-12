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

namespace EasyPlant
{
    public partial class frmParametrageProductions : Form
    {
        EasyPlant.DAL.ParametrageProduction model = new EasyPlant.DAL.ParametrageProduction();
        BDPlant db = new BDPlant();
        int Code = 0;
        public frmParametrageProductions()
        {
            InitializeComponent();
        }

        private void frmParametrageProductions_Load(object sender, EventArgs e)
        {

            getsetting();

        }
        void Clear()
        {
            textBoxCapacite.Text = textBoxGreffage.Text = textBoxlivraison.Text = textBoxSemis.Text = textBoxSemisPorte.Text = string.Empty; ;
            btnSave.Text = "Enregistrer";
            Code = 0;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            model.Capacite = Convert.ToInt32(textBoxCapacite.Text.Trim());
            model.RappelGreffage = Convert.ToInt32(textBoxGreffage.Text.Trim());
            model.RappelLivraison = Convert.ToInt32(textBoxlivraison.Text.Trim());
            model.RappelSemis = Convert.ToInt32(textBoxSemis.Text.Trim());
            model.RappelSemisPorte = Convert.ToInt32(textBoxSemisPorte.Text.Trim());

            
            if (Code > 0)
            {

                //Code = Convert.ToInt32(db.ParametrageProductions.Max(p => p.CodeParProduction));
                //model = db.ParametrageProductions.Where(x => x.CodeParProduction == Code).FirstOrDefault();
                db.Entry(model).State = EntityState.Modified;
            }

            else
            {
                db.ParametrageProductions.Add(model);
            }

            db.SaveChanges();
            MessageBox.Show("Enregistrement avec succées");
        }

        public void getsetting()

        {
            Code = Convert.ToInt32(db.ParametrageProductions.Max(p => p.CodeParProduction));
            if (Code > 0)
            {
                
                model = db.ParametrageProductions.Where(x => x.CodeParProduction == Code).FirstOrDefault();

                textBoxCapacite.Text = model.Capacite.ToString();
                textBoxGreffage.Text = model.RappelGreffage.ToString();
                textBoxlivraison.Text = model.RappelLivraison.ToString();
                textBoxSemis.Text = model.RappelLivraison.ToString();
                textBoxSemisPorte.Text = model.RappelSemisPorte.ToString();
                db.Entry(model).State = EntityState.Modified;
            }
            else
            {
                MessageBox.Show("pas de paramétres");

            }


        }
    }
}

