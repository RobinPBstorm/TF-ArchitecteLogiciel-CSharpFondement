
using Demo_Enum;

Role role1 = Role.Employe;

Console.WriteLine(role1);
Console.WriteLine((int)role1);

Console.WriteLine();
Console.WriteLine("---Les valeurs de notre enums---");

foreach (string role in Enum.GetNames<Role>())
{
    Console.WriteLine(role);
}

Enum.TryParse<Role>(Console.ReadLine(), out Role result);


Console.WriteLine();
Console.WriteLine("---\"Combinaison d'enum\"---");

Role role2 = Role.AdminSys | Role.Manager;

Console.WriteLine(role2);
Console.WriteLine((int)role2);

// Avec Flags

Vehicule vehicule = Vehicule.Vélo | Vehicule.Voiture;
Console.WriteLine(vehicule);
Console.WriteLine((int)vehicule);
Console.WriteLine(vehicule.HasFlag(Vehicule.Bus));