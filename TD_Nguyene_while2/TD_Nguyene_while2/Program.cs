int nbSaisi, nbMystere;

Random rnd = new Random();
nbMystere = rnd.Next(1,10);

Console.WriteLine("J'ai choisi un nombr enetre 1 et 100");

Console.Write("une Proposition :");
nbSaisi = Convert.ToInt32(Console.ReadLine());

//nbSaisi=nbMystere;

while (nbSaisi != nbMystere)
{
    /*
    if (nbSaisi == nbMystere - 1 || nbSaisi == nbMystere + 1)
    {
        Console.WriteLine("Presque");

    }*/
    Console.Write("une Proposition :");

    nbSaisi = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Très bien");
Console.ReadKey(true);




