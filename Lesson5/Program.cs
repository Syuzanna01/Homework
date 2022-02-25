//211
double b = 0, c = 0;
int[] a = new int[10];
for (int i = 0; i <= a.Length - 1; i++)
    a[i] = int.Parse(Console.ReadLine());
for (int i = 0; i < a.Length; i++)
    if (a[i] > 0)
    {
        c++;
        b += a[i];
    }
Console.WriteLine(b / c);

//212
double b = 0, c = 0;
int[] a = new int[5];
for (int i = 0; i <= a.Length - 1; i++)
    a[i] = int.Parse(Console.ReadLine());
for (int i = 0; i < a.Length; i++)
    if (a[i] > 0)
    {
        b += a[i] * a[i];
        c++;
    }
Console.WriteLine(Math.Sqrt(b / c));

//213
double b = 0, c = 0;
int[] a = new int[5];
for (int i = 0; i <= a.Length - 1; i++)
    a[i] = int.Parse(Console.ReadLine());
for (int i = 0; i < a.Length; i++)
    if (a[i] < 0)
    {
        b += a[i] * a[i];
        c++;
    }
Console.WriteLine(Math.Sqrt(b / c));

//214
double b = 0, c = 0;
int[] a = new int[5];
for (int i = 0; i <= a.Length - 1; i++)
    a[i] = int.Parse(Console.ReadLine());
for (int i = 0; i < a.Length; i++)
    if (a[i] < 0)
    {
        c++;
        b += a[i];
    }
Console.WriteLine(b / c);

215
double b = 0;
int[] a = new int[5];
for (int i = 0; i <= a.Length - 1; i++)
    a[i] = int.Parse(Console.ReadLine());
for (int i = 1; i < a.Length; i++)
    if (i % 2 == 0)
        b += a[i];
Console.WriteLine(b);

216
double b = 0;
int[] a = new int[5];
for (int i = 0; i <= a.Length - 1; i++)
    a[i] = int.Parse(Console.ReadLine());
for (int i = 1; i < a.Length; i++)
    if (i % 2 == 0)
        b *= a[i];
Console.WriteLine(b);

//217
double b = 0;
int[] a = new int[5];
for (int i = 0; i <= a.Length - 1; i++)
    a[i] = int.Parse(Console.ReadLine());
for (int i = 0; i < a.Length; i++)
    if (i % 2 == 1)
        b += a[i];
Console.WriteLine(Math.Sqrt(b));

//218
double b = 0;
int[] a = new int[5];
for (int i = 0; i <= a.Length - 1; i++)
    a[i] = int.Parse(Console.ReadLine());
for (int i = 1; i < a.Length; i++)
    if (i % 2 == 1)
        b += a[i];
if (b < 0)
    b = -b;
Console.WriteLine(b);

//219
int k = 2, sum = 0;
int[] a = new int[5];
for (int i = 0; i <= a.Length - 1; i++)
    a[i] = int.Parse(Console.ReadLine());
for (int i = 0; i < a.Length; i++)
    if (a[i] % k == 0)
        sum++;
Console.WriteLine(sum);

//220
double[] a = new double[5];
int sum = 0;
for (int i = 0; i <= a.Length - 1; i++)
    a[i] = double.Parse(Console.ReadLine());
for (int i = 0; i < a.Length; i++)
    if (Math.Abs(a[i]) % 2 == 0 | Math.Abs(a[i]) % 2 == 1)
        sum++;
Console.WriteLine(sum);

//221
int a = 2, b = 20, sum = 0;
int[] c = new int[5];
for (int i = 0; i <= c.Length - 1; i++)
    c[i] = int.Parse(Console.ReadLine());
for (int i = 0; i < c.Length; i++)
    if (c[i] >= a & c[i] <= b)
        sum += c[i];
Console.WriteLine(sum);

//222
int c = 2, b = 20, sum = 1;
int[] a = new int[5];
for (int i = 0; i <= a.Length - 1; i++)
    a[i] = int.Parse(Console.ReadLine());
for (int i = 0; i < a.Length; i++)
    if (a[i] >= c & a[i] < b)
        sum *= a[i];
Console.WriteLine(sum);.

