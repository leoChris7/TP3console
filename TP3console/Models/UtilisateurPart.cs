using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3console.Models.EntityFramework
{
    public partial class Utilisateur
    {
        public override string? ToString()
        {
            return $"ID Utilisateur: {this.Id} \nLogin: {this.Login} \nEmail: {this.Email} \nMot de passe: {this.Pwd}";
        }
    }
}
