int hauteur;
//int longueur;

Console.WriteLine("Saisir une hauteur");
hauteur = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Saisir une valeure");
//longueur = Convert.ToInt32(Console.ReadLine());

for (int i=1;i<=hauteur;i=i+1)
{

    //for (int boucle2=1;boucle2<=hauteur;boucle2=boucle2+1)
    for (int boucle2 = 1; boucle2 <= i; boucle2 = boucle2 + 1)
    {
        //Console.Write("\t" + "*");
        Console.Write("*");
   
    }
    Console.WriteLine();

}

Console.ReadKey(true);