
int nbSaisi, somme = 0;
Console.Write("Veuillez saisir un entier strictement positif : ");
nbSaisi = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= nbSaisi; i = i + 1)
{
    somme = somme + i;
    
    if (nbSaisi >i)
    {
        Console.Write(i+"+");
    }
    else
    {
        Console.Write(i + "=");
    }
    
}
Console.Write(somme);



Console.ReadKey(true);