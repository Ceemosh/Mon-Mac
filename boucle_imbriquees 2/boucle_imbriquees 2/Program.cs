
int hauteur;


Console.Write("Saisir une hauteur");

hauteur = Convert.ToInt32(Console.ReadLine());



for (int i = 1; i <= hauteur; i = i + 1)
{


    for (int boucle2 = 1; boucle2 <= i; boucle2 = boucle2 + 1)
    {

        for (int boucle3 = 1; boucle3 <= i; boucle3 = boucle3 + 1)
        {

            Console.Write("\n"+"*");
        }

        Console.WriteLine();
    }
    Console.WriteLine();

}

Console.ReadKey(true);



Console.Write("*");