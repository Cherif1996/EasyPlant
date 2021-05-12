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
    
    public partial class Fourniseur
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Fourniseur()
        {
            this.FactureConsignes = new HashSet<FactureConsigne>();
        }
    
        public int CodeFouriseur { get; set; }
        public string NomFourniseur { get; set; }
        public Nullable<int> CIN { get; set; }
        public string Ville { get; set; }
        public string Site { get; set; }
        public Nullable<int> CodeBanque { get; set; }
        public string Commercial { get; set; }
        public Nullable<int> TypeClient { get; set; }
        public Nullable<int> Pointdevente { get; set; }
        public string Adresse { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public string RIB { get; set; }
        public string Fax { get; set; }
        public string Responsable { get; set; }
        public string CodeTva { get; set; }
        public Nullable<int> CodePostal { get; set; }
        public string GSM { get; set; }
    
        public virtual Banque Banque { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FactureConsigne> FactureConsignes { get; set; }
        public virtual PointVente PointVente { get; set; }
        public virtual TypeClient TypeClient1 { get; set; }
    }
}