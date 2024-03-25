using PizzaShop;
using PizzaShop.Abstraction;
using PizzaShop.Implementation;

namespace UnitTest
{
    [TestClass]
    public class UnitTestClass
    {
        [TestMethod]
        public void TestDessinerCarreBlue()
        {
            ICouleur bleu = new Blue();
            Assert.AreEqual($"Coloriage en bleu", bleu.Remplir());

            Forme carreBleu;
            carreBleu = new Carre(bleu);


            Assert.AreEqual($"Dessin d'un carré. Coloriage en bleu", carreBleu.Dessiner());
        }

        [TestMethod]

        public void TestDessinerِCercleRouge()
        {
            ICouleur rouge = new Rouge();
            Assert.AreEqual($"Coloriage en rouge", rouge.Remplir());

            Forme cercleRouge = new Cercle(rouge);

            Assert.AreEqual($"Dessin d'un cercle. Coloriage en rouge", cercleRouge.Dessiner());
        }
    }
}