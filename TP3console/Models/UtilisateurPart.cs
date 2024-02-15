using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3console.Models.EntityFramework
{
    public class UtilisateurPart
    {
        private int idUtilisateur;
        private string? login;
        private string? email;
        private string? pwd;

        public int IdUtilisateur
        {
            get
            {
                return idUtilisateur;
            }

            set
            {
                idUtilisateur = value;
            }
        }

        public string? Login
        {
            get
            {
                return login;
            }

            set
            {
                login = value;
            }
        }

        public string? Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string? Pwd
        {
            get
            {
                return this.pwd;
            }

            set
            {
                this.pwd = value;
            }
        }

        public override string? ToString()
        {
            return $"ID Utilisateur: {this.IdUtilisateur} \nLogin: {this.Login} \nEmail: {this.Email} \nMot de passe: {this.Pwd}";
        }
    }
}
