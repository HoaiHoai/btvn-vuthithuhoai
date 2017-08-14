//Rextester.Program.Main is the entry point for your code. Don't change it.
//Compiler version 4.0.30319.17929 for Microsoft (R) .NET Framework 4.5

using System;
using System.Collections.Generic;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Your code goes here
            
            List<int> list = new List<int>(new int[]{ 2, 3, 7 });
            // Loop with for and use string interpolation to print values.
            for (int i = 0; i < list.Count; i++)
            {
                string binary = Convert.ToString(list[i], 2);
                Console.WriteLine(binary);
            }
        }
    }
}