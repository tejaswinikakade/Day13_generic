﻿using System;

namespace Generic_day13
{
    class Program
    {
        public static object TC1Integer { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Find Max Value");

            int output = UC1.Maxint(11, 22, 33);
            Console.WriteLine(output);
        }
    }
}
