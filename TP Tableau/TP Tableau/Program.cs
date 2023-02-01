int tailleTableau = 3;
int[] tabEx = new int[tailleTableau];
tabEx[0] = 19;
tabEx[1] = 23;
tabEx[2] = 25;

for (int i=0;i<tailleTableau;i++)
{
    Console.WriteLine("on l'affiche l'indice : " + i);
    Console.WriteLine("on affiche l'élément qui se trouve à l'indice ci-dessus : " + tabEx[i]);
}

Console.WriteLine("on va essayer : " + tabEx[2]);


Console.ReadKey(true);