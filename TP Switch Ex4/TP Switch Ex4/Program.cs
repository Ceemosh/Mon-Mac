char lettre;
string reset = "oui";
do
{
    Console.Write("Entrer une lettre : ");
    lettre = Convert.ToChar(Console.ReadLine().ToLower());

    switch (lettre) //doit être une variable de type int ou char ou string
    {
        case 'a':
        case 'e':
        case 'i':
        case 'o':
        case 'u':
        case 'y':
            Console.WriteLine("La lettre est une voyelle");
            break;

        case 'b':
        case 'c':
        case 'd':
        case 'f':
        case 'h':
        case 'j':
        case 'k':
        case 'l':
        case 'm':
        case 'n':
        case 'p':
        case 'q':
        case 'r':
        case 's':
        case 't':
        case 'v':
        case 'w':
        case 'x':
        case 'z':
            Console.WriteLine("La lettre est une consonne");
            break;

        default:
            Console.WriteLine("C'est un caractere ou un chiffre");
            break;
    }
    Console.WriteLine("Voulez vous recommencez ? : (oui/non)");
    reset = Console.ReadLine();
    Console.Clear();
} while (reset == "oui");

Console.ReadKey(true);
