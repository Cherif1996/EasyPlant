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
    public partial class frmFourniseur : Form
           
    {
        EasyPlant.DAL.Fourniseur model = new EasyPlant.DAL.Fourniseur();
        BDPlant db = new BDPlant();
        int Code = 0;
        public frmFourniseur()
        {
            InitializeComponent();
        }

        private void frmFourniseur_Load(object sender, EventArgs e)
        {
            List<PointVente> pointVentes = db.PointVentes.ToList();
            comboBoxPointVente.DataSource = pointVentes;
            comboBoxPointVente.DisplayMember = "Libelle";
            comboBoxPointVente.ValueMember = "CodePointVente";

            List<TypeClient> typeClients = db.TypeClients.ToList();
            comboBoxtype.DataSource = typeClients;
            comboBoxtype.DisplayMember = "Libelle";
            comboBoxtype.ValueMember = "CodeTypeClient";

            List<Banque> banques = db.Banques.ToList();
            comboBoxbanque.DataSource = banques;
            comboBoxbanque.DisplayMember = "Libelle";
            comboBoxbanque.ValueMember = "CodeBanque";

            Clear();
        FourniseurDataGrid();
    }

        private void btnsave_Click(object sender, EventArgs e)
        {
            model.CodeFouriseur = Convert.ToInt32(textcode.Text.Trim());
            model.NomFourniseur = textnom.Text.Trim();
            model.Adresse = textadresse.Text.Trim();
            model.Ville = textville.Text.Trim();
            model.Responsable = textresponsable.Text.Trim();
            model.CodePostal = Convert.ToInt32(textcodepostal.Text.Trim());
            model.Tel = texttel.Text.Trim();
            model.Fax = textfax.Text.Trim();
            model.Email = textemail.Text.Trim();
            model.Site = textsiteweb.Text.Trim();
            model.CIN = Convert.ToInt32(textCIN.Text.Trim());
            model.CodeTva = textcodeTVA.Text.Trim();
            model.RIB = textRIB.Text.Trim();
            model.Commercial = comboBoxcommercial.Text.Trim();
            model.Banque = (Banque)comboBoxbanque.SelectedItem;
            model.PointVente = (PointVente)comboBoxPointVente.SelectedItem;
            model.TypeClient1 = (TypeClient)comboBoxtype.SelectedItem;


            if (Code > 0)
                db.Entry(model).State = EntityState.Modified;
            else
            {
                db.Fourniseurs.Add(model);
            }


            db.SaveChanges();
            FourniseurDataGrid();
            Clear();
            MessageBox.Show("Enregistrement avec succées");
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes-vous sûr de vouloir supprimer ce Fourniseur ?", "Supprimer?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                db.Fourniseurs.Remove(model);
                db.SaveChanges();
                Clear();
                FourniseurDataGrid();
                MessageBox.Show("client supprimé avec succées");
            }
        }

        private void dataGridFourniseur_Click(object sender, EventArgs e)
        {
            if (dataGridFourniseur.CurrentRow.Index != -1)
            {
                Code = Convert.ToInt32(dataGridFourniseur.CurrentRow.Cells["CodeFourniseur"].Value);
                model = db.Fourniseurs.Where(x => x.CodeFouriseur == Code).FirstOrDefault();
                Code = model.CodeFouriseur;
                textcode.Text = dataGridFourniseur.CurrentRow.Cells["CodeFourniseur"].Value.ToString();
                textnom.Text = model.NomFourniseur;
                textadresse.Text = model.Adresse;
                textville.Text = model.Ville;
                textemail.Text = model.Email;
                textsiteweb.Text = model.Site;
                textresponsable.Text = model.Responsable;
                textcodepostal.Text = model.CodePostal.ToString();
                textCIN.Text = model.CIN.ToString();
         
                textRIB.Text = model.RIB.ToString();
                textfax.Text = model.Fax.ToString();
                texttel.Text = model.Tel.ToString();
                comboBoxbanque.Text = model.Banque.Libelle;
                comboBoxcommercial.Text = model.Commercial;
                comboBoxPointVente.Text = model.PointVente.Libelle;
                comboBoxtype.Text = model.TypeClient1.Libelle;


            }
            btnsave.Text = "Modifier";
            btndelete.Enabled = true;
        }
        void FourniseurDataGrid()
        {
            if (db.Fourniseurs.ToList().Count > 0)
            {
                dataGridFourniseur.AutoGenerateColumns = false;
                dataGridFourniseur.DataSource = db.Fourniseurs.ToList();
            }


        }
        void Clear()
        {
            textcode.Text = textnom.Text = textemail.Text = textadresse.Text = textCIN.Text =
            textcodepostal.Text = textcodeTVA.Text = textfax.Text = textresponsable.Text = textville.Text = textRIB.Text =
            textsiteweb.Text = comboBoxcommercial.Text = comboBoxPointVente.Text =
            comboBoxtype.Text = comboBoxbanque.Text = string.Empty; ;
            btndelete.Enabled = true;
            btnsave.Text = "Enregistrer";
            Code= 0;

        }
    }
}
