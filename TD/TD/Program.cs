double min = 200, montant = 0, max = 0;

for (int i=1; i<=5; i++) 
{
    Console.Write("Écrire un nombre");
    montant = Convert.ToInt32(Console.ReadLine());

    if(montant>max)
    {
        max = montant;
    }

    else
    {
        min = montant;
    }

}

Console.WriteLine("Le montant max est de : " + max +" et le plus petit nombre est de " +min);


Console.ReadKey(true);


