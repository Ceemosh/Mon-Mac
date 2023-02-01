int choix;
int nbSaisi, resultat;
string reset="oui";
do
{
    Console.WriteLine("1) Calculer le carré d'un nombre");
    Console.WriteLine("2) Calculer le cube d'un nombre");

    do
    {
        Console.WriteLine("Choisissez un chiffre entre 1 et 2");
        choix = Convert.ToInt32(Console.ReadLine());
    } while (choix != 1 && choix != 2);
    switch (choix)
    {

        case 1:
            Console.WriteLine("Entrer un entier : ");
            nbSaisi = Convert.ToInt32(Console.ReadLine());
            resultat = nbSaisi * nbSaisi;
            Console.WriteLine("Le carré est " + resultat);
            break;

        case 2:

            Console.WriteLine("Entrer un entier : ");
            nbSaisi = Convert.ToInt32(Console.ReadLine());
            resultat = nbSaisi * nbSaisi * nbSaisi;
            Console.WriteLine("Le carré est " + resultat);
            break;

    }
    Console.WriteLine("Voulez-vous recommencez");
    reset = Console.ReadLine();
    Console.Clear();
} while (reset == "oui");
Console.ReadKey(true);