using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3console.Models.EntityFramework
{
    public class FilmPart
    {
        private int idFilm;
        private int idCategorie;
        private string? titre;
        private string? description;

        public int IdFilm
        {
            get
            {
                return idFilm;
            }

            set
            {
                idFilm = value;
            }
        }

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

        public string? Titre
        {
            get
            {
                return titre;
            }

            set
            {
                titre = value;
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
            return $"ID Film: {this.IdFilm} \nID Catégorie: {this.IdCategorie} \nTitre: {this.Titre} \nDescription: {this.Description}";
        }
    }
}
