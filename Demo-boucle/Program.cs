
#region théorie
//// while
//int index = 0;
//while (index < 10)
//{
//    Console.WriteLine(index);
//    index++; // index += 1 ;
//}

//// do while
//string inputUser;
//do
//{
//    Console.WriteLine("Voulez-vous continuer?");
//    inputUser = Console.ReadLine();
//} while (inputUser != "oui" && inputUser != "non");

//// for
//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine($"valeur de i: {i}");
//}

//// foreach

//int[] tab = { 1, 2, 3, 4, 5 };
//foreach (int number in tab)
//{
//    Console.WriteLine(number);
//}

//// mots clés
//// break;
//// continue;
//int count = 0;
//while (count < 20)
//{
//    Console.WriteLine(count);
//    count++;
//    if (count == 12)
//    {
//        break;
//    }
//}

//while (count < 20)
//{
//    count++;
//    if (count == 12)
//    {
//        continue;
//    }
//    Console.WriteLine(count);
//}
#endregion

#region exercice slide 148
/* Calculer les 25 premiers nombres de la suite de Fibonacci */
//int number1 = 0, number2 = 1, temp = 0;
//Console.WriteLine("les 25 premiers nombres de la suite de Fibonacci");

//Console.WriteLine($"0: {number1}");
//Console.WriteLine($"1: {number2}");
//for (int i = 2; i < 25; i++)
//{
//    temp = number1 + number2;
//    number1 = number2;
//    number2 = temp;
//    Console.WriteLine($"{i + 1}: {temp}");
//}

/* Calculer le factoriel d’un nombre entré au clavier.*/
//Console.WriteLine("Donnez vous un nombre et je vous donnerais son factoriel");
//int number3 = int.Parse(Console.ReadLine());
//int number4 = number3;
//int result = 1;
//while (number4 > 0) 
//{
//    result *= number4;
//    number4--;
//}
//Console.WriteLine($"{number3}! = {result}");

/* Grâce à une boucle « for », calculez les x premiers nombre premier.*/
//Console.WriteLine("Combien de nombre premier voulez-vous?");
//int nbPrimeNumber = int.Parse(Console.ReadLine());
//int indexPrimeNumber = 0;


//for (int i = 1; indexPrimeNumber < nbPrimeNumber; i++)
//{
//    bool isPrime = true;

//    for(int j = 2; j*j <= i && isPrime; j++)
//    {
//        if (i % j == 0)
//        {
//            isPrime = false;
//        }
//    }

//    if(isPrime)
//    {
//        Console.WriteLine($"{i} est un nombre premier");
//        indexPrimeNumber++;
//    }
//}

/* A l’aide de boucles « for » afficher les 5 premières tables de multiplication en allant jusque « x20 ».
 1x1 = 1 ; 2x1 = 2; ……
 2x1 = 2; 2x2 = 4; ……*/
//for (int i = 1; i <= 20; i++)
//{
//    for (int j = 1; j <= 5; j++)
//    {
//        Console.Write($"{i} x {j} = {i * j} ;");
//    }
//    Console.WriteLine();
//}

/* À l’aide d’une boucle « for » comptez de 0, à 20,0 en augmentant de 0,1, en utilisant des doubles, et afficher la valeur à chaque itération.
 Remarquez-vous quelque chose de particulier ?*/
//for(double myDouble = 0.0; myDouble < 20.0; myDouble += 0.1)
//{
//    Console.WriteLine(myDouble);
//}

/* Bonus : Calculer la racine carré d’un nombre avec maximum 10 décimales 
 * (Math.Sqrt(x) ne peut être utilisée que pour vérifier la réponse)*/
int startSquare = 5;
double result = 0;
int decimale = 0;

while (decimale < 11 && result * result != startSquare)
{
    if (result * result < startSquare)
    {
        result += 1 / (Math.Pow(10, decimale));
    }
    else if (result * result > startSquare)
    {
        result -= 1 / (Math.Pow(10, decimale));
        decimale++;
    }
}
Console.WriteLine($"{result} est la racine carrée de {startSquare}");
Console.WriteLine($"{Math.Sqrt(startSquare)} est la racine carrée attendue de {startSquare}");
#endregion

Random random = new Random();
int nbRandom = random.Next(10);
