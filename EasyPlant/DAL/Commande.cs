//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EasyPlant.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Commande
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Commande()
        {
            this.Avances = new HashSet<Avance>();
            this.BonLivraisons = new HashSet<BonLivraison>();
            this.ClotureCommandes = new HashSet<ClotureCommande>();
            this.Productions = new HashSet<Production>();
            this.ReceptionSemences = new HashSet<ReceptionSemence>();
        }
    
        public int RefCommande { get; set; }
        public int CodeClient { get; set; }
        public System.DateTime DateCommande { get; set; }
        public string Note { get; set; }
        public string NomCommercial { get; set; }
        public int CapaciteProd { get; set; }
        public int CodeVariete { get; set; }
        public System.DateTime DateLivraisonPrevu { get; set; }
        public decimal MntBrutHT { get; set; }
        public decimal Remise { get; set; }
        public decimal MntRemise { get; set; }
        public decimal MntNETHT { get; set; }
        public decimal TVA { get; set; }
        public decimal MntNETTTC { get; set; }
        public decimal PrixUnitaire { get; set; }
        public decimal PrixUnitaireNet { get; set; }
        public decimal TotalBrut { get; set; }
        public decimal TotalBrutNet { get; set; }
        public string ReservationCons { get; set; }
        public decimal Accompte { get; set; }
        public decimal Brut { get; set; }
        public decimal Timbre { get; set; }
        public decimal RemiseTot { get; set; }
        public decimal Net { get; set; }
        public int CodeSupport { get; set; }
        public int CodeTypeProd { get; set; }
        public System.DateTime DateCV { get; set; }
        public System.DateTime DateCG { get; set; }
        public System.DateTime DatePG { get; set; }
        public int Qte { get; set; }
        public string TypeCommande { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Avance> Avances { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BonLivraison> BonLivraisons { get; set; }
        public virtual Client Client { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClotureCommande> ClotureCommandes { get; set; }
        public virtual Support Support { get; set; }
        public virtual TypeProduction TypeProduction { get; set; }
        public virtual Variete Variete { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Production> Productions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReceptionSemence> ReceptionSemences { get; set; }
        public string LibelleVariete
        {
            get
            {
                return Variete.LibelleVariete;
            }
        }
        public string libelleSupport
        {
            get
            {
                return Support.Libelle;
            }
        }
        public string LibelleTypeProd
        {
            get
            {
                return TypeProduction.Libelle;
            }
        }
    }
}
