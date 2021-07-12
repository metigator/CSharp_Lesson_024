using System;
using System.Collections.Generic;

namespace CAGenericDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> action = Print;
            action("Issam");
            Func<int, int, int> addD = Add;
            Console.WriteLine(addD(2,2));
            Predicate<int> predicate = IsEven;
            Console.WriteLine(predicate(3));
            Console.ReadKey();
        }

        static void Print(string name) => Console.WriteLine(name);
        static int Add(int n1, int n2) => n1 + n2;
        static bool IsEven(int n) => n % 2 == 0;
    }
}
