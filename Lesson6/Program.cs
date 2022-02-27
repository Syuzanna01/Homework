//1
using System;
namespace Lesson
{
    class Program
    {
        static void Main()
        {
            foo();
            Console.ReadKey();
        }

        static void foo()
        {
            Console.WriteLine("Welcome Friends!");
            Console.WriteLine("Have a nice day!");
        }
    }
}

//2
using System;
namespace Lesson
{
    class Program
    {
        static void Main()
        {
            string a = string.Format(Console.ReadLine());
            foo(a);
            Console.ReadKey();
        }

        static void foo(string a)
        {
            Console.WriteLine("Welcome friend" + a);
            Console.WriteLine("Have a nice day!");
        }
    }
}

//3
using System;
namespace Lesson
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            foo(a, b);
            Console.ReadKey();
        }

        static void foo(int a, int b)
        {
            Console.WriteLine(a + b);
        }
    }
}

//4
using System;
namespace Lesson
{
    class Program
    {
        static void Main()
        {
            string str = string.Format(Console.ReadLine());
            foo(str);
            Console.ReadKey();
        }

        static void foo(string str)
        {
            int sum = 0;
            for (int i = 0; i < str.Length; i++)
                if (str[i] == ' ')
                    sum++;

            Console.WriteLine(sum);
        }
    }
}

//5
using System;
namespace Lesson
{
    class Program
    {
        static void Main()
        {
            int[] arr = new int[5];
            foo(arr);
            Console.ReadKey();
        }

        static void foo(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
                arr[i] = int.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
                sum += arr[i];

            Console.WriteLine(sum);
        }
    }
}

//6
using System;
namespace Lesson
{
    class Program
    {
        static void Main()
        {
            Console.Write("Input a ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Input b ");
            int b = int.Parse(Console.ReadLine());
            foo(a, b);
            Console.ReadKey();
        }

        static void foo(int a, int b)
        {
            a += b;
            b = a - b;
            a -= b;
            Console.WriteLine($" result: a = {a} b = {b}");
        }
    }
}

//7
using System;
namespace Lesson
{
    class Program
    {
        static void Main()
        {
            Console.Write("Input a ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Input b ");
            int b = int.Parse(Console.ReadLine());
            foo(a, b);
            Console.ReadKey();
        }

        static void foo(int a, int b)
        {
            Console.WriteLine($"result: a^b = {Math.Pow(a, b)}");
        }
    }
}

//8
using System;
namespace Lesson
{
    class Program
    {
        static void Main()
        {
            Console.Write("Input a ");
            int a = int.Parse(Console.ReadLine());
            foo(a);
            Console.ReadKey();
        }

        static void foo(int a)
        {

            int[] arr = new int[a];
            arr[0] = 0;
            arr[1] = 1;
            for (int i = 2; i < arr.Length; i++)
                arr[i] = arr[i - 1] + arr[i - 2];
            for (int i = 0; i < a; i++)
                Console.WriteLine(arr[i]);
        }
    }
}

//9
using System;
namespace Lesson
{
    class Program
    {
        static void Main()
        {
            Console.Write("Input a ");
            int a = int.Parse(Console.ReadLine());
            foo(a);
            if (foo(a) == true)
                Console.WriteLine($"{a}-n baxadryal e");
            else
                Console.WriteLine($"{a}-n parz e");
            Console.ReadKey();
        }

        static bool foo(int a)
        {

            for (int i = 2; i < a / 2; i++)
                if (a % 2 == 0)
                    return true;
            return false;
        }
    }
}

//10
using System;
namespace Lesson
{
    class Program
    {
        static void Main()
        {
            Console.Write("Input a ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(foo(a));
            Console.ReadKey();
        }

        static int foo(int a)
        {
            int sum = 0;
            while (a != 0)
            {
                sum += a % 10;
                a /= 10;
            }
            return sum;
        }
    }
}

//11
using System;
namespace Lesson
{
    class Program
    {
        static void Main()
        {
            Console.Write("Input a ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(foo(a));
            Console.ReadKey();
        }

        static int foo(int a)
        {
            int sum = 1;
            while (a != 0)
            {
                sum *= a;
                a -= 1;
            }
            return sum;
        }
    }
}

//12
using System;
namespace Lesson
{
    class Program
    {
        static void Main()
        {
            Console.Write("Input a ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Input n ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(foo(a, n));
            Console.ReadKey();
        }

        static int foo(int a, int n)
        {
            int sum = 0;
            int[] arr = new int[a];
            arr[0] = 0;
            arr[1] = 1;
            for (int i = 2; i < arr.Length; i++)
                arr[i] = arr[i - 1] + arr[i - 2];
            for (int i = 0; i < a; i++)
                Console.Write($"{arr[i]} ");
            for (int i = 0; i < n; i++)
                sum += arr[i];
            Console.WriteLine();

            return sum;
        }
    }
}