using EasyPlant.DAL;
using EasyPlant.ParametreDeDonnees;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EasyPlant.Commande
{
    public partial class frmClient : Form
    {
        DAL.Client model = new DAL.Client();
        BDPlant db = new BDPlant();
        int Client = 0;

        public frmClient()
        {
            InitializeComponent();
        }
        private void frmClient_Load(object sender, EventArgs e)
        {
            Clear();
            ClientDataGrid();
            List<PointVente> pointVentes = db.PointVentes.ToList();
            comboBoxPointVente.DataSource = pointVentes;
            comboBoxPointVente.DisplayMember = "Libelle";
            comboBoxPointVente.ValueMember = "CodePointVente";

            List<TypeClient> typeClients = db.TypeClients.ToList();
            comboBoxtypeclient.DataSource = typeClients;
            comboBoxtypeclient.DisplayMember = "Libelle";
            comboBoxtypeclient.ValueMember = "CodeTypeClient";

            List<Banque> banques = db.Banques.ToList();
            comboBoxbanque.DataSource = banques;
            comboBoxbanque.DisplayMember = "Libelle";
            comboBoxbanque.ValueMember = "CodeBanque";

        }

        void Clear()
        {
            textcode.Text = textnom.Text = textemail.Text = textadresse.Text = textCIN.Text =
            textcodepostal.Text = textcodeTVA.Text = textfax.Text = textplafonCredit.Text =
            textplafondEnCours.Text = textresponsable.Text = textville.Text = textRIB.Text = texttimbre.Text =
            textsiteweb.Text = comboBoxcommercial.Text = comboBoxPointVente.Text = comboBoxRegTVA.Text =
            comboBoxtypeclient.Text = comboBoxTarif.Text = comboBoxbanque.Text = string.Empty; ;
            btndelete.Enabled = true;
            btnsave.Text = "Enregistrer";
            Client = 0;

        }
        void ClientDataGrid()
        {
            if (db.Clients.ToList().Count > 0)
            {
                dataGridClient.AutoGenerateColumns = false;
                dataGridClient.DataSource = db.Clients.ToList();
            }


        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            model.CodeClient = Convert.ToInt32(textcode.Text.Trim());
            model.Libelle = textnom.Text.Trim();
            model.Adresse = textadresse.Text.Trim();
            model.Ville = textville.Text.Trim();
            model.Responsable = textresponsable.Text.Trim();
            model.CodePostal = Convert.ToInt32(textcodepostal.Text.Trim());
            model.Tel = texttel.Text.Trim();
            model.Fax = textfax.Text.Trim();
            model.Email = textemail.Text.Trim();
            model.SiteWeb = textsiteweb.Text.Trim();
            model.CIN = Convert.ToInt32(textCIN.Text.Trim());
            model.CodeTVA = Convert.ToInt32(textcodeTVA.Text.Trim());
            model.RIB = Convert.ToInt32(textRIB.Text.Trim());
            model.NomCommercial = comboBoxPointVente.Text.Trim();
            model.RegTVA = comboBoxRegTVA.Text.Trim();
            model.Tarif = comboBoxTarif.Text.Trim();
            model.Banque = (Banque)comboBoxbanque.SelectedItem;
            model.Timbre = Convert.ToInt32(texttimbre.Text.Trim());
            model.PointVente = (PointVente)comboBoxPointVente.SelectedItem;
            model.TypeClient = (TypeClient)comboBoxtypeclient.SelectedItem;

            if (Client > 0)
                db.Entry(model).State = EntityState.Modified;
            else
            {
                db.Clients.Add(model);
            }
            db.SaveChanges();
            Clear();
            ClientDataGrid();
            MessageBox.Show("Enregistrement avec succées");
        }

        private void comboBoxPointVente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Etes-vous sûr de vouloir supprimer ce client ?", "Supprimer?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                db.Clients.Remove(model);
                db.SaveChanges();
                Clear();
                ClientDataGrid();
                MessageBox.Show("client supprimé avec succées");
            }
        }




        private void dataGridClient_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridClient.CurrentRow.Index != -1)
            {

                Client = Convert.ToInt32(dataGridClient.CurrentRow.Cells["CodeClient"].Value);
                model = db.Clients.Where(x => x.CodeClient == Client).FirstOrDefault();
                Client = model.CodeClient;
                textcode.Text = dataGridClient.CurrentRow.Cells["CodeClient"].Value.ToString();
                textnom.Text = model.Libelle;
                textadresse.Text = model.Adresse;
                textville.Text = model.Ville;
                textemail.Text = model.Email;
                textsiteweb.Text = model.SiteWeb;
                textresponsable.Text = model.Responsable;
                textcodepostal.Text = model.CodePostal.ToString();
                textCIN.Text = model.CIN.ToString();
                textcodeTVA.Text = model.CodeTVA.ToString();
                textplafonCredit.Text = model.PlafondCredit.ToString();
                textplafondEnCours.Text = model.PlafondEnCours.ToString();
                texttimbre.Text = model.Timbre.ToString();
                textRIB.Text = model.RIB.ToString();
                textfax.Text = model.Fax.ToString();
                texttel.Text = model.Tel.ToString();
                comboBoxbanque.Text = model.Banque.Libelle;
                comboBoxcommercial.Text = model.NomCommercial;
                comboBoxPointVente.Text = model.PointVente.Libelle; ;
                comboBoxRegTVA.Text = model.RegTVA;
                comboBoxTarif.Text = model.Tarif;
                comboBoxtypeclient.Text = model.TypeClient.Libelle;



            }
            btnsave.Text = "Modifier";
            btndelete.Enabled = true;
        }

        private void comboBoxtypeclient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Clear();
        }


        private void btnimprimer_Click(object sender, EventArgs e)
        {
            frmListeClient listeCl = new frmListeClient();
            listeCl.ShowDialog();

        }

        
    }
}
