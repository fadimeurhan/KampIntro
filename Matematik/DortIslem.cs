﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    internal class DortIslem
    {
        public void Topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("sonuç :" + toplam);
        
            


        }

        public void cikar (int sayi1, int sayi2)
        {
            int cikar = sayi1 - sayi2;
            Console.WriteLine("sonuç : " + cikar);
        }


    }
}
