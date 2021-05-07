using EasyPlant.Commun;
using EasyPlant.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyPlant
{
    public partial class frmCodeLibelle : Form
    {
        EasyPlant.DAL.Livreur model1 = new EasyPlant.DAL.Livreur();
        EasyPlant.DAL.MoyenTransport model2 = new EasyPlant.DAL.MoyenTransport();
        EasyPlant.DAL.Banque model3 = new EasyPlant.DAL.Banque();
        EasyPlant.DAL.ModeReglement model4 = new EasyPlant.DAL.ModeReglement();
        EasyPlant.DAL.TypeClient model5 = new EasyPlant.DAL.TypeClient();
        EasyPlant.DAL.Famille model6 = new EasyPlant.DAL.Famille();
        EasyPlant.DAL.TypeProduction model7 = new EasyPlant.DAL.TypeProduction();
        EasyPlant.DAL.TypeComptage model8 = new EasyPlant.DAL.TypeComptage();
        EasyPlant.DAL.Colisage model9 = new EasyPlant.DAL.Colisage();
        EasyPlant.DAL.Unite model10 = new EasyPlant.DAL.Unite();
        BDPlant db = new BDPlant();
        int code = 0;
        List<CodeLibelle> listeCodeLibelle = new List<CodeLibelle>();
        public frmCodeLibelle()
        {
            InitializeComponent();
        }

        private void frmCodeLibelle_Load(object sender, EventArgs e)
        {
            Clear();
            listeCodeLibelle = new List<CodeLibelle>();
            LivreurDataGrid.AutoGenerateColumns = false;
            if (LibelleForm.libelle == "Livreur")
            {
                this.Text = "Livreur";
                List<Livreur> listeLivreurs = new List<Livreur>();
                listeLivreurs = db.Livreurs.ToList<DAL.Livreur>();
                listeLivreurs.ForEach(x => listeCodeLibelle.Add(new CodeLibelle { Code = x.CodeLivreur, Libelle = x.Libelle }));
            }
            if (LibelleForm.libelle == "Moyen de Transport")
            {
                List<MoyenTransport> listeTr = new List<MoyenTransport>();
                listeTr = db.MoyenTransports.ToList<DAL.MoyenTransport>();
                listeTr.ForEach(x => listeCodeLibelle.Add(new CodeLibelle { Code = x.CodeMoyenTransport, Libelle = x.Libelle }));
                this.Text = "Moyen de Transport";

            }
            if (LibelleForm.libelle == "Banque")
            {
                this.Text = "Livreur";
                List<Banque> listeBanques = new List<Banque>();
                listeBanques = db.Banques.ToList<DAL.Banque>();
                listeBanques.ForEach(x => listeCodeLibelle.Add(new CodeLibelle { Code = x.CodeBanque, Libelle = x.Libelle }));
                this.Text = "Banque";
            }
            if (LibelleForm.libelle == "Mode de Réglement")
            {
                this.Text = "Mode de Réglement";
                List<ModeReglement> listeModeReg = new List<ModeReglement>();
                listeModeReg = db.ModeReglements.ToList<DAL.ModeReglement>();
                listeModeReg.ForEach(x => listeCodeLibelle.Add(new CodeLibelle { Code = x.CodeModeReg, Libelle = x.Libelle }));
                this.Text = "Mode de Réglement";
            }
            if (LibelleForm.libelle == "Type Client")
            {
                this.Text = "Type Client";
                List<TypeClient> listetypeclient = new List<TypeClient>();
                listetypeclient = db.TypeClients.ToList<DAL.TypeClient>();
                listetypeclient.ForEach(x => listeCodeLibelle.Add(new CodeLibelle { Code = x.CodeTypeClient, Libelle = x.Libelle }));
                this.Text = "Type Client";
            }

            if (LibelleForm.libelle == "Liste Familles")
            {
                this.Text = "Liste Familles";
                List<EasyPlant.DAL.Famille> listefamille = new List<EasyPlant.DAL.Famille>();
                listefamille = db.Familles.ToList<Famille>();
                listefamille.ForEach(x => listeCodeLibelle.Add(new CodeLibelle { Code = x.CodeFamille, Libelle = x.LibelleFamille }));
                this.Text = "Liste Familles";
            }
            if (LibelleForm.libelle == "Type de Production")
            {
                this.Text = "Type de Production";
                List<EasyPlant.DAL.TypeProduction> listeprod = new List<EasyPlant.DAL.TypeProduction>();
                listeprod = db.TypeProductions.ToList<TypeProduction>();
                listeprod.ForEach(x => listeCodeLibelle.Add(new CodeLibelle { Code = x.CodeTypeProd, Libelle = x.Libelle }));
                this.Text = "Type de Production";
            }
            if (LibelleForm.libelle == "Type de Comptage")
            {
                this.Text = "Type de Comptage";
                List<EasyPlant.DAL.TypeComptage> comp = new List<EasyPlant.DAL.TypeComptage>();
                comp = db.TypeComptages.ToList<TypeComptage>();
                comp.ForEach(x => listeCodeLibelle.Add(new CodeLibelle { Code = x.CodeTypeCom, Libelle = x.Libelle }));
                this.Text = "Type de Comptage";
            }
            if (LibelleForm.libelle == "Colisage")
            {
                this.Text = "Colisage";
                List<EasyPlant.DAL.Colisage> col = new List<EasyPlant.DAL.Colisage>();
                col = db.Colisages.ToList<Colisage>();
                col.ForEach(x => listeCodeLibelle.Add(new CodeLibelle { Code = x.CodeColisage, Libelle = x.Libelle }));
                this.Text = "Colisage";
            }
            if (LibelleForm.libelle == "Unité")
            {
                this.Text = "Unité";
                List<EasyPlant.DAL.Unite> col = new List<EasyPlant.DAL.Unite>();
                col = db.Unites.ToList<Unite>();
                col.ForEach(x => listeCodeLibelle.Add(new CodeLibelle { Code = x.CodeUnite, Libelle = x.Libelle }));
                this.Text = "Unité";
            }
            LivreurDataGrid.DataSource = listeCodeLibelle;
            btnModifier.Visible = false;
            btnsave.Visible = true;

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Clear();

        }
        void Clear()
        {
            textcode.Text = textlibelle.Text = string.Empty; ;
            btndelete.Enabled = true;
            btnsave.Text = "Enregistrer";


        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            int codeParametrage = Convert.ToInt32(textcode.Text.Trim());
            string libelle = textlibelle.Text.Trim();
            //
            //Save Livreur 
            // 

            if (LibelleForm.libelle == "Livreur")
            {
                Livreur liv = db.Livreurs.ToList<DAL.Livreur>().Where(w => w.CodeLivreur == codeParametrage).FirstOrDefault();
                if (liv == null)
                {
                    liv = new Livreur { CodeLivreur = codeParametrage, Libelle = libelle };
                    GenericRepository<Livreur> livr = new GenericRepository<Livreur>(db);
                    livr.Insert(liv);
                }
                else
                {
                    MessageBox.Show("Enregistrement existe déjà", codeParametrage.ToString() + " " + libelle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            //
            //Save Moyen de Transport
            //
            if (LibelleForm.libelle == "Moyen de Transport")
            {
                EasyPlant.DAL.MoyenTransport moyenTransport = new EasyPlant.DAL.MoyenTransport { CodeMoyenTransport = codeParametrage, Libelle = libelle };
                GenericRepository<MoyenTransport> GenmoyenTransp = new GenericRepository<MoyenTransport>(db);
                GenmoyenTransp.Insert(moyenTransport);
            }
            //
            //Save Banque
            //
            if (LibelleForm.libelle == "Banque")
            {
                EasyPlant.DAL.Banque banque = new EasyPlant.DAL.Banque { CodeBanque = codeParametrage, Libelle = libelle };
                GenericRepository<Banque> GeneBanque = new GenericRepository<Banque>(db);
                GeneBanque.Insert(banque);
            }
            //
            //Save Mode de Réglement
            //
            if (LibelleForm.libelle == "Mode de Réglement")
            {
                EasyPlant.DAL.ModeReglement modeReglement = new EasyPlant.DAL.ModeReglement { CodeModeReg = codeParametrage, Libelle = libelle };
                GenericRepository<ModeReglement> GenmoyenTransp = new GenericRepository<ModeReglement>(db);
                GenmoyenTransp.Insert(modeReglement);
            }
            //
            //Save Type Client
            //
            if (LibelleForm.libelle == "Type Client")
            {
                EasyPlant.DAL.TypeClient typeclient = new EasyPlant.DAL.TypeClient { CodeTypeClient = codeParametrage, Libelle = libelle };
                GenericRepository<TypeClient> GenmoyenTransp = new GenericRepository<TypeClient>(db);
                GenmoyenTransp.Insert(typeclient);
            }
            //
            //Save Familles
            //
            if (LibelleForm.libelle == "Liste Familles")
            {
                EasyPlant.DAL.Famille famille = new EasyPlant.DAL.Famille { CodeFamille = codeParametrage, LibelleFamille = libelle };
                GenericRepository<EasyPlant.DAL.Famille> fam = new GenericRepository<EasyPlant.DAL.Famille>(db);
                fam.Insert(famille);
            }
            //
            //Save Type production 
            //
            if (LibelleForm.libelle == "Type de Production")
            {
                EasyPlant.DAL.TypeProduction prod = new EasyPlant.DAL.TypeProduction { CodeTypeProd = codeParametrage, Libelle = libelle };
                GenericRepository<EasyPlant.DAL.TypeProduction> prods = new GenericRepository<EasyPlant.DAL.TypeProduction>(db);
                prods.Insert(prod);
            }
            //
            //Save Type Comptage 
            //
            if (LibelleForm.libelle == "Type de Comptage")
            {
                EasyPlant.DAL.TypeComptage typecomp = new EasyPlant.DAL.TypeComptage { CodeTypeCom = codeParametrage, Libelle = libelle };
                GenericRepository<EasyPlant.DAL.TypeComptage> typecomps= new GenericRepository<EasyPlant.DAL.TypeComptage>(db);
                typecomps.Insert(typecomp);
            }
            //
            //Save Colisage
            //
            if (LibelleForm.libelle == "Colisage")
            {
                EasyPlant.DAL.Colisage col= new EasyPlant.DAL.Colisage { CodeColisage = codeParametrage, Libelle = libelle };
                GenericRepository<EasyPlant.DAL.Colisage> cols = new GenericRepository<EasyPlant.DAL.Colisage>(db);
                cols.Insert(col);
            }
            //
            //Save Unité
            //
            if (LibelleForm.libelle == "Unité")
            {
                EasyPlant.DAL.Unite uni= new EasyPlant.DAL.Unite { CodeUnite = codeParametrage, Libelle = libelle };
                GenericRepository<EasyPlant.DAL.Unite> unis = new GenericRepository<EasyPlant.DAL.Unite>(db);
                unis.Insert(uni);
            }
            MessageBox.Show("Enregistrement avec succées");
            Clear();
            frmCodeLibelle_Load(sender, e);

        }


        private void LivreurDataGrid_DoubleClick(object sender, EventArgs e)
        {

            if (LivreurDataGrid.CurrentRow.Index != -1)
            {
                if (LibelleForm.libelle == "Livreur")
                {
                    code = Convert.ToInt32(LivreurDataGrid.CurrentRow.Cells["CodeLivreur"].Value);
                    model1 = db.Livreurs.Where(x => x.CodeLivreur == code).FirstOrDefault();
                    textcode.Text = LivreurDataGrid.CurrentRow.Cells["CodeLivreur"].Value.ToString();
                    textlibelle.Text = model1.Libelle;
                }
                if (LibelleForm.libelle == "Moyen de Transport")
                {
                    code = Convert.ToInt32(LivreurDataGrid.CurrentRow.Cells["CodeLivreur"].Value);
                    model2 = db.MoyenTransports.Where(x => x.CodeMoyenTransport == code).FirstOrDefault();
                    textcode.Text = LivreurDataGrid.CurrentRow.Cells["CodeLivreur"].Value.ToString();
                    textlibelle.Text = model2.Libelle;
                }
                if (LibelleForm.libelle == "Banque")
                {
                    code = Convert.ToInt32(LivreurDataGrid.CurrentRow.Cells["CodeLivreur"].Value);
                    model3 = db.Banques.Where(x => x.CodeBanque == code).FirstOrDefault();
                    textcode.Text = LivreurDataGrid.CurrentRow.Cells["CodeLivreur"].Value.ToString();
                    textlibelle.Text = model3.Libelle;
                }
                if (LibelleForm.libelle == "Mode de Réglement")
                {
                    code = Convert.ToInt32(LivreurDataGrid.CurrentRow.Cells["CodeLivreur"].Value);
                    model4 = db.ModeReglements.Where(x => x.CodeModeReg == code).FirstOrDefault();
                    textcode.Text = LivreurDataGrid.CurrentRow.Cells["CodeLivreur"].Value.ToString();
                    textlibelle.Text = model4.Libelle;
                }
                if (LibelleForm.libelle == "Type Client")
                {
                    code = Convert.ToInt32(LivreurDataGrid.CurrentRow.Cells["CodeLivreur"].Value);
                    model5 = db.TypeClients.Where(x => x.CodeTypeClient == code).FirstOrDefault();
                    textcode.Text = LivreurDataGrid.CurrentRow.Cells["CodeLivreur"].Value.ToString();
                    textlibelle.Text = model5.Libelle;
                }
                if (LibelleForm.libelle == "Liste Familles")
                {
                    code = Convert.ToInt32(LivreurDataGrid.CurrentRow.Cells["CodeLivreur"].Value);
                    model6 = db.Familles.Where(x => x.CodeFamille== code).FirstOrDefault();
                    textcode.Text = LivreurDataGrid.CurrentRow.Cells["CodeLivreur"].Value.ToString();
                    textlibelle.Text = model6.LibelleFamille;
                }
                if (LibelleForm.libelle == "Type de Production")
                {
                    code = Convert.ToInt32(LivreurDataGrid.CurrentRow.Cells["CodeLivreur"].Value);
                    model7 = db.TypeProductions.Where(x => x.CodeTypeProd == code).FirstOrDefault();
                    textcode.Text = LivreurDataGrid.CurrentRow.Cells["CodeLivreur"].Value.ToString();
                    textlibelle.Text = model7.Libelle;
                }
                if (LibelleForm.libelle == "Type de Comptage")
                {
                    code = Convert.ToInt32(LivreurDataGrid.CurrentRow.Cells["CodeLivreur"].Value);
                    model8 = db.TypeComptages.Where(x => x.CodeTypeCom == code).FirstOrDefault();
                    textcode.Text = LivreurDataGrid.CurrentRow.Cells["CodeLivreur"].Value.ToString();
                    textlibelle.Text = model8.Libelle;
                }
                if (LibelleForm.libelle == "Colisage")
                {
                    code = Convert.ToInt32(LivreurDataGrid.CurrentRow.Cells["CodeLivreur"].Value);
                    model9 = db.Colisages.Where(x => x.CodeColisage == code).FirstOrDefault();
                    textcode.Text = LivreurDataGrid.CurrentRow.Cells["CodeLivreur"].Value.ToString();
                    textlibelle.Text = model9.Libelle;
                }
                if (LibelleForm.libelle == "Unité")
                {
                    code = Convert.ToInt32(LivreurDataGrid.CurrentRow.Cells["CodeLivreur"].Value);
                    model10 = db.Unites.Where(x => x.CodeUnite == code).FirstOrDefault();
                    textcode.Text = LivreurDataGrid.CurrentRow.Cells["CodeLivreur"].Value.ToString();
                    textlibelle.Text = model10.Libelle;
                }

            }

            btnsave.Visible = false;
            btnModifier.Visible = true;
            btndelete.Enabled = true;

        }


        private void btndelete_Click(object sender, EventArgs e)
        {
            int codeParametrage = Convert.ToInt32(textcode.Text.Trim());
            string libelle = textlibelle.Text.Trim();
            
            if (MessageBox.Show("Etes-vous sûr de vouloir supprimer ce type?", "Supprimer?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (LibelleForm.libelle == "Livreur")
                {
                    Livreur liv = db.Livreurs.ToList<DAL.Livreur>().Where(w => w.CodeLivreur == codeParametrage).FirstOrDefault();
                    GenericRepository<Livreur> livr = new GenericRepository<Livreur>(db);
                    livr.Delete(liv);
                }


                if (LibelleForm.libelle == "Moyen de Transport")
                {
                    MoyenTransport moy = db.MoyenTransports.ToList<DAL.MoyenTransport>().Where(w => w.CodeMoyenTransport == codeParametrage).FirstOrDefault();
                    GenericRepository<MoyenTransport> moys = new GenericRepository<MoyenTransport>(db);
                    moys.Delete(moy);
                }
                if (LibelleForm.libelle == "Banque")
                {
                    Banque ban = db.Banques.ToList<DAL.Banque>().Where(w => w.CodeBanque == codeParametrage).FirstOrDefault();
                    GenericRepository<Banque> bans = new GenericRepository<Banque>(db);
                    bans.Delete(ban);
                }
                if (LibelleForm.libelle == "Mode de Réglement")
                {
                    ModeReglement mode = db.ModeReglements.ToList<DAL.ModeReglement>().Where(w => w.CodeModeReg == codeParametrage).FirstOrDefault();
                    GenericRepository<ModeReglement> modes = new GenericRepository<ModeReglement>(db);
                    modes.Delete(mode);
                }
                if (LibelleForm.libelle == "Type Client")
                {
                    Client cl = db.Clients.ToList<DAL.Client>().Where(w => w.CodeClient == codeParametrage).FirstOrDefault();
                    GenericRepository<Client> cls = new GenericRepository<Client>(db);
                    cls.Delete(cl);
                }
                if (LibelleForm.libelle == "Liste Familles")
                {
                    Famille famille = db.Familles.ToList<Famille>().Where(w => w.CodeFamille == codeParametrage).FirstOrDefault();
                    GenericRepository<Famille> fam = new GenericRepository<Famille>(db);
                    fam.Insert(famille);
                }
                if (LibelleForm.libelle == "Type de Production")
                {
                    EasyPlant.DAL.TypeProduction prod = db.TypeProductions.ToList<DAL.TypeProduction>().Where(w => w.CodeTypeProd == codeParametrage).FirstOrDefault();
                    GenericRepository<EasyPlant.DAL.TypeProduction> prods = new GenericRepository<EasyPlant.DAL.TypeProduction>(db);
                    prods.Insert(prod);
                }
                if (LibelleForm.libelle == "Type de Comptage")
                {
                    EasyPlant.DAL.TypeComptage typecomp = db.TypeComptages.ToList<DAL.TypeComptage>().Where(w => w.CodeTypeCom == codeParametrage).FirstOrDefault();
                    GenericRepository<EasyPlant.DAL.TypeComptage> typecomps = new GenericRepository<EasyPlant.DAL.TypeComptage>(db);
                    typecomps.Insert(typecomp);
                }
                
                if (LibelleForm.libelle == "Colisage")
                {
                    EasyPlant.DAL.Colisage col = db.Colisages.ToList<DAL.Colisage>().Where(w => w.CodeColisage == codeParametrage).FirstOrDefault();
                    GenericRepository<EasyPlant.DAL.Colisage> cols = new GenericRepository<EasyPlant.DAL.Colisage>(db);
                    cols.Insert(col);
                }
                if (LibelleForm.libelle == "Unité")
                {
                    EasyPlant.DAL.Unite uni = db.Unites.ToList<DAL.Unite>().Where(w => w.CodeUnite == codeParametrage).FirstOrDefault();
                    GenericRepository<EasyPlant.DAL.Unite> unis = new GenericRepository<EasyPlant.DAL.Unite>(db);
                    unis.Insert(uni);
                }

                db.SaveChanges();
                Clear();
                frmCodeLibelle_Load(sender, e);
                MessageBox.Show("Suppresion avec succées");
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int codeParametrage = Convert.ToInt32(textcode.Text.Trim());
            string libelle = textlibelle.Text.Trim();
            //
            // Modifier Livreur 
            //
            if (LibelleForm.libelle == "Livreur")
            {
                Livreur liv = db.Livreurs.ToList<DAL.Livreur>().Where(w => w.CodeLivreur == codeParametrage).FirstOrDefault();
                if (liv == null)
                {
                    MessageBox.Show("Enregistrement n'existe pas", codeParametrage.ToString() + " " + libelle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    liv.Libelle = libelle;
                    GenericRepository<Livreur> livr = new GenericRepository<Livreur>(db);
                    livr.Update(liv);
                    MessageBox.Show("Enregistrement modifié avec succès", codeParametrage.ToString() + " " + libelle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            //
            //Modifier Moyen de Transport
            //
            if (LibelleForm.libelle == "Moyen de Transport")
            {
                MoyenTransport moy = db.MoyenTransports.ToList<DAL.MoyenTransport>().Where(w => w.CodeMoyenTransport == codeParametrage).FirstOrDefault();
                if (moy == null)
                {
                    MessageBox.Show("Enregistrement n'existe pas", codeParametrage.ToString() + " " + libelle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    moy.Libelle = libelle;
                    GenericRepository<MoyenTransport> Moys = new GenericRepository<MoyenTransport>(db);
                    Moys.Update(moy);
                    MessageBox.Show("Enregistrement modifié avec succès", codeParametrage.ToString() + " " + libelle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            //
            //Modifier Banque
            //

            if (LibelleForm.libelle == "Banque")
                {
                   Banque ban = db.Banques.ToList<DAL.Banque>().Where(w => w.CodeBanque == codeParametrage).FirstOrDefault();
                    if (ban == null)
                    {
                        MessageBox.Show("Enregistrementn'existe pas", codeParametrage.ToString() + " " + libelle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        ban.Libelle = libelle;
                        GenericRepository<Banque> banques = new GenericRepository<Banque>(db);
                        banques.Update(ban);
                        MessageBox.Show("Enregistrement modifié avec succès", codeParametrage.ToString() + " " + libelle, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
            }
            //
            //Modifier Mode de Réglements
            //
            if (LibelleForm.libelle == "Mode de Réglement")
            {
                ModeReglement mode = db.ModeReglements.ToList<DAL.ModeReglement>().Where(w => w.CodeModeReg == codeParametrage).FirstOrDefault();
                if (mode == null)
                {
                    MessageBox.Show("Enregistrement n'existe pas", codeParametrage.ToString() + " " + libelle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    mode.Libelle = libelle;
                    GenericRepository<ModeReglement> modeReg = new GenericRepository<ModeReglement>(db);
                    modeReg.Update(mode);
                    MessageBox.Show("Enregistrement modifié avec succès", codeParametrage.ToString() + " " + libelle, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            //
            //Modifier Type Client
            //
            if (LibelleForm.libelle == "Type Client")
            {
                TypeClient typeCL = db.TypeClients.ToList<DAL.TypeClient>().Where(w => w.CodeTypeClient == codeParametrage).FirstOrDefault();
                if (typeCL == null)
                {
                    MessageBox.Show("Enregistrement n'existe pas", codeParametrage.ToString() + " " + libelle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    typeCL.Libelle = libelle;
                    GenericRepository<TypeClient> typeClient = new GenericRepository<TypeClient>(db);
                    typeClient.Update(typeCL);
                    MessageBox.Show("Enregistrement modifié avec succès", codeParametrage.ToString() + " " + libelle, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            //
            //Modifier Familles
            //
            if (LibelleForm.libelle == "Liste Familles")
            {
                Famille fam = db.Familles.ToList<DAL.Famille>().Where(w => w.CodeFamille == codeParametrage).FirstOrDefault();
                if (fam == null)
                {
                    MessageBox.Show("Enregistrement n'existe pas", codeParametrage.ToString() + " " + libelle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    fam.LibelleFamille = libelle;
                    GenericRepository<Famille> fams = new GenericRepository<Famille>(db);
                    fams.Update(fam);
                    MessageBox.Show("Enregistrement modifié avec succès", codeParametrage.ToString() + " " + libelle, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            //
            //Modifier Type production
            //
            if (LibelleForm.libelle == "Type de Production")
            {
                TypeProduction pro = db.TypeProductions.ToList<DAL.TypeProduction>().Where(w => w.CodeTypeProd == codeParametrage).FirstOrDefault();
                if (pro == null)
                {
                    MessageBox.Show("Enregistrement n'existe pas", codeParametrage.ToString() + " " + libelle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    pro.Libelle = libelle;
                    GenericRepository<TypeProduction> typeprod = new GenericRepository<TypeProduction>(db);
                    typeprod.Update(pro);
                    MessageBox.Show("Enregistrement modifié avec succès", codeParametrage.ToString() + " " + libelle, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            //
            //Modifier Type Comptage
            //
            if (LibelleForm.libelle == "Type de Comptage")
            {
                TypeComptage com = db.TypeComptages.ToList<DAL.TypeComptage>().Where(w => w.CodeTypeCom == codeParametrage).FirstOrDefault();
                if (com== null)
                {
                    MessageBox.Show("Enregistrement n'existe pas", codeParametrage.ToString() + " " + libelle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    com.Libelle = libelle;
                    GenericRepository<TypeComptage> typecom = new GenericRepository<TypeComptage>(db);
                    typecom.Update(com);
                    MessageBox.Show("Enregistrement modifié avec succès", codeParametrage.ToString() + " " + libelle, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            //
            //Modifier Colisage
            //
            if (LibelleForm.libelle == "Colisage")
            {
                Colisage col = db.Colisages.ToList<DAL.Colisage>().Where(w => w.CodeColisage == codeParametrage).FirstOrDefault();
                if (col == null)
                {
                    MessageBox.Show("Enregistrement n'existe pas", codeParametrage.ToString() + " " + libelle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    col.Libelle = libelle;
                    GenericRepository<Colisage> cols= new GenericRepository<Colisage>(db);
                    cols.Update(col);
                    MessageBox.Show("Enregistrement modifié avec succès", codeParametrage.ToString() + " " + libelle, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            //
            //Modifier Unité
            //
            if (LibelleForm.libelle == "Unité")
            {
               Unite uni = db.Unites.ToList<DAL.Unite>().Where(w => w.CodeUnite == codeParametrage).FirstOrDefault();
                if (uni == null)
                {
                    MessageBox.Show("Enregistrement n'existe pas", codeParametrage.ToString() + " " + libelle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    uni.Libelle = libelle;
                    GenericRepository<Unite> unis = new GenericRepository<Unite>(db);
                    unis.Update(uni);
                    MessageBox.Show("Enregistrement modifié avec succès", codeParametrage.ToString() + " " + libelle, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            Clear();
            frmCodeLibelle_Load(sender, e);
            }
        }
    }


