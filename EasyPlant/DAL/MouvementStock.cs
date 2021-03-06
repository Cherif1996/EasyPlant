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
    
    public partial class MouvementStock
    {
        public string RefDocument { get; set; }
        public string CodeDetailsBL { get; set; }
        public int CodeSupport { get; set; }
        public int CodeVariete { get; set; }
        public string CodeClotureProd { get; set; }
        public decimal PrixUnitaire { get; set; }
        public decimal Quantite { get; set; }
        public decimal PrixTotal { get; set; }
        public string TypeMouvement { get; set; }
        public System.DateTime DateMouvement { get; set; }
    
        public virtual ClotureProd ClotureProd { get; set; }
        public virtual DetailsBL DetailsBL { get; set; }
        public virtual Support Support { get; set; }
        public virtual Variete Variete { get; set; }
    }
}
