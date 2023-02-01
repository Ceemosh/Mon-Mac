int nbSaisi;

Console.WriteLine("Veuillez saisir un nombre inf à 10");
nbSaisi = Convert.ToInt32(Console.ReadLine());

do
{
    Console.WriteLine("Veuillez saisir un nombre inf à 10");
    nbSaisi = Convert.ToInt32(Console.ReadLine());
}
while (nbSaisi > 10);

Console.WriteLine("Très bien");


Console.ReadKey(true);