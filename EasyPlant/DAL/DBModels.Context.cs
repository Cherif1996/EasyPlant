﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BDPlant : DbContext
    {
        public BDPlant()
            : base("name=BDPlant")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Avance> Avances { get; set; }
        public virtual DbSet<Banque> Banques { get; set; }
        public virtual DbSet<BonLivraison> BonLivraisons { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<ClotureCommande> ClotureCommandes { get; set; }
        public virtual DbSet<ClotureProd> ClotureProds { get; set; }
        public virtual DbSet<Colisage> Colisages { get; set; }
        public virtual DbSet<Commande> Commandes { get; set; }
        public virtual DbSet<Comptage> Comptages { get; set; }
        public virtual DbSet<DetailsBL> DetailsBLs { get; set; }
        public virtual DbSet<DetailsCommande> DetailsCommandes { get; set; }
        public virtual DbSet<Emplacement> Emplacements { get; set; }
        public virtual DbSet<Espece> Especes { get; set; }
        public virtual DbSet<Famille> Familles { get; set; }
        public virtual DbSet<Livreur> Livreurs { get; set; }
        public virtual DbSet<ModeReglement> ModeReglements { get; set; }
        public virtual DbSet<MouvementStock> MouvementStocks { get; set; }
        public virtual DbSet<MoyenTransport> MoyenTransports { get; set; }
        public virtual DbSet<PointVente> PointVentes { get; set; }
        public virtual DbSet<Production> Productions { get; set; }
        public virtual DbSet<ReceptionSemence> ReceptionSemences { get; set; }
        public virtual DbSet<Semence> Semences { get; set; }
        public virtual DbSet<Semencier> Semenciers { get; set; }
        public virtual DbSet<Serre> Serres { get; set; }
        public virtual DbSet<Support> Supports { get; set; }
        public virtual DbSet<TypeClient> TypeClients { get; set; }
        public virtual DbSet<TypeComptage> TypeComptages { get; set; }
        public virtual DbSet<TypeProduction> TypeProductions { get; set; }
        public virtual DbSet<Unite> Unites { get; set; }
        public virtual DbSet<Utilisateur> Utilisateurs { get; set; }
        public virtual DbSet<Variete> Varietes { get; set; }
    }
}
