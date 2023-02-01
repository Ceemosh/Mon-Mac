double note = 0, total = 0;
int nbNoteSup18 = 0, nbNote = 3;

while (note >= 0 && note <= 20) 
{
    for (int i = 1; i <= nbNote; i++)
    {
        Console.Write("Saisir la note " + i + " : ");
        note = Convert.ToDouble(Console.ReadLine());
        total = total + note;
        if (note >= 18)
            nbNoteSup18++;
        if (note < 0 || note > 20)
        {
            Console.WriteLine("Erreur, veuillez resaisir la note .");
        }
    }

} 
Console.WriteLine("La moyenne des " + nbNote + " notes est " + (total / nbNote));
if (nbNoteSup18 == 0)
    Console.Write("Aucune note n'est supérieure à 18 ");
else
    Console.Write("Il y a  " + nbNoteSup18 + " superieure(s) à 18");


Console.ReadKey(true);