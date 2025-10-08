using Demo_Procedure_Fonction;

CoffeeCupStruct myCup = new CoffeeCupStruct(2);

Console.WriteLine($"Le volume de départ est {myCup.volume}");

uint teaVolume = 5;
//myCup.Fill(teaVolume);
//myCup.FillRef(ref teaVolume);
myCup.FillWithOptional(8);

// passer un paramètre spécifique avec son nom
myCup.FillWithOptional(volume: 8);

myCup.FillWithParams(8,5,8);

Console.WriteLine($"Le volume après notre procédure est {myCup.volume}");
Console.WriteLine(myCup.isEmpty() ? "Ma tasse es vide": "Il y a quelque chose dans ma tasse");
Console.WriteLine($"Mon volume est de {teaVolume}");

uint volumeLeft;
if (myCup.TryEmpty(5, out volumeLeft, out string message))
{
    Console.WriteLine(message);
    Console.WriteLine(volumeLeft);
}


