using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop.Abstraction
{
    public class Cercle : Forme
    {
        public Cercle(ICouleur couleur) : base(couleur)
        {
        }

        public override string Dessiner()
        {
            return "Dessin d'un cercle. " + couleur.Remplir();
        }
    }
}
