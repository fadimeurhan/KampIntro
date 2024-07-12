using System;
using System.Collections.Generic;

namespace Kolaksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] {"fadime","fatma","sabri","rıdvan" };

            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);

            List<string> isimler2 = new List <string> { "fadime", "rıdvan" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]); 
            isimler2.Add("urhan");
            Console.WriteLine(isimler2[2]);

        }
    }
}