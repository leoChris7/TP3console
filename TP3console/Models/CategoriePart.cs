using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3console.Models.EntityFramework
{
    public class CategoriePart
    {
        private int idCategorie;
        private string? nom;
        private string? description;

        public int IdCategorie
        {
            get
            {
                return idCategorie;
            }

            set
            {
                idCategorie = value;
            }
        }

        public string? Nom
        {
            get
            {
                return nom;
            }

            set
            {
                nom = value;
            }
        }

        public string? Description
        {
            get
            {
                return this.description;
            }

            set
            {
                this.description = value;
            }
        }

        public override string? ToString()
        {
            return $"ID Catégorie: {this.IdCategorie} \nNom de la catégorie: {this.Nom} \nDescription: {this.Description}";
        }
    }
}
