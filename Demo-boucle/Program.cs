
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
//int[] tab = { 1,2,3,4,5 };
//foreach (int number in tab)
//{
//    Console.WriteLine(number);
//}

//// mots clés
//// break;
//// continue;
int count = 0;
//while (count < 20)
//{
//    Console.WriteLine(count);
//    count++;
//    if (count == 12)
//    {
//        break;
//    }
//}

while (count < 20)
{
    count++;
    if (count == 12)
    {
        continue;
    }
    Console.WriteLine(count);
}

// suite de fiboanacci
// 0 1 0+1=1 1+1=2 2+1=3 3+2=5 8 13 

// factoriel
// 6! = 6 * 5 * 4 * 3 * 2 * 1