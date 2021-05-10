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

namespace EasyPlant.Commande
{
    public partial class frmEnter : Form
    {
        BDPlant db = new BDPlant();
        List<CodeLibelle> listeCodeLibelle = new List<CodeLibelle>();
        CodeLibelle codeLibelle = new CodeLibelle();
        public frmEnter()
        {
            InitializeComponent();
        }

        private void frmEnter_Load(object sender, EventArgs e)
        {
            this.Text = "Client";
            dgListCodeLibelle.AutoGenerateColumns = false;
            List<Client> listeClients = new List<Client>();
            listeClients = db.Clients.ToList<Client>();
            listeClients.ForEach(x => listeCodeLibelle.Add(new CodeLibelle { Code = x.CodeClient, Libelle = x.Libelle }));
            dgListCodeLibelle.DataSource = listeCodeLibelle;
        }

        private void dgListCodeLibelle_DoubleClick(object sender, EventArgs e)
        {

            if (dgListCodeLibelle.CurrentRow.Index != -1)
            {

                codeLibelle.Code = Convert.ToInt32(dgListCodeLibelle.CurrentRow.Cells["CodeClient"].Value);
                codeLibelle.Libelle = dgListCodeLibelle.CurrentRow.Cells["LibelleClient"].Value.ToString();
                this.Close();
            }
        }

        public Client getSelectedClient()
        {
            Client client = db.Clients.Where(x => x.CodeClient == codeLibelle.Code).FirstOrDefault();
            return client;
        }
    }
}