//223
int a = 2, b = 20, sum = 0;
int[] c = new int[5];
for (int i = 0; i <= c.Length - 1; i++)
    c[i] = int.Parse(Console.ReadLine());
for (int i = 0; i < c.Length; i++)
    if (c[i] > a & c[i] < b)
        sum++;
Console.WriteLine(sum);

//224
int k = 5, sum = 0;
int[] a = new int[5];
for (int i = 0; i <= a.Length - 1; i++)
    a[i] = int.Parse(Console.ReadLine());
for (int i = 0; i < a.Length; i++)
    if (Math.Abs(a[i]) > k)
        sum += Math.Abs(a[i] * a[i] * a[i]);
Console.WriteLine(sum);

//225
int t = 5, sum = 1;
int[] a = new int[5];
for (int i = 0; i <= a.Length - 1; i++)
    a[i] = int.Parse(Console.ReadLine());
for (int i = 0; i < a.Length; i++)
    if (Math.Abs(a[i]) < t)
        sum *= Math.Abs(a[i]);
Console.WriteLine(sum);

//226
int t = 5, sum = 0;
int[] a = new int[5];
for (int i = 0; i <= a.Length - 1; i++)
    a[i] = int.Parse(Console.ReadLine());
for (int i = 0; i < a.Length; i++)
    if (Math.Abs(a[i]) < t)
        sum++;
Console.WriteLine(sum);

//227
double k = 3, sum = 0, t = 0;
int[] a = new int[10];
for (int i = 0; i <= a.Length - 1; i++)
    a[i] = int.Parse(Console.ReadLine());
for (int i = 1; i < a.Length; i++)
    if (i % k == 0)
    {
        t += a[i];
        sum++;
    }
Console.WriteLine(t / sum);

//228
int k = 3, t = 0;
int[] a = new int[10];
for (int i = 0; i <= a.Length - 1; i++)
    a[i] = int.Parse(Console.ReadLine());
for (int i = 1; i < a.Length; i++)
    if (i % k == 0)
        t += a[i];
Console.WriteLine(t);

//229
int t = 1;
int[] a = new int[5];
for (int i = 0; i <= a.Length - 1; i++)
    a[i] = int.Parse(Console.ReadLine());
for (int i = 0; i < a.Length; i++)
    if (a[i] - i > 0)
        t *= a[i];
Console.WriteLine(t);

//230 
int k = 3, b = 0, c = 0;
int[] a = new int[5];
for (int i = 0; i <= a.Length - 1; i++)
    a[i] = int.Parse(Console.ReadLine());
for (int i = 0; i < a.Length; i++)
    if (a[i] % k == 0)
    {
        b += a[i] * a[i];
        c++;
    }
Console.WriteLine(Math.Sqrt(b / c));

cposity//singlton

//231
int[] a = new int[5];
int sum = 0, i = 0;
while (i < a.Length)
{
    a[i] = int.Parse(Console.ReadLine());
    i++;
}
i = 0;
while (i < a.Length)
{
    if (a[i] % 2 == 0)
        sum += a[i] * a[i];
    i++;
}
Console.WriteLine(sum);

//232
int[] a = new int[5];
int sum = 0, i = 0;
while (i < a.Length)
{
    a[i] = int.Parse(Console.ReadLine());
    i++;
}
i = 0;
while (i < a.Length)
{
    if (a[i] % 2 == 0)
        sum++;
    i++;
}
Console.WriteLine(sum);

//233
int[] a = new int[5];
int sum = 0, i = 0, sun = 1;
while (i < a.Length)
{
    a[i] = int.Parse(Console.ReadLine());
    i++;
}
i = 0;
while (i < a.Length)
{
    if (a[i] % 2 == 0)
    {
        sun *= a[i];
        sum += a[i];
    }
    i++;
}
Console.WriteLine(sum);
Console.WriteLine(sun);

//234
int[] a = new int[5];
double sum = 0, sun = 0;
int i = 0;
while (i < a.Length)
{
    a[i] = int.Parse(Console.ReadLine());
    i++;
}
i = 0;
while (i < a.Length)
{
    if (a[i] % 2 == 1)
    {
        sun += a[i];
        sum++;
    }
    i++;
}
Console.WriteLine(sun / sum);

