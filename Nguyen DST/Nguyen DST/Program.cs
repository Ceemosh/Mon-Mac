int Retrait, depot, nbSaisi;
Console.WriteLine("Simulation de distributeur de billet");
Console.WriteLine("Votre choix d'opération");
Console.WriteLine("1. Retrait    2. Depot     3. Annuler");
nbSaisi = Convert.ToInt32(Console.ReadLine());

while(nbSaisi==1 || nbSaisi==2 )
{
    if (nbSaisi==1)
    {
        Console.WriteLine("La somme de retrait : ");

        Retrait = Convert.ToInt32(Console.ReadLine());
        while(Retrait>300)
        {
            Console.WriteLine("Vous ne pouvez pas dépasser 300 euros. Saisir une autre somme : ");
            Retrait = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("*************************");
    }

    if (nbSaisi == 2)
    {
        Console.WriteLine("La somme de dépôt : ");
        depot = Convert.ToInt32(Console.ReadLine());
        while(depot>3000)
        {
            Console.WriteLine("Vous ne pouvez pas dépasser 3000 euro, veuillez saisir une autre somme");
            depot = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("*************************");
    }


    Console.WriteLine("1. Retrait    2. Depot     3. Annuler");
    nbSaisi = Convert.ToInt32(Console.ReadLine());


}

Console.ReadKey(true);