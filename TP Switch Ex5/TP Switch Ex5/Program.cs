int age=6;
Console.Write("Entrer l'âge : ");
age = Convert.ToInt32(Console.ReadLine());
switch (age)
{
    case 6:
    case 7:
    Console.WriteLine("Poussin");
    break;
    case 8:
    case 9:
    Console.WriteLine("Pupille");
    break;

    case 10:
    case 11:
        Console.WriteLine("Minime");
        break;
    case 12:
    case 18:
    Console.WriteLine("Cadet");
    break;

    default:
    Console.WriteLine("Non concerné");
        break;
}

Console.ReadKey(true);
    