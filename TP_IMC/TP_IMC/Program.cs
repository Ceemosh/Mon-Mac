double taille = 0;
double IMC = 0;
double poids = 0;


Console.Write("Indiquez votre taille en cm : ");
taille = Convert.ToDouble(Console.ReadLine());

Console.Write("Indiquez votre poids : ");
poids = Convert.ToDouble(Console.ReadLine());

taille = taille/100;
IMC = poids / (taille*taille);


Console.WriteLine("Votre IMC est de : "+IMC);

if (IMC < 18.5) ;
{
    Console.WriteLine("Trop maigre");
}
if (IMC >= 18.5 && IMC < 25) ;
{
    Console.WriteLine("Maigre");
}

if (IMC >= 25 && IMC < 30) ;
{
    Console.WriteLine("Maigre mitigé");
}
if (IMC >= 30 && IMC < 35) ;
{
    Console.WriteLine("Gros");
}
if (IMC >= 35 && IMC < 40) ;
{
    Console.WriteLine("Gros Porc");
}




Console.ReadKey(true);