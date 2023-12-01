using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines(@"C:\Users\Erikf\OneDrive\Dokument\MEGAsync\prog\aoc\2023\1\input.txt");
            string[] solved = new string[input.Length];
            int count = 0;
            bool solved1 = false;
            bool solved2 = false;
            int whichchar = 0;
            int result = 0;
            foreach (string line in input)
            {
                whichchar = 0;
                while (!solved1)
                {
                    if ("123456789".Any(digit => input[count].Substring(whichchar, 1) == digit.ToString())) 
                    {
                        solved[count] += input[count].Substring(whichchar, 1);
                        solved1 = true;
                    }
                    whichchar++;
                }
                whichchar = 0;
                while (!solved2)
                {
                    string reversedLine = new string(input[count].Reverse().ToArray());

                    if ("123456789".Any(digit => reversedLine.Substring(whichchar, 1) == digit.ToString()))
                    {
                        solved[count] += reversedLine.Substring(whichchar, 1);
                        solved2 = true;
                    }

                    whichchar++;
                }
                count++;
                solved1 = false;
                solved2 = false;
            }

            foreach (string line in solved)
            {
                result += Int32.Parse(line);
            }

            Console.WriteLine(result);
            Console.ReadLine();
        }

    }
}

