int mois;
Console.Write("Entrer le mois SVP  : ");
mois = Convert.ToInt16(Console.ReadLine());
switch(mois)
{
    case 1 :
        Console.WriteLine("Janvier");
        break;
    case 2 :
        Console.WriteLine("Fevrier");
        break;
    case 3 :
        Console.WriteLine("Mars");
        break;
    case 4 :
        Console.WriteLine("Avril");
        break;
}

Console.ReadKey(true);