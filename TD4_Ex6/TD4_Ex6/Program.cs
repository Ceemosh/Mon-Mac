int nbSaisi, nbImpair=1;

Console.Write("saisir un nombre entier : ");
nbSaisi = Convert.ToInt32(Console.ReadLine());

for (int i=1;i <= nbSaisi;i=i+1)
{
    Console.WriteLine(nbImpair);
    nbImpair = nbImpair+2;
}
Console.ReadKey(true);