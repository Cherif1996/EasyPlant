using EasyPlant.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyPlant.Commande
{
    public partial class frmContratCommande : Form
    {
        DAL.Commande model = new DAL.Commande();

        List<DAL.Commande> listecommande = new List<DAL.Commande>();


        BDPlant db = new BDPlant();
        public frmContratCommande()
        {
            InitializeComponent();
        }

        private void btncreate_Click(object sender, EventArgs e)
        {

            btnImpCommande.Enabled = false;
            btnImpBonReSemences.Enabled = false;
            btnImpConsignes.Enabled = false;

        }

        private void frmContratCommande_Load(object sender, EventArgs e)
        {      

            List<DAL.Client> clients = db.Clients.ToList();
            foreach (Client client in clients)
            {
                comboclient.Items.Add(clients);
            }
            comboclient.DataSource = clients;
            comboclient.DisplayMember = "Libelle";
            comboclient.ValueMember = "CodeClient";

            List<DAL.Variete> varietes = db.Varietes.ToList();
            combovariete.DataSource = varietes;
            combovariete.DisplayMember = "LibelleVariete";
            combovariete.ValueMember = "CodeVariete";


            List<DAL.Support> supports = db.Supports.ToList();
            comboBoxSupport.DataSource = supports;
            comboBoxSupport.DisplayMember = "Libelle";
            comboBoxSupport.ValueMember = "CodeSupport";

            List<TypeProduction>  typeProductions= db.TypeProductions.ToList();
            comboBoxTypeProd.DataSource = typeProductions;
            comboBoxTypeProd.DisplayMember = "Libelle";
            comboBoxTypeProd.ValueMember = "CodeTypeProd";

            Clear();


        }
        void DataGridCommande()
        {
            //Commande
            model.RefCommande = Convert.ToInt32(textnumeroCom.Text.Trim());
            model.Client = (Client)comboclient.SelectedItem;
            model.NomCommercial = comboBoxCommercial.Text.Trim();
            model.Note = textnoteComm.Text.Trim();
            model.DateCommande = DateTime.Parse(dateTimeCommande.Text);
            model.Variete = (Variete)combovariete.SelectedItem;
            model.Support = (DAL.Support)comboBoxSupport.SelectedItem;
            model.TypeProduction = (TypeProduction)comboBoxTypeProd.SelectedItem;
            model.Qte = Convert.ToInt32(textQte.Text.Trim());
            model.PrixUnitaire = decimal.Parse(textPU.Text, CultureInfo.InvariantCulture);
            model.PrixUnitaireNet = decimal.Parse(textPUNet.Text, CultureInfo.InvariantCulture);
            model.Remise = Convert.ToInt32(textRemise.Text.Trim());
            model.TotalBrut = decimal.Parse(textTotBrut.Text, CultureInfo.InvariantCulture);
            model.TotalBrutNet = decimal.Parse(textTotNet.Text, CultureInfo.InvariantCulture);
            model.DateLivraisonPrevu = DateTime.Parse(dateTimeLivPrevu.Text.Trim());
            model.DateCV = DateTime.Parse(dateTimeDSV.Text);
            model.DateCG = DateTime.Parse(dateTimeDPG.Text);
            model.DatePG = DateTime.Parse(dateTimeDPG.Text);
            // Type Commande 
            if (radioButtonPepi.Checked)
            {
                model.TypeCommande = "P";

            }
            if (radioButtonService.Checked)
            {
                model.TypeCommande = "C";
            }
            // Resservation consignes
            if (checkBoxConsignes.Checked)
            {
                model.ReservationCons = "C";
            }
            else
            {
                model.ReservationCons = "P";
            }
            listecommande.Add(model);
            listecommande.Add(model);
            if (listecommande.Count > 0)
            {
                CommandedataGrid.AutoGenerateColumns = false;
                CommandedataGrid.DataSource = listecommande.ToList();
            }
            
            
        }
        void Clear()
        {
           textnumeroCom.Text = dateTimeCommande.Text=  comboclient.Text =  textnoteComm.Text = textBoxcode.Text=
           combovariete.Text =   textQte.Text= textRemise.Text = textPU.Text = textTotBrut.Text =
           textTotNet.Text = textPUNet.Text = dateTimeLivPrevu.Text = comboBoxSupport.Text = comboBoxTypeProd.Text= radioButtonPepi.Text =
           radioButtonService.Text = checkBoxConsignes.Text =  string.Empty;
           
           btndelete.Enabled = true;
           btnsave.Text = "Enregistrer";

        }
        

        private void btnvalider_Click(object sender, EventArgs e)
        {
            DataGridCommande();

        }

        private void textQte_TextChanged(object sender, EventArgs e)
        {
            if (textQte.Text.Length > 0 && textPU.Text.Length > 0)
            {
                textTotBrut.Text = Convert.ToString(Convert.ToInt32(textQte.Text) * Convert.ToDecimal(textPU.Text));
            }
        }

        private void textPU_TextChanged(object sender, EventArgs e)
        {
            if (textQte.Text.Length > 0 && textPU.Text.Length > 0)
            {
                textTotBrut.Text = Convert.ToString(Convert.ToInt32(textQte.Text) * Convert.ToDecimal(textPU.Text));
            }

        }

        private void textRemise_TextChanged(object sender, EventArgs e)
        {


            if (textQte.Text.Length > 0 && textPU.Text.Length > 0 && textRemise.Text.Length > 0)
            {
                textTotBrut.Text = Convert.ToString(Convert.ToInt32(textQte.Text) * Convert.ToDecimal(textPU.Text));
                decimal remise = Convert.ToDecimal(textRemise.Text) / 100 * Convert.ToDecimal(textPU.Text);
                textPUNet.Text = Convert.ToString(Convert.ToDecimal(textPU.Text) - remise); 
                textTotNet.Text = Convert.ToString(Convert.ToInt32(textQte.Text) * Convert.ToDecimal(textPUNet.Text));

            }
        }

        private void dateTimeLivPrevu_ValueChanged(object sender, EventArgs e)
        {
            Variete selectedVariete = db.Varietes.FirstOrDefault();
            DateTime dateLiv = Convert.ToDateTime(dateTimeLivPrevu.Text);
            DateTime dateCV = Convert.ToDateTime(dateTimeDSV.Text);
            DateTime dateGreffage = dateLiv.AddDays(-selectedVariete.NBjoursCG);
            DateTime dateSemiVariete = dateGreffage.AddDays(-selectedVariete.NBjoursCV);
            DateTime datePorteGreffe = dateSemiVariete.AddDays(-selectedVariete.NBjoursPG);
            dateTimeDGR.Value = dateGreffage.Date;
            dateTimeDSV.Value = dateSemiVariete.Date;
            dateTimeDPG.Value = datePorteGreffe.Date;


        }

        private void btnAvance_Click(object sender, EventArgs e)
        {
            frmAvance form_Avance = new frmAvance();
            form_Avance.ShowDialog();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dateTimeLivPrevu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==(char) Keys.Enter)
            {
               Variete selectedVariete = db.Varietes.FirstOrDefault();
            DateTime dateLiv = Convert.ToDateTime(dateTimeLivPrevu.Text);
            DateTime dateCV = Convert.ToDateTime(dateTimeDSV.Text);
            DateTime dateGreffage = dateLiv.AddDays(-selectedVariete.NBjoursCG);
            DateTime dateSemiVariete = dateGreffage.AddDays(-selectedVariete.NBjoursCV);
            DateTime datePorteGreffe = dateSemiVariete.AddDays(-selectedVariete.NBjoursPG);
            dateTimeDGR.Value = dateGreffage.Date;
            dateTimeDSV.Value = dateSemiVariete.Date;
            dateTimeDPG.Value = datePorteGreffe.Date;
            }
        }

        private void CommandedataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            int nbCommande = 0;
            nbCommande = db.Commandes.ToList().Where(x => x.RefCommande == Convert.ToInt32(textnumeroCom.Text.Trim())).Count();
            if (nbCommande > 0)
                MessageBox.Show("Commande existe déjà");
            else
            {
                foreach (DAL.Commande item in listecommande)
                {
                    db.Commandes.Add(item);
                }

            }
            db.SaveChanges();
            Clear();
            MessageBox.Show("Enregistrement avec succées");
        }

        private void comboclient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxcode_KeyPress(object sender, KeyPressEventArgs e)
        {
//            if (e.KeyChar == (char)Keys.Enter)
//            {
//               Form cl = new Form();
//               cl.add = db.Clients.ToList();
//                cl.ShowDialog();
//                if(e.KeyChar == (char)Keys.Escape)
//{
//                    this.Close();
//                }
//            }

        }
    }
    }

  