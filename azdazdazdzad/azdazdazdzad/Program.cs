int a1 = 12;
int b1=13;
int c1 = 20;
if((a1>b1)&&(c1>b1))
{
    if(a1>15)
    {
        Console.WriteLine("Cas 1.1");
    }
    else
    {
        Console.WriteLine("Cas 1.2");
    }
}
else if(a1>c1)
{
    Console.WriteLine("Cas 1.3");
}
else
{
    Console.WriteLine("Cas 1.4");
}

Console.ReadKey(true);