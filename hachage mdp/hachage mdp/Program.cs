using System;

Random rnd = new Random();

int codeASCIHasard = rnd.Next(97, 122);

char lettreHasard = (char)codeASCIHasard;

for (int i=0;i<12;i++)
{
    Console.WriteLine(codeASCIHasard);
}








Console.ReadKey(true);