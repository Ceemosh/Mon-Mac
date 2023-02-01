         int nbSaisi = 0, reste = 0;

        Console.Write("Veuillez saisir un entier strictement posistif : ");
        nbSaisi = Convert.ToInt32(Console.ReadLine());
reste = nbSaisi % nbSaisi;
for (int i = 1; i <= reste; i = i + 1)
        {
            
            Console.WriteLine("Les diviseurs de " + nbSaisi + "sont : " + reste);

        }

        Console.ReadKey(true);
