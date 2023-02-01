double nb1, nb2, resultat = 0;
bool correct = false;
char operation;
Console.WriteLine("Entrer 1 nombre svp :");
nb1 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Quelle operation souhaitez-vous ? ( + - * / ) ");
operation = Convert.ToChar(Console.ReadLine());
Console.WriteLine("Entrer le 2eme nombre svp :");
nb2 = Convert.ToInt16(Console.ReadLine());
switch (operation)
{
    case '+':
        resultat = nb1 + nb2;
        correct = true;
        break;
    case '-':
        resultat = nb1 - nb2;
        correct = true;
        break;
    case ':':
        resultat = nb1 / nb2;
        correct = true;
        break;
    case '*':
        resultat = nb1 * nb2;
        correct = true;
        break;
    default:
        Console.WriteLine("Opération impossible");
        break;
}
if (correct)
    Console.WriteLine("Le resultat est " + resultat);

Console.ReadKey(true);
