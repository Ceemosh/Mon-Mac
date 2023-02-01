string[] jour = new string[] { "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi", "Dimanche" };
int indice;
for(indice=0; indice<7;indice++)
{
    Console.WriteLine(jour[indice]);
    if ((indice==5)||(indice==6))
    {
        Console.WriteLine("C'est le wk");
    }
}
Console.ReadKey(true);