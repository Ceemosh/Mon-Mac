internal class Program
{
    private static void Main(string[] args)
    {
        int nombre;

        Console.WriteLine("Entrer un nombre positif : ");
        nombre = Convert.ToInt16(Console.ReadLine());

        if (nombre < 0)
        {

            Console.WriteLine("Erreur. Entrer un nombre positif : ");
            nombre = Convert.ToInt16(Console.ReadLine());

        }
        Console.WriteLine("Très bien");
        Console.ReadKey(true);
    }
}