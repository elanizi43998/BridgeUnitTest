using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShop.Abstraction
{
    public  abstract  class Forme
    {
        protected ICouleur couleur;

        protected Forme(ICouleur couleur)
        {
            this.couleur = couleur;
        }

        public abstract string Dessiner();
    }
}
