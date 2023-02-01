
using System;

int nbMystere, nbMystere2, resultat;
int nbSaisi;

Random rnd = new Random();
nbMystere = rnd.Next(10);

Random rnd1 = new Random();
nbMystere2 = rnd.Next(10);

resultat = nbMystere * nbMystere2;

Console.WriteLine(nbMystere + "x" + nbMystere2+ "=");
nbSaisi = Convert.ToInt32(Console.ReadLine());

while (nbSaisi!=resultat)
{
    if (nbSaisi == resultat - (1, 10) || nbSaisi == resultat + (1, 10)
    {
        Console.WriteLine("Presque");
        
    }
    else
    {
        Console.WriteLine("CM2");
    }
    nbSaisi = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Très bien");





nbSaisi = Convert.ToInt32(Console.ReadKey());


Console.ReadKey(true);