using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3console.Models.EntityFramework
{
    public partial class Categorie
    {
        public override string? ToString()
        {
            return $"ID Catégorie: {this.Id} \nNom de la catégorie: {this.Nom} \nDescription: {this.Description}";
        }
    }
}
