int nbSaisi;

Console.Write("Ecrire un entier : ");
nbSaisi = Convert.ToInt32(Console.ReadLine());

for (int i=nbSaisi;i>=0;i=i-1)
    {
    Console.WriteLine(i);
}

Console.ReadKey(true);