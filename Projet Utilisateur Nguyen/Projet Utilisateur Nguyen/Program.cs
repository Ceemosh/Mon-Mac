using System;

string mdp;
string user;

int nbUser = 3;
int nbMdp = 3;
string[] noms = new string;
string[] mdpp = new string[nbMdp];

for (int i = 0; i < 3; i++)
{
    Console.Write("Entrez un nom d'utilisateur : ");
    user = Console.ReadLine();
    if (user == "albert" || user == "carole" || user == "brigitte")
    {
        Console.WriteLine("Entrez un mot de passe :");
        mdp = Console.ReadLine();
        if (user == "albert" && mdp == "bb123")
        {
            Console.WriteLine("Bienvenue!");
        }
        else if (user == "carole" && mdp == "bb123")
        {
            Console.WriteLine("Bienvenue !");
        }
        else if (user == "brigitte" && mdp == "cc123")
        {
            Console.WriteLine("Bienvenue !");
        }
    }
    else
    {
        Console.WriteLine("Utilisateur inconnu");
    }
}

onsole.ReadKey(true);