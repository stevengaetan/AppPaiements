using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiements
{
    internal class Paypal : Paiement
    {
        public string Courriel { get; set; }

        public Paypal(double montant, string description, string courriel)
            : base(montant, description)
        {
            Courriel = courriel;
        }

        public override void AfficherDetails()
        {
            Console.WriteLine($"Le montant est : {Montant}, la description est : {Description}, envoie au courriel : {Courriel}");
        }
    }
}
