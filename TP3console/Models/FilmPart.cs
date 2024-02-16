using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3console.Models.EntityFramework
{
    public partial class Film
    {
        public override string? ToString()
        {
            return $"ID Film: {this.Id} \nNom: {this.Nom} \nDescription: {this.Description}";
        }
    }
}