//235
int[] a = new int[5];
double sum = 0, sun = 0;
int i = 0;
while (i < a.Length)
{
    a[i] = int.Parse(Console.ReadLine());
    i++;
}
i = 0;
while (i < a.Length)
{
    if (a[i] % 2 == 1)
    {
        sun += a[i] * a[i];
        sum++;
    }
    i++;
}
Console.WriteLine(Math.Sqrt(sun / sum));

//236
int[] a = new int[5];
int sum = 0, sun = 1, i = 0;
while (i < a.Length)
{
    a[i] = int.Parse(Console.ReadLine());
    i++;
}
i = 0;
while (i < a.Length)
{
    if (a[i] % 2 == 1)
    {
        sun *= a[i];
        sum++;
    }
    i++;
}
Console.WriteLine(sum);
Console.WriteLine(sun);

//237
int[] a = new int[5];
int sum = 0, i = 0;
while (i < a.Length)
{
    a[i] = int.Parse(Console.ReadLine());
    i++;
}
i = 0;
while (i < a.Length)
{
    if (a[i] == 0)
        sum++;
    i++;
}
Console.WriteLine(sum);

//238
int[] a = new int[5];
double sum = 0, sun = 0;
int i = 0;
while (i < a.Length)
{
    a[i] = int.Parse(Console.ReadLine());
    i++;
}
i = 0;
while (i < a.Length)
{
    if (a[i] % 3 == 0)
    {
        sun += a[i];
        sum++;
    }
    i++;
}
Console.WriteLine(sun / sum);

//239
int[] a = new int[5];
double sum = 0, sun = 0;
int i = 0;
while (i < a.Length)
{
    a[i] = int.Parse(Console.ReadLine());
    i++;
}
i = 0;
while (i < a.Length)
{
    if (a[i] % 5 == 0)
    {
        sun += a[i] * a[i];
        sum++;
    }
    i++;
}
Console.WriteLine(Math.Sqrt(sun / sum));

//240
int[] a = new int[5];
double sum = 0, i = 0;
while (i < a.Length)
{
    a[i] = int.Parse(Console.ReadLine());
    i++;
}
i = 0;
while (i < a.Length)
{
    if (a[i] % 7 == 0)
        sum++;
    i++;
}
Console.WriteLine(sum);

//241
int[] a = new int[5];
int sum = 0, k = 3, i = 0;
while (i < a.Length)
{
    a[i] = int.Parse(Console.ReadLine());
    i++;
}
i = 0;
while (i < a.Length)
{
    if (a[i] % k == 0)
        sum += a[i];
    i++;
}
Console.WriteLine(sum);

//242
int[] a = new int[5];
int sum = 1, m = 4, i = 0;
while (i < a.Length)
{
    a[i] = int.Parse(Console.ReadLine());
    i++;
}
i = 0;
while (i < a.Length)
{
    if (a[i] % m == 0)
        sum *= a[i];
    i++;
}
Console.WriteLine(sum);

//243
int[] a = new int[5];
int sum = 0, t = 3, i = 0;
while (i < a.Length)
{
    a[i] = int.Parse(Console.ReadLine());
    i++;
}
i = 0;
while (i < a.Length)
{
    if (a[i] % t == 0)
        sum++;
    i++;
}
Console.WriteLine(sum);

//244
int[] a = new int[5];
int sum = 1, i = 0;
while (i < a.Length)
{
    a[i] = int.Parse(Console.ReadLine());
    i++;
}
i = 0;
while (i < a.Length)
{
    if (a[i] % 5 == 2)
        sum *= a[i];
    i++;
}
Console.WriteLine(sum);


//245
int[] a = new int[5];
int sum = 0, i = 0;
while (i < a.Length)
{
    a[i] = int.Parse(Console.ReadLine());
    i++;
}
i = 0;
while (i < a.Length)
{
    if ((a[i] + i) % 3 == 0)
        sum += a[i] * a[i];
    i++;
}
Console.WriteLine(sum);

//246
int[] a = new int[5];
double sum = 0, sun = 0;
int i = 0;
while (i < a.Length)
{
    a[i] = int.Parse(Console.ReadLine());
    i++;
}
i = 1;
while (i < a.Length)
{
    if (Math.Sqrt(i) % 1 == 0)
    {
        sum += a[i];
        sun++;
    }
    i++;
}
Console.WriteLine(sum / sun);

