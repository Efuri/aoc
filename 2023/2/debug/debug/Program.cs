using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace debug
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines(@"C:\Users\Erikf\OneDrive\Dokument\MEGAsync\prog\aoc\2023\2\input1.txt");
            int games = 0;
            int red = 0;
            int green = 0;
            int blue = 0;

            foreach (string line in input)
            {
                int colonIndex = line.IndexOf(':');
                string withoutbs = line.Substring(colonIndex + 1, line.Length-colonIndex-1);

                withoutbs = withoutbs.Replace(" ", "");
                string[] splitted = withoutbs.Split(',', ';');
                foreach (string line2 in splitted)
                {
                    Console.WriteLine(line2);
                }
            }
            Console.ReadLine();
        }
    }
}

