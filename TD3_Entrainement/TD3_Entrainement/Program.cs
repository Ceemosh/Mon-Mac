using System;

int heure;
string jour;

Console.WriteLine("Veuillez entrer une heure");
heure = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Veuillez entrer une heure");
jour = Console.ReadLine();

if (jour == "mardi" || jour =="mercredi" && heure >= 9 && heure <= 12 || heure >= 14 && heure <= 17)
{
    Console.WriteLine("Open");
}
else
{
    Console.WriteLine("Cloose");
}

Console.ReadKey(true);