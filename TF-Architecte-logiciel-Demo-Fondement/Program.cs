// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
string message = Console.ReadLine();

#region variable
// texte
string text = "Hello world!";
char lettre = 'a';

// nombre
int entier = 0;
float nombreFlottant = 5.5F;
double nombreAVirgule = 5.5D;
long grandEntier = 10;

// /!\ dépassement du max des entiers
entier = int.MaxValue;
Console.WriteLine(entier + 1);

uint entierNonSigne = 1;

bool valeurDeVerite = true;


Console.WriteLine(entier.GetType());
Console.WriteLine(grandEntier.GetType());

/*
 Convention de nammage:
lowerCamelCase : variable
UpperCamleCase : class, fonction

choix nom de variable :
    en anglais, 
    sans accent, 
    sans caractère spéciaux (@), 
    ne commence pas par un chiffre,
    sans espace
 */

// + - * /
Console.WriteLine(2 + 2);
// /!\ division entière
Console.WriteLine(11 / 2);
Console.WriteLine(2 * 2);
Console.WriteLine(2 - 2);
// modulo = reste de la division entière
Console.WriteLine(11 % 2);
Console.WriteLine((float)11 / 2);
// concaténation
Console.WriteLine("Hello " + "World!");

// convertir une chaine de caractère en entier
// /!\ exception si on essaye d
//int number1 = int.Parse(Console.ReadLine());
//int number1 = Convert.ToInt32(Console.ReadLine());

if (int.TryParse(Console.ReadLine(),out int convertion))
{
    Console.WriteLine(convertion/2);
}
Console.WriteLine("fin du programme");

// varible dynamic déconseillé
var dynamicVariable = 5;

#endregion

#region construction de texte
int number = 8;

// option1: concaténation
string text1 = "Nous sommes " + number + " en classe";

// option2: string format
text1 = string.Format("Nous sommes {0} en classe", number);

// option3: interpolation
// $ => interpréter le contenu de la string 
// pour remplacer les variables par leur valeur
text1 = $"Nous sommes {number} en classe";

Console.WriteLine(text1);
#endregion

// /!\ provoque une exception
int zero = 0;
int divideResult = 10 / zero;
Console.WriteLine(divideResult);
