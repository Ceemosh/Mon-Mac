int nbSaisi,somme=0;
Console.Write("Veuillez saisir un entier strictement positif : ");
nbSaisi = Convert.ToInt32(Console.ReadLine());
for(int i=1;i<=nbSaisi;i=i+1)
{
    somme = somme + i;
}
Console.WriteLine("La somme des entiers compris entre 1 et " + nbSaisi + " est égale à " + somme);


Console.ReadKey(true);