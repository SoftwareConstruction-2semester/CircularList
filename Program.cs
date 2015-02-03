using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularList
{
    class Program
    {
        private static void Main(string[] args)
        {
            //UseCircularIntList();

            CircularList<String> list = new CircularList<String>();
            list.Add("Ebbe");
            list.Add("Liv");
            list.Add("Mik");

            Console.WriteLine(list.Current());
            list.Next();

            Console.WriteLine(list.Current());
            list.Next();

            Console.WriteLine(list.Current());
            list.Next();

            Console.WriteLine(list.Current());
            list.Next();

            Console.WriteLine("=== Testing foreach ===");
            foreach (var s in list)
            {
                Console.WriteLine(s);
            }
        }

        private static void UseCircularIntList()
        {
            CircularIntList list = new CircularIntList();
            Console.WriteLine(list.Current().ToString());

            list.Add(3);
            Console.WriteLine(list.Current());

            list.Add(2);
            list.Add(1);

            Console.WriteLine(list.Current());
            list.Next();

            Console.WriteLine(list.Current());
            list.Next();

            Console.WriteLine(list.Current());
            list.Next();

            Console.WriteLine(list.Current());
            list.Next();

            Console.WriteLine(list.Current());
            list.Next();

            Console.WriteLine(list.Current());
            list.Next();


            Console.WriteLine("=== Testing foreach ===");
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}
