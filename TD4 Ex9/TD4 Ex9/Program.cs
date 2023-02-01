int nbSaisi,resultat;
Console.Write("Veuillez saisir un entier srtictement positif : ");
nbSaisi = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Voici la table de : " + nbSaisi);
for (int i=1;i<=10;i=i+1)
{
    resultat = nbSaisi * i;
    
    Console.WriteLine(i + "x" + nbSaisi + "=" + resultat);
    
}

Console.ReadKey(true);