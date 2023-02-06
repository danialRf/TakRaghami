using System;
using System.Collections.Generic;

namespace TakRaghami
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = Convert.ToInt32(Console.ReadLine());
            int i = Method(a);
            while (i>10)
            {
                i = Method(i);
            }

            Console.WriteLine(i);



        }
        public static int Method(int a)
        {
            List<int> n = new List<int>();

            while (a != 0)
            {
                n.Add(a % 10);
                a = a / 10;
            }
            int i = 0;

            for (int j = 0; j < n.Count; j++)
            {
                i = i + n[j];

            }
            return i;
        }
    }

}
