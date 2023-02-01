int nbSaisi,puissance=1;

Console.Write("Veuillez saisir un entier strictement positif : ");
nbSaisi = Convert.ToInt32(Console.ReadLine());



for (int i=1;i<=nbSaisi;i=i+1)
{
    puissance = puissance * 2;

    Console.WriteLine(puissance);
}


Console.ReadKey(true);