int nbSaisi=0, facteur1,facteur2,resultat=0,compteur=0;


do
{
    for (int i=1;i<=3;i=i+1)
    {
        Random generateurAleatoire = new Random();
        facteur1 = generateurAleatoire.Next(2, 11);
        facteur2 = generateurAleatoire.Next(2, 11);

        Console.Write(facteur1 + " x " + facteur2 + " =? ");

        resultat = facteur1 * facteur2;

        nbSaisi = Convert.ToInt32(Console.ReadLine());

        if (nbSaisi != resultat)
        {
            Console.WriteLine("Mauvaise réponse.");
        }
        else
        {
            Console.WriteLine("Bonne réponse");
            compteur++;
        }
    }

} while (compteur<=3);

Console.WriteLine("Bravo vous avez trouvé 3 bonnes réponses. Appuyez sur une touche pour quitter.");


Console.ReadKey(true);