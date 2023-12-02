using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace day2part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines(@"C:\Users\Erikf\OneDrive\Dokument\MEGAsync\prog\aoc\2023\2\input1.txt");
            int result = 0;
            int red = 0;
            int green = 0;
            int blue = 0;

            foreach (string line in input)
            {
                int colonIndex = line.IndexOf(':');
                string withoutbs = line.Substring(colonIndex + 1, line.Length - colonIndex - 1);
                withoutbs = withoutbs.Replace(" ", "");
                string[] splitted = withoutbs.Split(',', ';');
                foreach (string line2 in splitted)
                {
                    int i = int.Parse(string.Concat(line2.Where(Char.IsDigit)));
                    if (line2.Contains("red") && int.Parse(string.Concat(line2.Where(Char.IsDigit))) > red)
                    {
                        red = int.Parse(string.Concat(line2.Where(Char.IsDigit)));

                    }
                    if (line2.Contains("green") && int.Parse(string.Concat(line2.Where(Char.IsDigit))) > green)
                    {

                        green = int.Parse(string.Concat(line2.Where(Char.IsDigit)));

                    }
                    if (line2.Contains("blue") && int.Parse(string.Concat(line2.Where(Char.IsDigit))) > blue)
                    {
                        blue = int.Parse(string.Concat(line2.Where(Char.IsDigit)));
                    }
                }
            }
            result += red + green + blue;
            red = 0;
            green = 0; 
            blue = 0;
            Console.WriteLine(result);
        }
    }
}
