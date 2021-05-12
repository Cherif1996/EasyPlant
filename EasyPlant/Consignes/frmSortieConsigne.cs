using EasyPlant.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyPlant.Consignes
{
    public partial class frmSortieConsigne : Form
    {
        SortieConsigne model = new SortieConsigne();
        List<SortieConsigne> SortieConsignes = new List<SortieConsigne>();
        BDPlant db = new BDPlant();

        int CodeS = 0;

        public frmSortieConsigne()
        {
            InitializeComponent();
        }

        private void frmSortieConsigne_Load(object sender, EventArgs e)
        {
            List<DAL.MoyenTransport> MoyenTransports = db.MoyenTransports.ToList();
            comboBoxMoyenTrans.DataSource = MoyenTransports;
            comboBoxMoyenTrans.DisplayMember = "Libelle";
            comboBoxMoyenTrans.ValueMember = "CodeMoyenTransport";


            List<DAL.Livreur> livreurs = db.Livreurs.ToList();
            comboBoxLivreur.DataSource = livreurs;
            comboBoxLivreur.DisplayMember = "Libelle";
            comboBoxLivreur.ValueMember = "CodeLivreur";


            List<DAL.PointVente> PointVentes = db.PointVentes.ToList();
            comboboxDestination.DataSource = PointVentes;
            comboboxDestination.DisplayMember = "Libelle";
            comboboxDestination.ValueMember = "CodePointVente";

            Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int nbreBonSortie = 0;
            nbreBonSortie = db.SortieConsignes.ToList().Where(x => x.NumeroSortie == Convert.ToInt32(textNumSortie.Text.Trim())).Count();
            if (nbreBonSortie > 0)
                MessageBox.Show("Facture existe déjà");
            else
            {
                foreach (SortieConsigne item in SortieConsignes)
                {
                    db.SortieConsignes.Add(item);
                }

            }
            db.SaveChanges();
            Clear();
            MessageBox.Show("Enregistrement avec succées");
        }

        void SortieConsigneDataGrid()
        {

            model.NumeroSortie = Convert.ToInt32(textNumSortie.Text.Trim());
            model.DateSortie = DateTime.Parse(dateSortie.Text);
            model.Qte = Convert.ToInt32(textQte.Text);
            model.PrixTot = Convert.ToDecimal(textPrixTot.Text);
            model.PrixUnit = Convert.ToDecimal(textPrixUnit.Text);
            model.Designation = Convert.ToString(textlibelle.Text);
            model.CodeSupport = Convert.ToInt32(textCodeSupport.Text);
            model.Note = Convert.ToString(textNote.Text);
            //model.Quantite = String.IsNullOrEmpty(textQte.Text.ToString()) ? 0 : Convert.ToInt32(textQte.Text.Trim());
            model.Livreur = (DAL.Livreur)comboBoxLivreur.SelectedItem;
            model.PointVente = (DAL.PointVente)comboboxDestination.SelectedItem;
            model.MoyenTransport = (DAL.MoyenTransport)comboBoxMoyenTrans.SelectedItem;
            SortieConsignes.Add(model);
            if (SortieConsignes.Count > 0)
            {
                dataGridSortieConsigne.AutoGenerateColumns = false;
                dataGridSortieConsigne.DataSource = SortieConsignes.ToList();
            }

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            SortieConsigneDataGrid();
        }

        void Clear()
        {
            textNumSortie.Text = textlibelle.Text = textCodeSupport.Text =
            textNote.Text = textPrixTot.Text = textPrixUnit.Text = textQte.Text = comboBoxMoyenTrans.Text = comboBoxLivreur.Text =
            comboboxDestination.Text = string.Empty;
            btnDelete.Enabled = true;
            btnSave.Text = "Enregistrer";
            CodeS = 0;

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes-vous sûr de vouloir supprimer cet consigne ?", "Supprimer?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                db.SortieConsignes.Remove(model);
                db.SaveChanges();
                Clear();
                SortieConsigneDataGrid();
                MessageBox.Show("client supprimé avec succées");
            }
        }

        private void textPrixUnit_TextChanged(object sender, EventArgs e)
        {
            if (textQte.Text.Length > 0 && textPrixUnit.Text.Length > 0)
            {
                textPrixTot.Text = Convert.ToString(Convert.ToInt32(textQte.Text) * Convert.ToDecimal(textPrixUnit.Text));
            }
        }
    }
}
