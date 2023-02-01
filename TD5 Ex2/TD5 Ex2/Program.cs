int nbSaisi;

do
{
    Console.WriteLine("Veuillez saisir un nombre entier qui est compris entre 1 et 10");

    nbSaisi = Convert.ToInt32(Console.ReadLine());
}
while (nbSaisi < 1 || nbSaisi > 10);

Console.WriteLine("Très bien");
Console.ReadKey(true);