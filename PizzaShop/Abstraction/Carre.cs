using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop.Abstraction
{
     public class Carre : Forme
    {
        public Carre(ICouleur couleur) : base(couleur)
        {
        }

        public override string Dessiner()
        {
            return "Dessin d'un carré. " + couleur.Remplir();
        }
    }
}
