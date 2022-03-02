
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hovo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input: error = ");
            string a = Console.ReadLine();

            switch (a)
            {
                case "CompilerError":
                    Console.Write(error.CompilerError);
                    Console.WriteLine(" " + (int)error.CompilerError);
                    break;
                case "ArgumentException":
                    Console.Write(error.ArgumentException);
                    Console.WriteLine(" " + (int)error.ArgumentException);
                    break;
                case "EmployeeListNotFoundException":
                    Console.Write(error.EmployeeListNotFoundException);
                    Console.WriteLine(" " + (int)error.EmployeeListNotFoundException);
                    break;
                case "InvalidOperationException":
                    Console.Write(error.InvalidOperationException);
                    Console.WriteLine(" " + (int)error.InvalidOperationException);
                    break;
                case "FileNotFoundException":
                    Console.Write(error.FileNotFoundException);
                    Console.WriteLine(" " + (int)error.FileNotFoundException);
                    break;
                case "NullReferenceException":
                    Console.Write(error.NullReferenceException);
                    Console.WriteLine(" " + (int)error.NullReferenceException);
                    break;
                case "SomeSpecificException":
                    Console.Write(error.SomeSpecificException);
                    Console.WriteLine(" " + (int)error.SomeSpecificException);
                    break;
                case "StackOverflowException":
                    Console.Write(error.StackOverflowException);
                    Console.WriteLine(" " + (int)error.StackOverflowException);
                    break;
                case "SystemIndexOutOfRangeException":
                    Console.Write(error.SystemIndexOutOfRangeException);
                    Console.WriteLine(" " + (int)error.SystemIndexOutOfRangeException);
                    break;
                case "UnauthorizedAccessException":
                    Console.Write(error.UnauthorizedAccessException);
                    Console.WriteLine(" " + (int)error.UnauthorizedAccessException);
                    break;
                default: 
                    Console.WriteLine("not found error!"); 
                    break;
            } 
        }
        enum error
        {
            CompilerError = 9,
            SystemIndexOutOfRangeException = 5,
            StackOverflowException = 8,
            UnauthorizedAccessException = 10,
            NullReferenceException = 9,
            SomeSpecificException = 9,
            InvalidOperationException = 4,
            EmployeeListNotFoundException = 8,
            FileNotFoundException = 6,
            ArgumentException = 10,
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alisa
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Foo(n));
            Console.ReadKey();
        }
        public static int Foo(int n)
        {
            if (n == 1)
                return 0;
            else if (n == 2)
                return 1;

            int i = Foo(n - 1) + Foo(n - 2);
            return i;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace David
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int i = 0;
            Foo(n, i);
            Console.ReadKey();
        }
        public static void Foo(int n, int i)
        {
            if (i <= 10)
            {
                Console.WriteLine($"{n} * {i} = {n * i}");
                Foo(n, i + 1);
            }
        }
    }
}