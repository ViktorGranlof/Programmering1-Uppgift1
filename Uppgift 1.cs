﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_1
{
    class Program
    {
        static void Main(string[] args)
        {
            char V = 'V';
            char G = 'G';
            float Viktor = 4.5F;
            int Hej = 5;
            int[] myArray = new int[10];
            for (int i = 0; i < 10; i++)
            {
                myArray[i] = i;
            }
            foreach (int number in myArray)
            {
                Console.WriteLine(number);
            }
            if (Viktor < 4)
            {
                Console.WriteLine("Float är mindre än 4.5");
            }
            else if (Viktor == 4.5F)
            {
                Console.WriteLine("Float är lika med 4.5");
            }
            else
            {
                Console.WriteLine("Float är större än 4.5");
            }
            Console.Write(V);
            Console.Write(G);
            Console.ReadLine();
        }
    }
}