//247
int[] a = new int[5];
double sum = 0, sun = 0;
int i = 0;
while (i < a.Length)
{
    a[i] = int.Parse(Console.ReadLine());
    i++;
}
i = 0;
while (i < a.Length)
{
    if (a[i] > i)
    {
        sum += a[i] * a[i];
        sun++;
    }
    i++;
}
Console.WriteLine(Math.Sqrt(sum / sun));

//248
int[] a = new int[5];
int i = 0, sum = 0, k = 3;
while (i < a.Length)
{
    a[i] = int.Parse(Console.ReadLine());
    i++;
}
i = 0;
while (i < a.Length)
{
    if ((a[i] + i) * 2 % k == 0)
        sum += a[i];
    i++;
}
Console.WriteLine(sum);

//249
int[] a = new int[5];
double sum = 0, k = 3;
int i = 0;
while (i < a.Length)
{
    a[i] = int.Parse(Console.ReadLine());
    i++;
}
i = 0;
while (i < a.Length)
{
    if (Math.Abs((a[i] - i)) > k)
        sum++;
    i++;
}
Console.WriteLine(sum);

//250
int[] a = new int[5];
double sum = 0;
int i = 0;
while (i < a.Length)
{
    a[i] = int.Parse(Console.ReadLine());
    i++;
}
i = 0;
while (i < a.Length)
{
    if (a[i] * i % 3 == 2)
        sum += a[i] * a[i];
    i++;
}
Console.WriteLine(sum);


//151
int[] a = new int[5];
int i = 0;
foreach (var item in a)
{
    a[i] = int.Parse(Console.ReadLine());
    i++;
}
i = 0;
int b = a[0];
foreach (var item in a)
{
    if (a[i] > b)
        b = a[i];
    i++;
}
Console.WriteLine(b);

//152
int[] a = new int[5];
int i = 0;
foreach (var item in a)
{
    a[i] = int.Parse(Console.ReadLine());
    i++;
}
i = 0;
int b = a[0];
foreach (var item in a)
{
    if (a[i] < b)
        b = a[i];
    i++;
}
Console.WriteLine(b);

//153
int[] a = new int[5];
int i = 0;
foreach (var item in a)
{
    a[i] = int.Parse(Console.ReadLine());
    i++;
}
i = 0;
int b = a[0];
int c = a[0];
foreach (var item in a)
{
    if (a[i] > b)
        b = a[i];
    if (a[i] < c)
        c = a[i];
    i++;
}
Console.WriteLine(b + c);

//154
int[] a = new int[5];
int i = 0;
foreach (var item in a)
{
    a[i] = int.Parse(Console.ReadLine());
    i++;
}
i = 0;
int b = a[0];
int c = a[0];
foreach (var item in a)
{
    if (a[i] > b)
        b = a[i];
    if (a[i] < c)
        c = a[i];
    i++;
}
Console.WriteLine(b * c);

//155
int[] a = new int[5];
int i = 0, c = 0;
foreach (var item in a)
{
    a[i] = int.Parse(Console.ReadLine());
    i++;
}
i = 0;
int b = a[0];
foreach (var item in a)
{
    if (a[i] > b)
    {
        b = a[i];
        c = i;
    }
    i++;
}
Console.WriteLine(b + c);

// 156
int[] a = new int[5];
int i = 0, c = 0;
foreach (var item in a)
{
    a[i] = int.Parse(Console.ReadLine());
    i++;
}
i = 0;
int b = a[0];
foreach (var item in a)
{
    if (a[i] < b)
    {
        b = a[i];
        c = i;
    }
    i++;
}
Console.WriteLine(b + c);

// 157
int[] a = new int[5];
int i = 0, c = 0;
foreach (var item in a)
{
    a[i] = int.Parse(Console.ReadLine());
    i++;
}
i = 0;
int b = a[0];
foreach (var item in a)
{
    if (a[i] > b)
    {
        b = a[i];
        c = i;
    }
    i++;
}
Console.WriteLine(c);

