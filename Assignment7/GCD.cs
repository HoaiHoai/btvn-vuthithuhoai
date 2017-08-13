//Rextester.Program.Main is the entry point for your code. Don't change it.
//Compiler version 4.0.30319.17929 for Microsoft (R) .NET Framework 4.5

using System;
using System.Collections.Generic;

namespace Rextester
{
    public class Program
    {
        public static int gcd(int a, int b){
            if(b == 0){
                return a;
            }
            else
            {
                return gcd(b, a % b);
            }
        }
        
        public static void Main(string[] args)
        {
            //Your code goes here
            
            List<int> list = new List<int>(new int[]{ 24, 8, 12 });
            // Loop with for and use string interpolation to print values.
            int result = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                result = gcd(result, list[i]);
            }
            Console.WriteLine(result);
        }
    }
}