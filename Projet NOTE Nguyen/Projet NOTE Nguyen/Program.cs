using System;

int nbMax = 30; //le nombre max des éléments
string[] noms = new string[nbMax];
double[] notes = new double[nbMax];

// les données pour les stat.

double moyenne = 0;
double noteMin = 0;
double noteMax = 0;
double noteEcart = 0;
double noteSomme = 0;
int nbEffectif = 0;

// les saisies
string res = "oui";
while (res == "oui" && nbEffectif < nbMax)
{
    Console.WriteLine("Nom de l'élève (no" + (nbEffectif + 1) + ") : ");
    noms[nbEffectif] = Console.ReadLine();
    Console.WriteLine("Note");
    notes[nbEffectif] = Convert.ToDouble(Console.ReadLine());
    nbEffectif++;
    Console.WriteLine("Continuez ? (oui/non) : ");
    res = Console.ReadLine();
    Console.WriteLine("******************************");

}


//les stat.

Console.WriteLine();
Console.WriteLine("---------------Les résultats-------------------");
//moyenne & noteMin & noteMax

noteMin = notes[0];
noteMax = notes[0];

for (int i = 0; i < nbEffectif; i++) 
{
    noteSomme = noteSomme + notes[i];
    if (notes[i] > noteMax)
    {
        noteMax = notes[i];
    }
    if (notes[i] < noteMin)
    {
        noteMin = notes[i];
    }
}

moyenne = noteSomme / nbEffectif;
noteEcart = noteMax - noteMin;
Console.WriteLine("La moyenne de la classe :" + moyenne);
Console.WriteLine("L'écart entre note min et max : " + noteEcart);
Console.WriteLine("********************************");
// les élèves en dessous de la moyenne

Console.WriteLine("Les élèves en dessous de la moyenne : ");
for (int i = 0; i < nbEffectif; i++)
{
    if (notes[i]<moyenne)
    {
        Console.WriteLine(noms[i] + "\t");
    }
}
Console.WriteLine("**************************");

// Les élèves au dessus de la moyenne

Console.WriteLine("Les élèves au dessus de la moyenne ");

for (int i=0;i<nbEffectif;i++)
{
    if (notes[i] > moyenne)
    {
        Console.WriteLine(noms[i] + "\t");
    }
}

Console.WriteLine("**************************");

//affichage de toute la classe

for (int i = 0; i < nbEffectif; i++)
{
    double ecart = notes[i] - moyenne;
    if(ecart<0)
    {
        ecart = 0 - ecart;
    }
    Console.WriteLine(noms[i] + "\t" + notes[i] + "\t" + ecart);
}
Console.WriteLine("**************************");

Console.ReadKey(true);