// 158
int[] a = new int[5];
int i = 0, c = 0;
foreach (var item in a)
{
    a[i] = int.Parse(Console.ReadLine());
    i++;
}
i = 0;
int b = a[0];
foreach (var item in a)
{
    if (a[i] >= b)
    {
        b = a[i];
        c = i;
    }
    i++;
}
Console.WriteLine(c);

//159
int[] a = new int[5];
int i = 0, c = 0;
foreach (var item in a)
{
    a[i] = int.Parse(Console.ReadLine());
    i++;
}
i = 0;
int b = a[0];
foreach (var item in a)
{
    if (a[i] < b)
    {
        b = a[i];
        c = i;
    }
    i++;
}
Console.WriteLine(c);

//160
int[] a = new int[5];
int i = 0, c = 0;
foreach (var item in a)
{
    a[i] = int.Parse(Console.ReadLine());
    i++;
}
i = 0;
int b = a[0];
foreach (var item in a)
{
    if (a[i] <= b)
    {
        b = a[i];
        c = i;
    }
    i++;
}
Console.WriteLine(c);

//161
double a = 0, b = 0;
int n = int.Parse(Console.ReadLine());
int[] x = new int[n];
int[] y = new int[n];
for (int i = 0; i < n; i++)
{
    x[i] = int.Parse(Console.ReadLine());
    y[i] = int.Parse(Console.ReadLine());
    Console.WriteLine();
}
for (int i = 0; i < n; i++)
{
    a += x[i];
    b += y[i];
}
Console.WriteLine(a / n * b / n);

//162
double a = 0, b = 0;
int n = int.Parse(Console.ReadLine());
int[] x = new int[n];
int[] y = new int[n];
for (int i = 0; i < n; i++)
{
    x[i] = int.Parse(Console.ReadLine());
    y[i] = int.Parse(Console.ReadLine());
    Console.WriteLine();
}
for (int i = 0; i < n; i++)
{
    a += x[i] * x[i];
    b += y[i] * y[i];
}
Console.WriteLine(Math.Sqrt(a / n) + Math.Sqrt(b / n));

//163
double a = 0;
int n = int.Parse(Console.ReadLine());
int[] x = new int[n];
int[] y = new int[n];
for (int i = 0; i < n; i++)
{
    x[i] = int.Parse(Console.ReadLine());
    y[i] = int.Parse(Console.ReadLine());
    Console.WriteLine();
}
for (int i = 0; i < n; i++)
{
    if (x[i] > 0)
        a++;
    if (y[i] > 0)
        a++;
}
Console.WriteLine(a);

//164
int a = 0;
int n = int.Parse(Console.ReadLine());
int[] x = new int[n];
int[] y = new int[n];
for (int i = 0; i < n; i++)
{
    x[i] = int.Parse(Console.ReadLine());
    y[i] = int.Parse(Console.ReadLine());
    Console.WriteLine();
}
for (int i = 0; i < n; i++)
{
    if (x[i] < 0)
        a++;
    if (y[i] < 0)
        a++;
}
Console.WriteLine(a);

//165
double a = 0, b = 1;
int n = int.Parse(Console.ReadLine());
int[] x = new int[n];
int[] y = new int[n];
for (int i = 0; i < n; i++)
{
    x[i] = int.Parse(Console.ReadLine());
    y[i] = int.Parse(Console.ReadLine());
    Console.WriteLine();
}
for (int i = 0; i < n; i++)
{
    if (x[i] > 0)
        a += x[i];
    if (y[i] > 0)
        b *= y[i];
}
Console.WriteLine(a / b);

//166
double a = 0, b = 0;
int n = int.Parse(Console.ReadLine());
int[] x = new int[n];
int[] y = new int[n];
for (int i = 0; i < n; i++)
{
    x[i] = int.Parse(Console.ReadLine());
    y[i] = int.Parse(Console.ReadLine());
    Console.WriteLine();
}
for (int i = 0; i < n; i++)
{
    if (x[i] % 2 == 1)
        a += x[i];
    if (y[i] % 2 == 0)
        b += y[i];
}
Console.WriteLine(a - b);

