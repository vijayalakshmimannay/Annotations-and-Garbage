﻿// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
namespace GarbageCollection
{
    internal class Program
    {
        static void Main()
        {
            long mem1 = GC.GetTotalMemory(false);
            {
                int[] values = new int[50000];
                values = null;
            }
            long mem2 = GC.GetTotalMemory(false);
            {
                GC.Collect();
            }
            long mem3 = GC.GetTotalMemory(false);
            {
                Console.WriteLine(mem1);
                Console.WriteLine(mem2);
                Console.WriteLine(mem3);
            }
        }
    }
}
