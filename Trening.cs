


/*int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if ((i == 0) || (j == n / 2) || (j == (n / 2) + 1) || (j == (n / 2) - 1))
        {
            Console.Write("*");
        }
        else
        {
            Console.Write("-");
        }

    }
    Console.WriteLine();
}

for (int h = 1; h < n; h++)
{
    for (int g = 0; g < n; g++)
    {
        if ((g > n - h) || (g < h - 1))
        {
            Console.Write(" ");
        }
        else
        {
            Console.Write("*");
        }
    }
    Console.WriteLine();
}*/







/*int n = int.Parse(Console.ReadLine());
for (int i = 1; i < n; i++)
{
    for (int j = 1; j < n; j++)
    {
        if ((i == j) || (j == n - i) ||  (i == j + 1) || (j == n - i + 1) || (i == j - 1) || (j == n - i - 1))
        {
            Console.Write("*");
        }
        else
        {
            Console.Write(" ");
        }

    }
    Console.WriteLine();
}*/





/*using System.Globalization;

int n = int.Parse(Console.ReadLine());
for (int i = 1; i < n; i++)
{
    for (int j = 1; j < n; j++)
    {
        if ((i == 1) || (j == 1) || (j == n - 1) || (i == n - 1) || ((i == n / 2) && (j == n / 2)))
        {
            Console.Write("*");
        }
        else
        {
            Console.Write(" ");
        }

    }
    Console.WriteLine();
}*/






/*using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

int n = int.Parse(Console.ReadLine());
int iloczyn = 0;
int wynik = 0;
for (int x = 7; x < 7 + n; x + 2)
{
    for (int z = 1; z < n; Math.Pow(z, 2))
    {
        iloczyn == (2 * x / z)
        wynik == (iloczyn) * (iloczyn);
    }
    Console.Write(wynik)
}
*/



/*int n = int.Parse(Console.ReadLine());
double a = 1;
for (double i = 1; i <= n; i++)
{
    a = a * (2 * (5 + i * 2)) / Math.Pow(i, 2);
}
Console.WriteLine(a);*/