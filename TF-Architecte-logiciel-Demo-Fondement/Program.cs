// See https://aka.ms/new-console-template for more information

//Console.WriteLine("Hello, World!");
//string message = Console.ReadLine();

#region variable
//// texte
//string text = "Hello world!";
//char lettre = 'a';

//// nombre
//int entier = 0;
//long grandEntier = 10;

//float nombreFlottant = 5.5F;
//double nombreAVirgule = 5.5D;

//// /!\ dépassement du max des entiers
//entier = int.MaxValue;
//Console.WriteLine(entier + 1);

//uint entierNonSigne = 0;

//bool valeurDeVerite = true;

//const string NOM = "Robin";

//Console.WriteLine(entier.GetType());
//Console.WriteLine(grandEntier.GetType());

///*
// Convention de nommage:
//lowerCamelCase : variable
//UpperCamleCase : class, fonction
//UPPER: constante

//choix nom de variable :
//    en anglais, 
//    sans accent, 
//    sans caractère spéciaux (@), 
//    ne commence pas par un chiffre,
//    sans espace
// */

//// + - * /
//Console.WriteLine(2 + 2);
//// /!\ division entière
//Console.WriteLine(11 / 2);
//Console.WriteLine(2 * 2);
//Console.WriteLine(2 - 2);
//// modulo = reste de la division entière
//Console.WriteLine(11 % 2);
//Console.WriteLine((float)11 / 2);
//// concaténation
//Console.WriteLine("Hello " + "World!");

//// convertir une chaine de caractère en entier
//// /!\ exception si on essaye d
////int number1 = int.Parse(Console.ReadLine());
////int number1 = Convert.ToInt32(Console.ReadLine());

//if (int.TryParse(Console.ReadLine(), out int convertion))
//{
//    Console.WriteLine(convertion / 2);
//}
//Console.WriteLine("fin du programme");

//// varible dynamic déconseillé
//var dynamicVariable = 5;

#endregion

#region construction de texte
//int number = 8;

//// option1: concaténation
//string text1 = "Nous sommes " + number + " en classe";

//// option2: string format
//text1 = string.Format("Nous sommes {0} en classe", number);

//// option3: interpolation
//// $ => interpréter le contenu de la string 
//// pour remplacer les variables par leur valeur
//text1 = $"Nous sommes {number} en classe";

//Console.WriteLine(text1);
#endregion

// /!\ provoque une exception
//int zero = 0;
//int divideResult = 10 / zero;
//Console.WriteLine(divideResult);


#region Exercice slide 104

//// Demander à l’utilisateur d’encoder 2 nombres (int)
//// et d’en faire l’addition,
//// la conversion devra utiliser la méthode « int.Parse() »

//int num1, num2, addition;

//Console.WriteLine("Entrez un premier nombre!");
//num1 = int.Parse(Console.ReadLine());

//Console.WriteLine("Entrez un deuxiéme nombre!");
//num2 = int.Parse(Console.ReadLine());

//addition = num1 + num2;

//Console.WriteLine($"{num1} + {num2} = {addition}");


//// Demander à l’utilisateur d’encoder 2 nombres (int)
//// et d’en faire l’addition,
//// la conversion devra utiliser la méthode « int.TryParse() »

//int num21, num22, addition2;

//Console.WriteLine("Entrez un premier nombre!");
//int.TryParse(Console.ReadLine(), out num21);

//Console.WriteLine("Entrez un deuxiéme nombre!");
//int.TryParse(Console.ReadLine(), out num22);

//addition2 = num21 + num22;

//Console.WriteLine($"{num21} + {num22} = {addition2}");

#endregion

#region conditionnel

// Console.WriteLine("Quel est votre age ?");
// int age = int.Parse(Console.ReadLine());

//// /!\ à l'ordre des conditions
//if (age == 15)
//{
//    Console.WriteLine("Il a 15 ans!");
//}
//else if (age < 18)
//{
//    Console.WriteLine("C'est un mineur!");
//}
//else
//{
//    Console.WriteLine("T'es majeur!");
//}

//// < plus petit
//// <= plus petit ou égal
//// > plus grand
//// >= plus grand ou égal
//// == égalité stricte
//// != différent

//// exemaple de fonction qui renvoit un boolean
//// "Hello world".Contains("e")

//if (((age < 24) ^ (age > 64)))
//{
//    Console.WriteLine("Vous pouvez bénéficier du tarif préférentiel");
//}
//Console.WriteLine(11>>2);

//// || ou
//// && and
//// ^ xor

//int dayOfTheWeek = (int)DateTime.Today.DayOfWeek;
//switch (dayOfTheWeek)
//{
//    case 1:
//        Console.WriteLine("C'est Lundi");
//        break;
//    case 2:
//        Console.WriteLine("Cest Mardi");
//        break;
//    case 3:
//        Console.WriteLine("C'est Mercredi");
//        break;
//    case 4:
//        Console.WriteLine("C'est Jeudi");
//        break;
//    case 5:
//        Console.WriteLine("Cest Vendredi");
//        break;
//    case 6:
//    case 0:
//        Console.WriteLine("C'est le weekend");
//        break;
//    default:
//        Console.WriteLine("Il y a un problème avec la date");
//        break;
//}

//object ageBoxed = age;
//if (ageBoxed is int)
//{

//}
//switch (ageBoxed)
//{
//    case int ageUnboxed:
//        Console.WriteLine("c'est un entier");
//        break;
//}

// la ternaire
// string status = age < 18 ? "mineur" : "majeur";

#endregion

#region Exercice slide 114
/*
 * Demander à l’utilisateur d’encoder 1 nombre (int), 
 * si la somme des deux moitiés de celui-ci donne le nombre, 
 * afficher « le nombre est paire » 
 * sinon « le nombre est impaire ».
 */

int numberExoCondition;

Console.WriteLine("Donnes un nombre entier:");
numberExoCondition = int.Parse(Console.ReadLine());

//if ((numberExoCondition/2) + (numberExoCondition / 2) == numberExoCondition )
if (numberExoCondition % 2 == 0)
{
    Console.WriteLine("le nombre est paire");
}
else
{
    Console.WriteLine("le nombre est impaire");
}

#endregion