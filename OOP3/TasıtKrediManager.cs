﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class TasıtKrediManager : IKrediManager
    {
        public void Hesapla()
        {
            throw new NotImplementedException();
        }

        public void Onaylama()
        {
            Console.WriteLine("taşıt kredisi onaylandı.");
        }
    }
}
