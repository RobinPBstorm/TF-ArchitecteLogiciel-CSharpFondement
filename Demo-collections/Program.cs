
#region tableaux
#region tableaux à 1 dimension
// déclaration de notre tableau d'entier
using System.Collections;
using System.Data;
using System.Diagnostics;

int[] table = new int[5];
// initialisation de la case à l'index 0
table[0] = 5;

for (int i = 0; i < table.Length; i++)
{
    table[i] = i;
}

for (int i = 0; i < table.Length; i++)
{
    Console.Write(table[i]+ " ");
}
Console.WriteLine();

Console.WriteLine(string.Join(',', table));

// /!\ attention au dépassement du tableau
// => out of range exception
//table[5] = 5;
#endregion

#region tableaux à n dimensions (matrice)
string[,] morpionBoard = new string[3, 4];

//[][][]
//[][][]
//[][][]
#endregion

#region tableaux à n dimensions
string[][] chessBoard = new string[8][];

//[][][]
//[]
//[][][][][][][]
// ...

#endregion
#endregion
Console.WriteLine("------------------");
Console.WriteLine("Les ArrayListes-------------");
#region ArrayList
// liste d'objet varié
ArrayList myList = new ArrayList();
myList.Add(5);
myList.Add("Bonjour");

foreach(object o in myList)
{
    Console.WriteLine(o);
}
#endregion
Console.WriteLine("------------------");
Console.WriteLine("Les Listes-------------");
#region List
List<int> myNumbers = new List<int>();
myNumbers.Add(5);

foreach (int i in myNumbers)
{
    Console.WriteLine(i);
}
#endregion

Console.WriteLine("------------------");
Console.WriteLine("Les Hashsets-------------");
#region HashSet
HashSet<int> mySet = new HashSet<int>();
mySet.Add(5);
mySet.Add(5);

// pas de doublon
foreach (int number in mySet)
{
    Console.WriteLine(number);
}
#endregion

Console.WriteLine("------------------");
Console.WriteLine("Les Dictionaries-------------");
#region dictionnary
Dictionary<int, string> myFruits = new Dictionary<int, string>();
myFruits.Add(0, "Banane");
myFruits.Add(5, "Fraise");

// parcourir le dictionnaire au travers de chacune de ses clés
foreach(int key in myFruits.Keys)
{
    Console.WriteLine(myFruits[key]);
}

// est ce que la clé est déjà présente
myFruits.ContainsKey(0);
#endregion

Console.WriteLine("------------------");
Console.WriteLine("Les Queues-------------");
#region Queue (FIFO = First In First Out)
Queue<int> count = new Queue<int>();

// rajouter dans la queue
count.Enqueue(3);
count.Enqueue(2);
count.Enqueue(1);
count.Enqueue(0);

// afficher le prochain élément qui doit sortir
Console.WriteLine(count.Peek());

// resort et retire le premier élément de la queue
//Console.WriteLine(count.Dequeue());
while (count.TryDequeue(out int result))
{
    Console.WriteLine(result);
}
#endregion

Console.WriteLine("------------------");
Console.WriteLine("Les Stacks-------------");
#region Stack (LIFO = Last In First Out)
Stack<string> commands = new Stack<string>();
commands.Push("effacer la ligne");
commands.Push("écrire une nouvelle variable");

// afficher le prochain élément qui doit sortir
Console.WriteLine(commands.Peek());

// resort et retire le dernier élément de la stack
//Console.WriteLine(commands.Pop());
while (commands.TryPop(out string result))
{
    Console.WriteLine(result);
}
#endregion

#region Exercice slide 164
/*Grâce à une boucle « while » et à l’aide d’une collection, calculez les nombres premiers inférieur à un nombre entier entré au clavier.*/


/*Grâce à une boucle « for » et à l’aide d’une collection générique, calculez les x premiers nombres premiers (version optimisée).*/


/*Demandez à l’utilisateur d’introduire deux nombres au clavier et faite l’addition de ces deux nombres en ne convertissant que caractère par 
caractère. (Méthode « ToCharArray() » de la classe « string »).*/


#endregion