//167
int a = 0, b = 0;
int n = int.Parse(Console.ReadLine());
int[] x = new int[n];
int[] y = new int[n];
for (int i = 0; i < n; i++)
{
    x[i] = int.Parse(Console.ReadLine());
    y[i] = int.Parse(Console.ReadLine());
    Console.WriteLine();
}
for (int i = 0; i < n; i++)
{
    if (x[i] % 7 == 0)
        a += x[i];
    if (y[i] % 7 == 0)
        b += y[i];
}
Console.WriteLine(a + b);

//271
int n = int.Parse(Console.ReadLine());
char[] x = new char[n];
int sum = 0;
for (int i = 0; i < n; i++)
    x[i] = Console.ReadLine()[0];
for (int i = 0; i < n; i++)
    if (x[i] == 'a')
        sum++;
Console.WriteLine(sum);

//272
int n = int.Parse(Console.ReadLine());
char[] x = new char[n];
bool t = false;
int sum = 0;
for (int i = 0; i < n; i++)
    x[i] = Console.ReadLine()[0];
for (int i = 0; i < n; i++)
    if (x[i] == 'b')
        sum++;
if (n / 2 == sum)
    t = true;
Console.WriteLine(t);

//273
int n = int.Parse(Console.ReadLine());
char[] x = new char[n];
int sum = 0;
for (int i = 0; i < n; i++)
    x[i] = Console.ReadLine()[0];
for (int i = 0; i < n; i++)
    if (x[i] == 's')
        sum += i;
Console.WriteLine(sum);

//274
int n = int.Parse(Console.ReadLine());
char[] x = new char[n];
decimal sum = 0, sun = 0;
for (int i = 0; i < n; i++)
    x[i] = Console.ReadLine()[0];
for (int i = 0; i < n; i++)
    if (x[i] > 'h')
    {
        sun += i;
        sum++;
    }
Console.WriteLine(sun / sum);

//275
int n = int.Parse(Console.ReadLine());
char[] x = new char[n];
int sum = 0;
for (int i = 0; i < n; i++)
    x[i] = Console.ReadLine()[0];
for (int i = 0; i < n; i++)
    if (x[i] < 'k')
        sum++;
Console.WriteLine(sum);

//276
int n = int.Parse(Console.ReadLine());
char[] x = new char[n];
bool t = false;
for (int i = 0; i < n; i++)
    x[i] = Console.ReadLine()[0];
for (int i = 0; i < n; i++)
    if (x[i] == 'r')
    {
        t = true;
        break;
    }
Console.WriteLine(t);

//277 int m = {};?
int n = int.Parse(Console.ReadLine());
char[] m = new char[n];
char[] x = new char[n];
int j = 0;
for (int i = 0; i < n; i++)
    x[i] = Console.ReadLine()[0];
for (int i = 0; i < n; i++)
    if (x[i] != 'd')
    {
        m[j] = x[i];
        j++;
    }
for (int i = 0; i < m.Length; i++)
    Console.Write(m[i]);

//278
int n = int.Parse(Console.ReadLine());
char[] m = new char[n];
char[] x = new char[n];
int j = 0;
for (int i = 0; i < n; i++)
    x[i] = Console.ReadLine()[0];
for (int i = 0; i < n; i++)
    if (i % 2 == 1)
    {
        m[j] = x[i];
        j++;
    }
for (int i = 0; i < m.Length; i++)
    Console.Write(m[i]);

//279
int n = int.Parse(Console.ReadLine());
char[] m = new char[n];
char[] x = new char[n];
int j = 0;
for (int i = 0; i < n; i++)
    x[i] = Console.ReadLine()[0];
for (int i = 0; i < n; i++)
    if (x[i] > 'k')
    {
        m[j] = x[i];
        j++;
    }
for (int i = 0; i < m.Length; i++)
    Console.Write(m[i]);

//280
int n = int.Parse(Console.ReadLine());
char[] m = new char[n * 2];
char[] x = new char[n];
int j = 0;
for (int i = 0; i < n; i++)
    x[i] = Console.ReadLine()[0];
for (int i = 0; i < n; i++)
    if (x[i] == 'f')
    {
        m[j] = x[i];
        j++;
        m[j] = x[i];
        j++;

    }
    else
    {
        m[j] = x[i];
        j++;
    }
for (int i = 0; i < m.Length; i++)
    Console.Write(m[i]);