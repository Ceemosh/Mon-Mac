

int note, moyenne=0, resultat;

Console.WriteLine("écrire 5 notes");


for (int i = 1; i <= 5; i = i + 1)
{

    Console.WriteLine("Saisir les note : ");
    note = Convert.ToInt32(Console.ReadLine());
    moyenne = note;

}
resultat = moyenne / 5;


Console.WriteLine("La moyenne est de : " + moyenne);

Console.ReadKey(true);