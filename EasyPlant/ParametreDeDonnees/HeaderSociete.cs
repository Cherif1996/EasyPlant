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

namespace EasyPlant.ParametreDeDonnees
{
    public partial class HeaderSociete : Form
    {
        List<Societe> societes = new List<Societe>();
        BDPlant db = new BDPlant();

        public HeaderSociete()
        {
            InitializeComponent();
        }

        //private void HeaderSociete_Load(object sender, EventArgs e)
        //{
        //   societes = db.Societes.ToList<DAL.Societe>();
        //   Reports.ModelePrincipal modele = new Reports.ModelePrincipal();
        //   modele.SetDataSource(societes);
        //   crystalReportViewer1.ReportSource = modele;
        //   crystalReportViewer1.RefreshReport();

        //}
    }
}
