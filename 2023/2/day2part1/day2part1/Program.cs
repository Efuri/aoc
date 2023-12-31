﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace day2part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines(@"C:\Users\Erikf\OneDrive\Dokument\MEGAsync\prog\aoc\2023\2\input1.txt");
            int game = 0;
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
                game += 1;
                bool isOkay = true;
                foreach (string line2 in splitted)
                {
                    int i  = int.Parse(string.Concat(line2.Where(Char.IsDigit)));
                    if (line2.Contains("red") && i > 12)
                    {
                        isOkay = false;
                    }
                    if (line2.Contains("green") && i > 13)
                    {
                        isOkay = false;
                    }
                    if (line2.Contains("blue") && i > 14)
                    {
                        isOkay = false;
                    }
                }
                if (isOkay == true)
                {
                    result += game;
                }
                isOkay = true;
            }
            Console.WriteLine(result);
        }
    }
}
