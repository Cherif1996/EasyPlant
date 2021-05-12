using EasyPlant.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyPlant.Dossier
{
    public partial class frmGestionProfils : Form
    {
        EasyPlant.DAL.Utilisateur model = new EasyPlant.DAL.Utilisateur();
        BDPlant db = new BDPlant();

        int Code = 0;
        public frmGestionProfils()
        {
            InitializeComponent();
        }
     

        private void btnsave_Click(object sender, EventArgs e)
       {
            model.CodeUtilisateur = Convert.ToInt32(textcodeUtilisateur.Text.Trim());
            model.Nom = textnom.Text.Trim();
            model.Prenom = textprenom.Text.Trim();
            model.Profil = (Profil)comboBoxprofil.SelectedItem;
            model.Etat = comboBoxEtat.Text.Trim();
            model.Password = textpassword.Text.Trim();
            if (Code > 0)
                db.Entry(model).State = EntityState.Modified;
            else
            {
                db.Utilisateurs.Add(model);
            }
          
                db.SaveChanges();
            
        
            
            Clear();
            datagridUtilisateur();
            MessageBox.Show("Enregistrement avec succées");

        }

        private void dataGridUtilisateur_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridUtilisateur.CurrentRow.Index != -1)
            {
                textcodeUtilisateur.Text = dataGridUtilisateur.CurrentRow.Cells["CodeUtilisateur"].Value.ToString();
                 model = db.Utilisateurs.Where(x => x.CodeUtilisateur == Code).FirstOrDefault();
                textnom.Text = dataGridUtilisateur.CurrentRow.Cells["Nom"].Value.ToString();
                textprenom.Text = dataGridUtilisateur.CurrentRow.Cells["Prenom"].Value.ToString();
                txtLogin.Text = dataGridUtilisateur.CurrentRow.Cells["Login"].Value.ToString();
                txtLogin.Enabled = false;
                comboBoxprofil.SelectedText = dataGridUtilisateur.CurrentRow.Cells["Profil"].Value.ToString();

            }
            btnsave.Text = "Modifier";
            btndelete.Enabled = true;
        }
        void datagridUtilisateur()
        {
            dataGridUtilisateur.AutoGenerateColumns = false;
            dataGridUtilisateur.DataSource = db.Utilisateurs.ToList<DAL.Utilisateur>();
        
       }

        private void btndelete_Click(object sender, EventArgs e)
        {
            int codeUti = Convert.ToInt32(textcodeUtilisateur.Text.Trim());
            string log = txtLogin.Text.Trim();
            string nom = textnom.Text.Trim();
            string pren = textprenom.Text.Trim();
            string pass = textpassword.Text.Trim();
            string et = comboBoxEtat.Text.Trim();

            if (MessageBox.Show("Etes-vous sûr de vouloir supprimer cet Utilisateur?", "Supprimer?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Utilisateur u = db.Utilisateurs.ToList<DAL.Utilisateur>().Where(w => w.CodeUtilisateur == codeUti).FirstOrDefault();
                GenericRepository<Utilisateur> uti = new GenericRepository<Utilisateur>(db);
                uti.Delete(u);
            
            db.SaveChanges();
                Clear();
                datagridUtilisateur();
                MessageBox.Show("utilisateur supprimé");
            }


             }
            void Clear()
        {
            textcodeUtilisateur.Text = textnom.Text = comboBoxprofil.Text = textprenom.Text = textpassword.Text = string.Empty; 
            btndelete.Enabled = true;
            btnsave.Text = "Enregistrer";
            Code = 0;
            txtLogin.Enabled = true;

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void frmGestionProfils_Load(object sender, EventArgs e)
        {
            Clear();
            datagridUtilisateur();
            List<Profil> profils = db.Profils.ToList();
            comboBoxprofil.DataSource = profils;
            comboBoxprofil.DisplayMember = "LibelleProfil";
            comboBoxprofil.ValueMember = "CodeProfil";
        }

        private void dataGridUtilisateur_Click(object sender, EventArgs e)
        {
            if (dataGridUtilisateur.CurrentRow.Index != -1)
            {
                textcodeUtilisateur.Text =dataGridUtilisateur.CurrentRow.Cells["CodeUtilisateur"].Value.ToString();
               model = db.Utilisateurs.Where(x => x.CodeUtilisateur == Code).FirstOrDefault();
                textnom.Text = dataGridUtilisateur.CurrentRow.Cells["Nom"].Value.ToString();
                textprenom.Text = dataGridUtilisateur.CurrentRow.Cells["Prenom"].Value.ToString();
                txtLogin.Text = dataGridUtilisateur.CurrentRow.Cells["Login"].Value.ToString();

                txtLogin.Enabled = false;
                
                comboBoxprofil.SelectedIndex = comboBoxprofil.Items.IndexOf(dataGridUtilisateur.CurrentRow.Cells["Profil"].Value.ToString());
                foreach (Profil d in comboBoxprofil.Items)
                {
                    if (d.LibelleProfil == dataGridUtilisateur.CurrentRow.Cells["Profil"].Value.ToString())
                    {
                        comboBoxprofil.SelectedItem = d;
                        break;
                    }
                }

            }
            btnsave.Text = "Modifier";
            btndelete.Enabled = true;
        }

   

     
        
    }
}
