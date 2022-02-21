
//21
int a = 2, b = 7, c = -2, k;
int d = Math.Max(a, b);
int e = Math.Max(d, c);
Console.WriteLine(e);

//22
int a = 2, b = 7, c = -2;
int f = Math.Min(a, b);
int g = Math.Min(f, c);
Console.WriteLine(g);

//23
int a = 2, b = 7, c = 2;
if (a == b || b == c || a == c)
    Console.WriteLine(true);
else
    Console.WriteLine(false);

//24
int a = 2, b = 7, c = -2;
if ((a == 2 & b == 2) || (b == 2 & c == 2) || (a == 2 & c == 2))
    Console.WriteLine(true);
else
    Console.WriteLine(false);

//25
int a = 2, b = 7, c = -2;
if (a * a + b * b > c * c & b * b + c * c > a * a & a * a + c + c > b * b)
    Console.WriteLine("1");
else
    Console.WriteLine("2");

//26
int a = 2, b = 7, c = -2;
if (a % b == 0 || b % c == 0 || a % c == 0)
    Console.WriteLine("1");
else
    Console.WriteLine("2");

//27
int a = 2, b = 7, c = -2;
if (b - a == c - b)
    Console.WriteLine(true);
else
    Console.WriteLine(false);

//28
int a = 2, b = 7, c = -2;
if (b / a == c / b)
    Console.WriteLine(true);
else
    Console.WriteLine(false);

//29
int a = -5, b = 2, c = 8, k;
if (a < b)
{

    k = a;
    a = b;
    b = k;
}
if (a < c)
{
    k = a;
    a = c;
    c = k;
}
if (b < c)
{
    k = b;
    b = c;
    c = k;
}
Console.WriteLine($"{a},{b},{c}");

//30
int a = 2, b = 7, c = -2, k;
if (a > b)
{
    k = a;
    a = b;
    b = k;
}
if (a > c)
{
    k = a;
    a = c;
    c = k;
}
if (b > c)
{
    k = b;
    b = c;
    c = k;
}
Console.WriteLine($"{a},{b},{c}");

51
bool p = false;
int b, l, g;
int t = int.Parse(Console.ReadLine());
b = t % 10;
g = t / 10;
l = g % 10;
l += g / 10;

if (b == l)
{
    p = true;
    Console.WriteLine(p);
}
else
    Console.WriteLine($"{p} {t}");

52
bool p = false;
int b, l, g;
int t = int.Parse(Console.ReadLine());
b = t % 10;
t /= 10;
g = t % 10;
t /= 10;
l = t % 10;

if (b == g | b == l | l == g)
{
    p = true;
    Console.WriteLine(p);
}
else
    Console.WriteLine($"{p}");

53
decimal b, f, l, g, m;
const decimal k = 225;
decimal t = decimal.Parse(Console.ReadLine());
f = t;

if (t > k)
{
    b = f % 10;
    f /= 10;
    g = f % 10;
    t /= 10;
    l = f % 10;
    m = t / (b + g + l);
    Console.WriteLine(m);
}
else
{
    b = f % 10;
    m = b / t;
    Console.WriteLine(m);
}

54
int b, l, g;
int t = int.Parse(Console.ReadLine());

b = t % 10;
t /= 10;
g = t % 10;
t /= 10;
l = t % 10;

if (b > g)
{
    if (b > l)
        Console.WriteLine(b);
    else
        Console.WriteLine(l);
}
else
{
    if (g > l)
        Console.WriteLine(g);
    else
        Console.WriteLine(l);
}

55
int b, l, g;
int t = int.Parse(Console.ReadLine());

b = t % 10;
t /= 10;
g = t % 10;
t /= 10;
l = t % 10;

if (b < g)
{
    if (b < l)
        Console.WriteLine(b);
    else
        Console.WriteLine(l);
}
else
{
    if (g < l)
        Console.WriteLine(g);
    else
        Console.WriteLine(l);
}

56
decimal b, f, l, g, m;
decimal t = decimal.Parse(Console.ReadLine());
f = t;
b = f % 10;
f /= 10;
g = f % 10;
f /= 10;
l = f % 10;

if (b > g)
{
    m = (b + g + l) / t;
    Console.WriteLine(m);
}
else
    Console.WriteLine(t);

57--
int l, f, b, g;
decimal k;
int t = int.Parse(Console.ReadLine());
f = t;
b = f % 10;
f /= 10;
g = f % 10;
f /= 10;
l = f % 10;

if (t > 300)
{
    k = g / b;
    Console.WriteLine(k);
}
else
{
    k = l / b;
    Console.WriteLine(k);
}

58
char f;
int l, g, m;
int t = int.Parse(Console.ReadLine());

t /= 10;
g = t % 10;
t /= 10;
l = t % 10;
if (g + l < 5)
    Console.WriteLine(f = 'a');
else
    Console.WriteLine(f = 'b');

59
int l, f, b, g;
int t = int.Parse(Console.ReadLine());
b = t % 10;
t /= 10;
g = t % 10;
t /= 10;
l = t % 10;

if (b < g)
{
    f = g;
    g = b;
    b = f;
}
if (b < l)
{
    f = b;
    b = l;
    l = f;
}
if (g < l)
{
    f = g;
    g = l;
    l = f;
}
Console.WriteLine($"{b} {g} {l}");

60
int l, f, b, g;
int t = int.Parse(Console.ReadLine());
b = t % 10;
t /= 10;
g = t % 10;
t /= 10;
l = t % 10;
 
if (b > g)
{
    f = g;
    g = b;
    b = f;
}
if (b > l)
{
    f = b;
    b = l;
    l = f;
}
if (g > l)
{
    f = g;
    g = l;
    l = f;
}
Console.WriteLine($"{b} {g} {l}");
Console.ReadKey();