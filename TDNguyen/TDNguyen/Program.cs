int degrer = 0;


for (int i= 1;i<=12;i++)
{
    Console.WriteLine("Veuillez rentrer le mois " + i);
    degrer = Convert.ToInt32(Console.ReadLine());

    if(degrer>=15)
    {
        Console.WriteLine("Ce mois est en canicule");
    }
}

Console.ReadKey(true);