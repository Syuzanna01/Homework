//1
int a = 4441, b, c, d, e;
b = a % 10;
a /= 10;
c = a % 10 * 10;
a /= 10;
d = a % 10 * 100;
a /= 10;
e = a % 10 * 1000;
Console.WriteLine($"{e}+{d}+{c}+{b} = {e + d + c + b}");
Console.ReadKey();

//2
string lastName = "Syuzanna";
string firstName = "Manukyan";
string age = "21";
string ToLearn = "HAPH"; 

Console.WriteLine($"Es {lastName} {firstName}-n em {age} tarekan sovorum em {ToLearn}-um ");
Console.ReadKey();

//3.1
string a = Console.ReadLine();

if (a == "erkushabti")
    Console.WriteLine("1");
else if (a == "ereqshabti")
    Console.WriteLine("2");
else if (a == "choreqshabti")
    Console.WriteLine("3");
else if (a == "hingshabti")
    Console.WriteLine("4");
else if (a == "urbat")
    Console.WriteLine("5");
else if (a == "shabat")
    Console.WriteLine("6");
else if (a == "kiraki")
    Console.WriteLine("7");

Console.ReadKey();

//3.2
int a = 25; float b = 5; byte c = 235; long d = -862;
int k;
if (a < b)
{
    k = a;
    a = (int)b;
    b = k;
}
if (a < c)
{
    k = a;
    a = (int)c;
    c = (byte)k;
}
if (a < d)
{
    k = a;
    a = (int)d;
    d = k;
}
if (b < c)
{
    k = (int)b;
    b = c;
    c = (byte)k;
}
if (b < d)
{
    k = (int)b;
    b = d;
    d = k;
}
if (c < d)
{
    k = c;
    c = (byte)d;
    d = k;
}
Console.WriteLine($"{a},{b},{c},{d}");

//Alisa
int a = int.Parse(Console.ReadLine());
int i = 0, k, t = 0, m;
while (a % 10 != 0)
{
    k = a % 10;
    if (i == 1)
    {
        if (k >= 5)
            t = 100;
        else
            t = 0;
    }
    if (i > 1)
    {
        m = a * 100 + t;
        Console.WriteLine($"{m}"); 
    }
    a /= 10;
    i++;
}
Console.ReadKey();