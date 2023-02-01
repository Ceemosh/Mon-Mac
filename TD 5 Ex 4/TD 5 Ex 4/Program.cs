string mdp,mdpp;

do
{
    Console.Write("Veuillez saisir votre mdp : ");
    mdp = Console.ReadLine();

    Console.Write("Veuillez saisir votre mdp : ");
    mdpp = Console.ReadLine();

    if (mdp != mdpp)
    {
        Console.WriteLine("C'est faux");
    }
}
while (mdp!=mdpp);
Console.WriteLine("Vous avez juste");

Console.ReadKey(true);