int nbSaisi=0, nombreMystere;

Console.WriteLine("Le nombre mystère est compris entre 1 et 50");
nombreMystere = new Random().Next(1, 51);
do {

    nbSaisi = Convert.ToInt32(Console.ReadLine());
    

    if (nbSaisi<nombreMystere)
    {
        Console.WriteLine("C'est plus");
    }
    else
    {
        Console.WriteLine("C'est moins");
    }

} while(nbSaisi!=nombreMystere);

Console.WriteLine("Trouvé !");

Console.ReadKey(true);