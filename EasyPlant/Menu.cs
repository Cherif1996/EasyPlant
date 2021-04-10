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
using EasyPlant.Commun;
using EasyPlant.Commande;
using EasyPlant.ParametreDeDonnees;

namespace EasyPlant
{
    public partial class Menu : Form

    {
        public Menu()
        {
            InitializeComponent();
            

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void paramétrageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            


        }

        private void Menu_Load(object sender, EventArgs e)
        {
            /*this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;*/
        }

        private void listeDesSemenciersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSemencier semencier = new frmSemencier();
            semencier.ShowDialog();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listeSupportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Support form_support = new Support();
            form_support.ShowDialog();
        }

        private void listeFamillesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCodeLibelle form_Livreur = new frmCodeLibelle();
            LibelleForm.libelle = "Liste Familles";
            form_Livreur.ShowDialog();

        }

        private void pointDeVenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PointDeVente form_pointVente = new PointDeVente();
            form_pointVente.ShowDialog();

        }

        private void livreursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCodeLibelle form_Livreur = new frmCodeLibelle();
            LibelleForm.libelle = "Livreur";
            form_Livreur.ShowDialog();

        }

        private void moyensDeTransportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCodeLibelle form_Livreur = new frmCodeLibelle();
            LibelleForm.libelle = "Moyen de Transport";
            form_Livreur.ShowDialog();
        }

        private void bonCommandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmContratCommande contratCommande = new frmContratCommande();
            contratCommande.ShowDialog();
        }

        private void gestionClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClient client = new frmClient();
            client.ShowDialog();
        }

        private void créationProfilsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void banqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCodeLibelle form_Livreur = new frmCodeLibelle();
            LibelleForm.libelle = "Banque";
            form_Livreur.ShowDialog();
        }

        

        private void modeDeRéglementToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmCodeLibelle form_Livreur = new frmCodeLibelle();
            LibelleForm.libelle = "Mode de Réglement";
            form_Livreur.ShowDialog();
        }

        private void typeClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCodeLibelle form_Livreur = new frmCodeLibelle();
            LibelleForm.libelle = "Type Client";
            form_Livreur.ShowDialog();
        }

        private void colisageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCodeLibelle form_Livreur = new frmCodeLibelle();
            LibelleForm.libelle = "Colisage";
            form_Livreur.ShowDialog();

        }

        private void colisageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCodeLibelle form_Livreur = new frmCodeLibelle();
            LibelleForm.libelle = "Unité";
            form_Livreur.ShowDialog();

        }

        private void typeDeProductionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCodeLibelle form_Livreur = new frmCodeLibelle();
            LibelleForm.libelle = "Type de Production";
            form_Livreur.ShowDialog();

        }

        private void typeCompatgeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCodeLibelle form_Livreur = new frmCodeLibelle();
            LibelleForm.libelle = "Type de Comptage";
            form_Livreur.ShowDialog();
        }

        private void listesEspécesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frmEspece espece = new frmEspece();
           espece.ShowDialog();

        }
    }
}
