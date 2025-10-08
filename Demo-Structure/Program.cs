
using Demo_Structure;

// class
CoffeeCup myCup = new CoffeeCup(1);
// /!\ le constructeur par défaut n'est plus présent
//myCup = new CoffeeCup(); 
// transmission des variables internes par référence
CoffeeCup mySecondCup = myCup;

mySecondCup.volume = 2;

Console.WriteLine("--classe--");
Console.WriteLine($"Le volume de tasse 1 :{myCup.volume} et volume de tasse 2 {mySecondCup}");


// struct
CoffeeCupStruct myCupStruct = new CoffeeCupStruct(1);
// Le constructeur par défaut est toujours présent
myCupStruct = new CoffeeCupStruct();
// transmission des variables internes par copie
CoffeeCupStruct mySecondCupStruct = myCupStruct;

mySecondCupStruct.volume = 2;

Console.WriteLine("--structure--");
Console.WriteLine($"Le volume de tasse 1 :{myCupStruct.volume} et volume de tasse 2 {mySecondCupStruct}");
