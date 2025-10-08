

#region Exercice slide 164
Console.WriteLine("---Exercice1---");
/*Grâce à une boucle « while » et à l’aide d’une collection, calculez les nombres premiers inférieur à un nombre entier entré au clavier.*/
Console.WriteLine("Donnez un nombre et je vous donnerais les nombres premiers inférieures");
int maxNumber = int.Parse(Console.ReadLine());

List<int> primeNumbers = new List<int>();
int currentNumber = 2;

while (currentNumber < maxNumber)
{
    bool isPrime = true;
    for (int i = 0; i < primeNumbers.Count(); i++)
    {
        if (currentNumber % primeNumbers[i] == 0)
        {
            isPrime = false;
        }
    }

    if (isPrime)
    {
        primeNumbers.Add(currentNumber);
    }
    currentNumber++;
}

foreach (int number in primeNumbers)
{
    Console.WriteLine(number);
}

Console.WriteLine();
Console.WriteLine("---Exercice2---");

/*Grâce à une boucle « for » et à l’aide d’une collection générique, calculez les x premiers nombres premiers (version optimisée).*/
Console.WriteLine("Combien de nombre premier voulez-vous?");
int nbPrimeNumber = int.Parse(Console.ReadLine());

List<int> primeNumbers2 = new List<int>();

for (int nb = 2; primeNumbers2.Count() < nbPrimeNumber; nb++)
{
    bool isPrime = true;
    for (int i = 0; i < primeNumbers2.Count(); i++)
    {
        if (nb % primeNumbers2[i] == 0)
        {
            isPrime = false;
        }
    }

    if (isPrime)
    {
        primeNumbers2.Add(nb);
    }
}

foreach (int number in primeNumbers2)
{
    Console.WriteLine(number);
}

Console.WriteLine();
Console.WriteLine("---Exercice3---");

/*Demandez à l’utilisateur d’introduire deux nombres au clavier et faite l’addition de ces deux nombres en ne convertissant que caractère par 
caractère. (Méthode « ToCharArray() » de la classe « string »).*/
Console.WriteLine("Proposez moi 2 nombres");
Console.WriteLine("nombre1: ");
string number1 = Console.ReadLine();

Console.WriteLine("nombre2: ");
string number2 = Console.ReadLine();

string result = "";
int retenu = 0;

for(int i = 0; i < number1.ToCharArray().Length || i < number2.ToCharArray().Length || retenu > 0; i++)
{
    char digit1 = i < number1.ToCharArray().Length ?
        number1.ToCharArray()[number1.ToCharArray().Length - 1 - i] :
        '0';
    char digit2 = i < number2.ToCharArray().Length ?
        number2.ToCharArray()[number2.ToCharArray().Length - 1 - i] :
        '0';

    int temp = int.Parse(digit1.ToString()) +
        int.Parse(digit2.ToString()) +
        retenu;
    retenu = 0;

    if (temp > 9)
    {
        retenu = 1;
        temp -= 10;
    }
    result = temp.ToString() + result;


}
Console.WriteLine(result);
#endregion