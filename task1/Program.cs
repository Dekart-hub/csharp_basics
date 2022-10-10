using System;
using System.IO;
using System.Text;

namespace HelloWorld
{
    class Program
    {
        public static void Main(string[] args)
        {
            string fileCont = File.ReadAllText(@"../1.dat");
            string[] numSplit = fileCont.Split(new char[]('', '\t', '\r', '\n'), StringSplitOptions.RemoveEmptyEntries);
            int[] integers = new int[numSplit.Length];
            for(int i = 0; i < numSplit.Length; i++)
            {
                integers[i] = int.Parse(numSplit[i]);
            }
            
        }
    }
}