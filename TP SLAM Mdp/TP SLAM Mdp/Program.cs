string jour, reponse;
double heure;
do
{
    Console.Write("Entrer le jour : ");
    jour = Console.ReadLine();
    if (jour == "lundi")
        Console.WriteLine("Fermé");
    else
    {
        Console.Write("Entrer l'heure : ");
        heure = Convert.ToDouble(Console.ReadLine());
        if (jour == "dimanche")
        {
            if (heure >= 7 && heure <= 13)
                Console.WriteLine("Ouvert");
            else
                Console.WriteLine("Fermé");
        }
        else
        {
            if (heure >= 7 && heure <= 20)
                Console.WriteLine("Ouvert");
            else
                Console.WriteLine("Fermé");
        }
    }
    Console.Write("Voulez-vous recommencer ? ");
    reponse = Console.ReadLine();
} while (reponse == "oui");