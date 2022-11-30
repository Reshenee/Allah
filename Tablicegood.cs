/*int n = int.Parse(Console.ReadLine());
int[] W = new int[n];
for (int i = 0; i < W.Length; i++)
{
    W[i] = int.Parse(Console.ReadLine());
}
for (int i = 0; i < W.Length; i++)
{
    Console.WriteLine(int.MaxValue);
}*/

/*int Maksik = int.MinValue;
int n = int.Parse(Console.ReadLine());
int[] W = new int[n];
int ilosc = 1;
for (int i = 0; i < W.Length; i++)
{
    W[i] = int.Parse(Console.ReadLine());
}
for (int i = 0; i < W.Length; i++)
{
    if (W[i] > Maksik)
    {
        Maksik = W[i];
        ilosc = 0;
    }
}

for (int i = 0; i < W.Length; i++)
{
    if (W[i] == Maksik);
    {
        ilosc += 1;
    }
}
Console.WriteLine(ilosc);*/


int Suma = 0;
int n = int.Parse(Console.ReadLine());
int[] W = new int[n];
for (int i = 0; i < W.Length; i++)
{
    W[i] = int.Parse(Console.ReadLine());
}
for (int i = 0; i < W.Length; i++)
{
    if (W[i] % 2 == 0)
    {
        Suma += (W[i]);
    }
}
Console.WriteLine(Suma);