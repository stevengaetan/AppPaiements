using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiements
{
    internal class Utilisateur
    {
        public string Nom { get; set; }
        public List<Paiement> paiements;

        public Utilisateur(string nom)
        {
            Nom = nom;
            paiements = new List<Paiement>();
        }

        public void AfficherInfos()
        {
            Console.WriteLine($"L'utilisateur est : {Nom}");
            foreach (var paiement in paiements)
            {
                paiement.AfficherDetails();
            }
        }

        public void AjouterPaiement(Paiement paiement)
        {
            paiements.Add(paiement);
        }
    }
}
