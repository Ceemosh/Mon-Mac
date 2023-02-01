int nbSaisi, reste;
do

{
    Console.WriteLine("Veuillez saisir un entier qui est multiple de 3");
    nbSaisi = Convert.ToInt32(Console.ReadLine());
    reste = nbSaisi % 3;

    if(reste != 0)
    {
        Console.WriteLine("Le reste de la division entière de "+nbSaisi+" par 3 est "+ reste);
        Console.WriteLine("Donc " + nbSaisi + " n'est pas un multiple de 3");

    }
} while (reste != 0);

Console.WriteLine("Le reste de la division entière de " + nbSaisi + " par 3 est " + reste);
Console.WriteLine("Donc " + nbSaisi + " est  un multiple de 3");


Console.ReadKey(true);