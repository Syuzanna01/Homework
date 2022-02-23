//151
int k = 0;
int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    if ((n % i) == 0)
        k += i;
}
Console.WriteLine(k); 1 2 4 5 10 20

//152
int k = 1;
int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    if ((n % i) == 0)
        k *= i;
}
Console.WriteLine(k);

//153
int k = 0;
int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    if ((n % i) == 2)
        k += i;
}
Console.WriteLine(k);

//154
int k = 1;
int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    if ((n % i) == 3)
        k *= i;
}
Console.WriteLine(k);

//155
int k = 0;
for (int i = 1; i <= 99; i++)
{
    if ((i % 3) == 0)
        k += i;
}
Console.WriteLine(k);

//156
int k = 0;
for (int i = 1; i <= 99; i++)
{
    if ((i % 3) == 0 & (i % 5) == 0)
        k += i;
}
Console.WriteLine(k);

//157
int k = 0;
for (int i = 1; i <= 999; i++)
{
    if ((i % 5) != 0)
        k += i;
}
Console.WriteLine(k);

//158
int k = 1;
for (int i = 1; i <= 999; i++)
{
    if ((i % 3) != 0 & (i % 2) != 0)
        k *= i;
}
Console.WriteLine(k);

//159
int k = 1;
for (int i = 800; i <= 999; i++)
{
    if ((i % 3) == 1 & (i % 4) == 2)
        k += i;
}
Console.WriteLine(k);

160
for (int i = 100; i <= 999; i++)
{
    if (Math.Sqrt(i * 16) % 1 == 0)
    {
        Console.WriteLine(i);
    }
}

//161
for (int i = 1000; i < 9999; i++)
{
    if (Math.Sqrt(i * 26) % 1 == 0)
    {
        Console.WriteLine(i);
        break;
    }
}

//162
for (int i = 1000; i < 9999; i++)
{
    if (Math.Sqrt(i * 14) % 1 == 0)
    {
        Console.WriteLine(i);
        break;
    }
}

//163
for (int i = 1000; i < 9999; i++)
{
    if (Math.Sqrt(i * 18) % 1 == 0)
    {
        Console.WriteLine(i);
        break;
    }
}

//164
int n = 400;
for (int i = 100; i < 999; i++)
{
    if (Math.Sqrt(i) % 1 == 0 & i > n)
    {
        Console.WriteLine(i);
        break;

    }
}

//165
int n = int.Parse(Console.ReadLine());
bool t;
for (int i = 1; i < n; i++)
{
    n /= 3;
    n %= 3;
    if (n == 0)
    {
        t = true;
        Console.WriteLine(t);
    }
    else
    {
        t = false;
        Console.WriteLine(t);
    }
}

//166
int n = int.Parse(Console.ReadLine());
int t;
for (int i = 1; i < n; i++)
{
    n /= 4;
    n %= 4;
    if (n == 0)
    {
        t = 1;
        Console.WriteLine(t);
    }
    else
    {
        t = 0;
        Console.WriteLine(t);
    }
}

//191
double x = 3, sum = 0;
double n = double.Parse(Console.ReadLine());
for (double i = 0; i <= n;)
    sum += Math.Pow(x, i++);

Console.WriteLine(sum);

//192
double x = 3, sum = 0;
double n = double.Parse(Console.ReadLine());
for (double i = 0; i <= n;)
    sum += Math.Pow(-x, i++);

Console.WriteLine(sum);

//193
int sum = 1, sun = 0;
int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    sum = sum * i;
    sun += sum;
}
Console.WriteLine(sun);

//194
double sum = 1, sun = 1;
int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    sum *= i;
    sun += 1 / sum;
}
Console.WriteLine(sun);

//195
double sum = 1, sun = 1;
int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n;)
{
    sum *= i;
    sun += Math.Pow(n, i++) / sum;
}
Console.WriteLine(sun);


