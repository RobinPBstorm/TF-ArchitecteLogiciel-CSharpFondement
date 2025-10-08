using Exo_Fonction_Procedure;

Console.WriteLine("---Exercice1---");
/*Dans les structures Celsius et Fahrenheit, écrire la fonction de conversion de l’une vers l’autre.*/

Celsius T1 = new Celsius(90);

Console.WriteLine($"{T1.Temperature}°C donne {T1.ToFahrenheit().Temperature.ToString("F2")}°F");

Fahrenheit T2 = new Fahrenheit(1);

Console.WriteLine($"{T2.Temperature}°F donne {T2.ToCelsius().Temperature.ToString("F2")}°C");


Console.WriteLine();
Console.WriteLine("---Exercice2---");
/*Ecrire une structure pour résoudre une équation du second degré.
La structure devra contenir :
- Trois variables membres publiques A, B et C de type double.
- Une méthode publique « Resoudre » retournant une valeur de type « bool » stipulant si une réponse a été trouvée et devra retourner également les
valeurs de X1 et de X2 de type double.
- Si aucune solution n’a été trouvée, les valeurs de X1 et de X2 doivent être égale à « null ».*/

SecondDegreeEquation sde = new SecondDegreeEquation(1, 4, 1);

Console.WriteLine($"Pour l'équation {sde.A}X² + {sde.B}X + {sde.C} = 0");

if (sde.Resoudre(out double? x1, out double? x2))
{
    if (x2 is null)
    {
        Console.WriteLine($"Il n'y a qu'une réponse à l'équation: {x1}");
    }
    else
    {
        Console.WriteLine($"Il y a 2 réponses à l'équation: {x1} et {x2}");
    }
}
else
{
    Console.WriteLine("Il n'y a pas de réponse à l'équation");
}