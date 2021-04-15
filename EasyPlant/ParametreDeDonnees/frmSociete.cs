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

namespace EasyPlant.Dossier
{
    public partial class frmSociete : Form
    {
        EasyPlant.DAL.Societe model = new EasyPlant.DAL.Societe();
        BDPlant db = new BDPlant();
        int Code = 0;
        public frmSociete()
        {
            InitializeComponent();
        }

        

        private void btnsave_Click(object sender, EventArgs e)
        {
            model.LibelleAr = textlibellearabe.Text.Trim();

            model.LibelleFr = textlibellefr.Text.Trim();
            model.VilleFr = textvillefr.Text.Trim();
            model.VilleAr = textvilleAr.Text.Trim();
            model.CodePostal = Convert.ToInt32(textpostalfr.Text.Trim());
            model.Banque = textbanque.Text.Trim();
            model.RIB = textRIB.Text.Trim();
            model.Responsable = textresponsable.Text.Trim();
            model.Activite = textactivite.Text.Trim();
            model.Email = textemail.Text.Trim();
            model.SiteWeb = textsiteweb.Text.Trim();
            model.Tel = texttel.Text.Trim();
            model.Fax = textfax.Text.Trim();
            model.CodeD = textcodedouane.Text.Trim();
            model.RegCom = textreg.Text.Trim();
            model.Fonction = textfonction.Text.Trim();
            model.MF = textmatfiscal.Text.Trim();
            model.AdresseFr = textadressefr.Text.Trim();
            model.AdresseAr = textadresseAr.Text.Trim();
            if (Code > 0)
            {
                db.Entry(model).State = EntityState.Modified;
            }
           
            else
            {
                db.Societes.Add(model);
            }
            
           db.SaveChanges();
           MessageBox.Show("Enregistrement avec succées");

        }
        public void getsetting()
        {
           
            Code = Convert.ToInt32(db.Societes.Max(p => p.CodeSociete));
            if (Code > 0)
            {

                model = db.Societes.Where(x => x.CodeSociete == Code).FirstOrDefault();

                textlibellefr.Text = model.LibelleFr.ToString();
                textlibellearabe.Text = model.LibelleAr.ToString();
                textvillefr.Text = model.VilleFr;
                textvilleAr.Text = model.VilleAr;
                textpostalfr.Text = model.CodePostal.ToString();
                textactivite.Text = model.Activite;
                textemail.Text = model.Email;
                textresponsable.Text = model.Responsable;
                texttel.Text = model.Tel;
                textfax.Text = model.Fax;
                textbanque.Text = model.Banque;
                textRIB.Text = model.RIB.ToString();
                textreg.Text = model.RegCom;
                textfonction.Text = model.Fonction;
                textcodedouane.Text = model.CodeD;
                textmatfiscal.Text = model.MF;
                textsiteweb.Text = model.SiteWeb;
                textadressefr.Text = model.AdresseFr;
                textadresseAr.Text = model.AdresseAr;

                db.Entry(model).State = EntityState.Modified;
            }
            else
            {
                MessageBox.Show("pas de paramétres");

            }

        }
        /*private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }*/

        private void frmSociete_Load(object sender, EventArgs e)
        {
            getsetting();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {

        }
    }
}
