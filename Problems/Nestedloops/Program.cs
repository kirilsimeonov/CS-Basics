﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scribble
{
    class Program
    {
        static void Main(string[] args)
        {
            int L = int.Parse(Console.ReadLine());

            for (char z = 'a'; z <= (char)(96 + L); z++)
            {
                Console.WriteLine(z);
            }
        }
    }
}
