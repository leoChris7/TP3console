using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3console.Models.EntityFramework
{
    public class AviPart
    {
        private int idFilm;
        private int idUtilisateur;
        private int note;
        private string ?avis;

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

        public int Note
        {
            get
            {
                return note;
            }

            set
            {
                note = value;
            }
        }

        public string? Avis
        {
            get
            {
                return this.avis;
            }

            set
            {
                this.avis = value;
            }
        }

        public override string? ToString()
        {
            return $"ID Film: {this.IdFilm} \nID Utilisateur: {this.IdUtilisateur} \nAvis: {this.Avis} \nNote: {this.Note}";
        }
    }
}
