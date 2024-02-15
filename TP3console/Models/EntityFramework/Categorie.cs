using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace TP3console.Models.EntityFramework
{
    [Table("categorie")]
    public partial class Categorie
    {
        public Categorie()
        {
            Films = new HashSet<Film>();
        }

        // Pour le chargement différé
        //private ILazyLoader _lazyLoader;
        //public Categorie(ILazyLoader lazyLoader)
        //{
        //    _lazyLoader = lazyLoader;
        //}

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("nom")]
        [StringLength(50)]
        public string Nom { get; set; } = null!;
        [Column("description")]
        public string? Description { get; set; }

        // Pour le chargement différé
        //private ICollection<Film> films; //Doit être écrit de la même façon que la property Films mais en minuscule

        //[InverseProperty("CategorieNavigation")]
        //public virtual ICollection<Film> Films
        //{
        //    get {
        //        return _lazyLoader.Load(this, ref films);
        //    }
        //    set { 
        //        films = value; 
        //    }
        //}

        // Chargement explicite
        [InverseProperty("CategorieNavigation")]
        public virtual ICollection<Film> Films { get; set; }

        public override string? ToString()
        {
            return $"ID Catégorie: {this.Id} \nNom de la catégorie: {this.Nom} \nDescription: {this.Description}";
        }
    }
}
