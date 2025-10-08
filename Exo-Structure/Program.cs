using Exo_Structure;

Console.WriteLine("Exercice sur les structures en slides 171");
Console.WriteLine("---Exercice1---");

/*Ecrire une structure pour définir un point possédant deux entier X, Y et créer un tableau deux dimensions de 5 sur 5 de type « Point » (nullable)
et remplir une des diagonales, ensuite à l’aide de deux boucles à l’aide de deux boucles afficher les valeurs dans la console comme suit :
« X: 1 - Y : 1 »
«               X: 2 - Y : 2 »
«                           X: 3 - Y : 3 »
...*/
Point?[,] tab = new Point?[5, 5];

// remplissage
for (int i = 0; i < tab.GetLength(0); i++)
{
    for (int j = 0; j < tab.GetLength(1); j++)
    {
        if (i == j)
        {
            tab[i, j] = new Point(j, i);
        }
        else
        {
            tab[i, j] = null;
        }
    }
}

// affichage
for (int i = 0; i < tab.GetLength(0); i++)
{
    for (int j = 0; j < tab.GetLength(1); j++)
    {
        if (tab[i,j] is null)
        {
            Console.Write("\t\t");
        }
        else
        {
            Console.Write($"X : {tab[i,j]?.X + 1} - Y : {tab[i, j]?.Y + 1}");
        }
    }
    Console.WriteLine();
}

        Console.WriteLine();
Console.WriteLine("---Exercie2---");
/*Ecrire deux structures Celsius et Fahrenheit toutes deux ayant une variable de type double appelée « Temperature »*/

Celsius t1 = new Celsius(20);

Fahrenheit t2 = new Fahrenheit(20);