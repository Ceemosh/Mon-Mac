int choix;

DateTime date = DateTime.Now;

Console.WriteLine("      *** MENU *** \n");

Console.WriteLine("1) Afficher l'heure système \n");

Console.WriteLine("2) Afficher la date système \n");

Console.WriteLine("3) Afficher le mois système \n");

Console.WriteLine("4) Afficher l'année système \n");

Console.Write("Quel est votre choix ? ");

choix = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("============================================ ");

switch (choix)
{
    case 1:
        Console.WriteLine(date.Hour + " heure(s) "+date.Minute+" minutes(s)");
        break;
    case 2:
        Console.WriteLine(date.ToShortDateString()); break;
    case 3:
        Console.WriteLine(date.Month);
        break;
    case 4:
        Console.WriteLine(date.Year);
        break;
    default:
        Console.WriteLine(date);
        break;
}
Console.ReadKey(true);

