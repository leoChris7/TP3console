using TP3console.Models.EntityFramework;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace TP3console
{
    // Installation du Logger:  Microsoft.Extensions.Logging.Console
    class Program
    {
        /// <summary>
        /// Chargement explicite : conseillé
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Exo2Q7();
            Console.ReadKey();
        }
    
        public static void Exo2Q2()
        {
            var ctx = new FilmsDBContext();
            foreach (var utilisateur in ctx.Utilisateurs)
            {
                Console.WriteLine(utilisateur.Email);
            }
        }

        public static void Exo2Q3()
        {
            var ctx = new FilmsDBContext();
            foreach (var utilisateur in ctx.Utilisateurs.OrderBy(utilisateur => utilisateur.Login))
            {
                Console.WriteLine(utilisateur.Login);
            }
        }

        public static void Exo2Q4()
        {
            var ctx = new FilmsDBContext();
            Categorie categorieAction = ctx.Categories.First(c => c.Nom == "Action");
            Console.WriteLine("Categorie : " + categorieAction.Nom);
            //Chargement des films dans categorieAction
            ctx.Entry(categorieAction).Collection(c => c.Films).Load();
            Console.WriteLine("Films : ");
            foreach (var film in categorieAction.Films)
            {
                Console.WriteLine("Nom : " + film.Nom + " id: "+ film.Id);
            }
        }

        public static void Exo2Q5()
        {
            var ctx = new FilmsDBContext();
            Console.WriteLine("Nombre de catégories: " + ctx.Categories.Count());
        }

        public static void Exo2Q6()
        {
            var ctx = new FilmsDBContext();
            Console.WriteLine("Note la plus basse: " + ctx.Avis.Min(Avis=>Avis.Note));
        }

        public static void Exo2Q7()
        {
            var ctx = new FilmsDBContext();
            Console.WriteLine("Films : ");
            foreach (var film in ctx.Films.Where(x => x.Nom.StartsWith("le")))
            {
                Console.WriteLine(film.Nom);
            }
        }

        static void MainChargementExplicite(string[] args)
        {
            using (var ctx = new FilmsDBContext())
            {
                Categorie categorieAction = ctx.Categories.First(c => c.Nom == "Action");
                Console.WriteLine("Categorie : " + categorieAction.Nom);
                //Chargement des films dans categorieAction
                ctx.Entry(categorieAction).Collection(c => c.Films).Load();
                Console.WriteLine("Films : ");
                foreach (var film in categorieAction.Films)
                {
                    Console.WriteLine(film.Nom);
                }
            }
        }
        static void MainChargementDifféré(string[] args)
        {
            // Installation de l'extension nugget: Microsoft.EntityFrameworkCore.Proxies
            using (var ctx = new FilmsDBContext())
            {
                //Chargement de la catégorie Action
                Categorie categorieAction = ctx.Categories.First(c => c.Nom == "Action");
                Console.WriteLine("Categorie : " + categorieAction.Nom);
                Console.WriteLine("Films : ");
                //Chargement des films de la catégorie Action.
                foreach (var film in categorieAction.Films) // lazy loading initiated
                {
                    Console.WriteLine(film.Nom);
                }
            }
        }

        static void MainChargementHatif(string[] args)
        {
            using (var ctx = new FilmsDBContext())
            {
                //Chargement de la catégorie Action et des films de cette catégorie
                Categorie categorieAction = ctx.Categories
                                            .Include(c => c.Films)
                                            .First(c => c.Nom == "Action");
                Console.WriteLine("Categorie : " + categorieAction.Nom);
                Console.WriteLine("Films : ");
                foreach (var film in categorieAction.Films)
                {
                    Console.WriteLine(film.Nom);
                }
            }
        }



        static void MainChargements_Films(string[] args)
        {
            using (var ctx = new FilmsDBContext())
            {
                // Chargement de la catégorie Action
                Categorie categorieAction = ctx.Categories.First(c => c.Nom == "Action");
                Console.WriteLine("Categorie: " + categorieAction.Nom);
                Console.WriteLine("Films :");

                // Chargement des films de la catégorie Action.
                foreach (var film in ctx.Films.Where(f => f.CategorieNavigation.Nom == categorieAction.Nom).ToList())
                {
                    Console.WriteLine(film.Nom);
                }
            }
        }

        // Remplacer MainTitanic par main pour qu'il soit executé au démarrage.
        static void MainTitanic(string[] args)
        {
            using (var ctx = new FilmsDBContext())
            {
                // Désactivation du tracking => Aucun changement dans la base ne sera effectué.
                //ctx.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
                // ou ctx.AsNoTracking(); : à utiliser pour chaque requête comme ctx.Films.AsNoTracking.First(...

                // Requête SELECT
                Film titanic = ctx.Films.First(f => f.Nom.Contains("Titanic"));

                // Modification de l'entité (dans le contexte seulement)
                titanic.Description = $"Un bateau échoué. Date: {DateTime.Now}";

                // Sauvegarde du contexte => Application de la modification dans la BD
                int nbchanges = ctx.SaveChanges();

                Console.WriteLine("Nombre d'enregistrements modifiés ou ajoutés: " + nbchanges);
            }
            Console.ReadKey();
        }
    }
}