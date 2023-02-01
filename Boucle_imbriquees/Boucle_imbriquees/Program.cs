int nbSaisi;
int resultat;

Console.Write("Ecrire une valeur");
nbSaisi = Convert.ToInt32(Console.ReadLine());

for (int boucle1=1; boucle1<=10;boucle1++)
{
    for (int boucle2=1;boucle2<=nbSaisi; boucle2++)
    {
        resultat = boucle1 * boucle2;
        Console.Write("\t"+boucle1+"*"+boucle2+"="+resultat); // /t tabulation
    }
    Console.WriteLine();
}

Console.ReadKey(true);