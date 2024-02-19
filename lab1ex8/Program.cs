/*
Se citesc trei numere de la tastatura, x, y, z. Scrieti un program care va afisa cele
trei valori in ordine descrescatoare.
• Exemplu: citim 3 9 0 Afisam : 9 3 0*/

using System.Collections.Generic;

Console.WriteLine("Introduceti x");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Introduceti y");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Introduceti z");
int z = Convert.ToInt32(Console.ReadLine());

int primulnr , doileanr, treileanr;

if (x >= y && x >= z)
{
    primulnr = x;
    if (y >= z)
    {
        doileanr = y;
        treileanr = z;
    }
    else
    {
        doileanr = z;
        treileanr = y;
    }
}
else if (y >= x && y >= z)
{
    primulnr = y;
    if (x >= z)
    {
        doileanr = x;
        treileanr = z;
    }
    else
    {
        doileanr = z;
        treileanr = x;
    }
}
else
{
    primulnr = z;
    if (x >= y)
    {
        doileanr = x;
        treileanr = y;
    }
    else
    {
        doileanr = y;
        treileanr = x;
    }
}


Console.WriteLine("Ordinea descrescatoare:");
Console.WriteLine(primulnr);
Console.WriteLine(doileanr);
Console.WriteLine(treileanr);