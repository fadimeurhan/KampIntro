﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class EsnafKredisiManager : IKrediManager
    {
        public void Hesapla()
        {
            throw new NotImplementedException();
        }

        public void Onaylama()
        {
            Console.WriteLine("esnaf kredisi onaylandı.");
        }
    }
}
