// See https://aka.ms/new-console-template for more information
using PizzaShop;
using PizzaShop.Abstraction;
using PizzaShop.Implementation;

Console.WriteLine("Hello, World!");
ICouleur rouge = new Rouge();
ICouleur bleu = new Blue();

Forme cercleRouge = new Cercle(rouge);
Forme carreBleu;
carreBleu = new Carre(bleu);

// Dessiner les formes avec les couleurs respectives
Console.WriteLine(cercleRouge.Dessiner());
Console.WriteLine(carreBleu.Dessiner());