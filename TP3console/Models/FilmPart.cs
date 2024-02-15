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
        private int id;
        private string? nom;
        private string? description;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
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

        //public ICollection<Avi>? Avis { get => avis; set => avis = value; }

        public override string? ToString()
        {
            return $"ID Film: {this.Id} \nNom: {this.Nom} \nDescription: {this.Description}";
        }
    }
}
