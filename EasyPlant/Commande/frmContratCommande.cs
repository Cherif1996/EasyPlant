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

namespace EasyPlant.Commande
{
    public partial class frmContratCommande : Form
    {
        DAL.Commande model1 = new DAL.Commande();
        DAL.DetailsCommande model2 = new DAL.DetailsCommande();
        BDPlant db = new BDPlant();
        int Commande= 0;
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
            Clear();
            DataGridCommande();

            List<Client> clients = db.Clients.ToList();
            comboBoxNomClient.DataSource = clients;
            comboBoxNomClient.DisplayMember = "Libelle";
            comboBoxNomClient.ValueMember = "CodeClient";

            List<Variete> varietes = db.Varietes.ToList();
            comboBoxVariete.DataSource = varietes;
            comboBoxVariete.DisplayMember = "Libelle";
            comboBoxVariete.ValueMember = "CodeVariete";

            List<DAL.Support> supports = db.Supports.ToList();
            comboBoxSupport.DataSource = supports;
            comboBoxSupport.DisplayMember = "Libelle";
            comboBoxSupport.ValueMember = "CodeSupport";

            List<TypeProduction>  typeProductions= db.TypeProductions.ToList();
            comboBoxTypeProd.DataSource = typeProductions;
            comboBoxTypeProd.DisplayMember = "Libelle";
            comboBoxTypeProd.ValueMember = "CodeTypeProd";

        }
        void DataGridCommande()
        {
            CommandedataGrid.AutoGenerateColumns = false;
            CommandedataGrid.DataSource = db.Commandes.ToList<DAL.Commande>();
        }
        void Clear()
        {
           textnumeroCom.Text = dateTimeCommande.Text= textCodeClient.Text= comboBoxNomClient.Text = textnoteComm.Text = 
           textCodeVariete.Text = comboBoxVariete.Text = textQte.Text= textRemise.Text = textPU.Text = textTotBrut.Text =
           textTotNet.Text = textPUNet.Text = dateTimeLivPrevu.Text = comboBoxSupport.Text = comboBoxTypeProd.Text= radioButtonPepi.Text =
           radioButtonService.Text = checkBoxConsignes.Text =  string.Empty;
           dateTimeDGR.Enabled = false;
           dateTimeDPG.Enabled = false;
           dateTimeDSV.Enabled = false;
           btndelete.Enabled = true;
           btnsave.Text = "Enregistrer";
           Commande = 0;

        }
        

        private void btnvalider_Click(object sender, EventArgs e)
        {
            
            model1.RefCommande = Convert.ToInt32(textnumeroCom.Text.Trim());
           // model1.CodeClient = comboBoxNomClient.ValueMember.ToString();
            model1.Client = (Client)comboBoxNomClient.SelectedItem;
            model1.NomCommercial = comboBoxCommercial.Text.Trim();
            model1.Note = textnoteComm.Text.Trim();
            model1.DateCommande = Convert.ToDateTime(dateTimeCommande.Text.Trim());
            model1.CapaciteProd = Convert.ToInt32(textcapacitéProd.Text.Trim());


            //model2.CodeVariete = Convert.ToInt32(comboBoxVariete.ValueMember);
            model2.Variete = (Variete)comboBoxVariete.SelectedItem;
            model2.Support = (DAL.Support)comboBoxSupport.SelectedItem;
            model2.TypeProduction = (TypeProduction)comboBoxTypeProd.SelectedItem;
            if (Commande > 0)
            {
                db.Entry(model1).State = EntityState.Modified;
                db.Entry(model2).State = EntityState.Modified;
            }
            else
            {
                db.Commandes.Add(model1);
                db.Commandes.Add(model1);
            }

            db.SaveChanges();
            Clear();
            DataGridCommande();
            MessageBox.Show("Enregistrement avec succées");
        }
    
    }
}
