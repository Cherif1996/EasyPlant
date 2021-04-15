using EasyPlant.DAL;
using EasyPlant.Reports;
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
    public partial class frmListeClient : Form
    {
        List<Client> clients = new List<Client>();

        BDPlant db = new BDPlant();

        public frmListeClient()
        {
            InitializeComponent();
        }

        private void frmListeClient_Load(object sender, EventArgs e)
        {
            clients = db.Clients.ToList<DAL.Client>();

            Reports.ListeClient listeCL = new Reports.ListeClient();

            listeCL.SetDataSource(clients);

            crystalReportViewer1.ReportSource = listeCL;
            crystalReportViewer1.RefreshReport();
           
        }


    }
}
