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
    
    public partial class ReceptionSemence
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ReceptionSemence()
        {
            this.DetailsCommandes = new HashSet<DetailsCommande>();
        }
    
        public int CodeReceptionSemence { get; set; }
        public int RefCommande { get; set; }
        public int CodeSemence { get; set; }
        public int CodeClient { get; set; }
        public string Note { get; set; }
        public System.DateTime DateReception { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Commande Commande { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetailsCommande> DetailsCommandes { get; set; }
        public virtual Semence Semence { get; set; }
    }
}
