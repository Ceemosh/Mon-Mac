int a;

Console.Write("Ecrire un nombre entier");
a = Convert.ToInt32(Console.ReadLine());

for(int i=1;i<=a;i++)
{
    Console.WriteLine("*"i);

}

Console.ReadKey(true);