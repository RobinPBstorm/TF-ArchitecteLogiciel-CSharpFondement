/*Créer une énumération pour les couleurs (Coeur, Carreau, Pique, Trefle)*/
/*Créer une énumération pour les valeurs (as = 14, deux = 2, trois = 3, ..., Roi = 13)*/
/*Créer une structure Carte qui contient deux variables publiques :*/
/*Couleur de type Couleurs*/
/*Valeur de type Valeurs*/
/*Déclarer un tableau de Carte d'une taille de 52*/
/*À l'aide d'une boucle « foreach » définir les couleurs et les valeurs de chacune des cartes*/
/*Afficher les cartes (Définir si cela fonctionne : si oui pourquoi, sinon pourquoi)*/

using Exo_Enum.Models;

Card[] deck = new Card[52];

// /!\ Ne fonctionera pas
//foreach(Card card in deck)
//{
//    ...
//}

int i = 0;
foreach(Value value in Enum.GetValues<Value>())
{
    foreach(Color color in Enum.GetValues<Color>())
    {
        deck[i] = new Card(color, value);
        i++;
    }
}

//foreach (Card card in deck)
//{
//    Console.WriteLine($"{card.Value} {card.Color}");
//}

Deck deck2 = new Deck();
foreach (Card card in deck2.Cards)
{
    Console.WriteLine($"{card.Value} {card.Color}");
}