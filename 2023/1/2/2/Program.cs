using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Program
    {
            static void Main(string[] args)
            {
                string[] input = File.ReadAllLines(@"C:\Users\Erikf\OneDrive\Dokument\MEGAsync\prog\aoc\2023\1\input2.txt");
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
                    try { 
                        if (input[count].Substring(whichchar, 3) == "one")
                    {
                        solved[count] += "1";
                        break;
                    }
                    } 
                    catch { }
                    try { 
                        if (input[count].Substring(whichchar, 3) == "two")
                    {
                        solved[count] += "2";
                        break;
                    }
                    }
                    catch { }
                    try { 
                    if (input[count].Substring(whichchar, 3) == "three")
                    {
                        solved[count] += "3";
                        break;
                    }
                    }
                    catch { }
                    try { 
                    if (input[count].Substring(whichchar, 3) == "four")
                    {
                        solved[count] += "4";
                        break;
                    }
                    }
                    catch { }
                    try { 
                    if (input[count].Substring(whichchar, 3) == "five")
                    {
                        solved[count] += "5";
                        break;
                    }
                    }
                    catch { }
                    try { 
                    if (input[count].Substring(whichchar, 3) == "six")
                    {
                        solved[count] += "6";
                        break;
                    }
                    }
                    catch { }
                    try { 
                    if (input[count].Substring(whichchar, 3) == "seven")
                    {
                        solved[count] += "7";
                        break;
                    }
                    }
                    catch { }
                    try { 
                    if (input[count].Substring(whichchar, 3) == "eight")
                    {
                        solved[count] += "8";
                        break;
                    }
                    }
                    catch { }
                    try { 
                    if (input[count].Substring(whichchar, 3) == "nine")
                    {
                        solved[count] += "9";
                        break;
                    }
                    }
                    catch { }
                    try { 
                    if (input[count].Substring(whichchar, 3) == "zero")
                    {
                        solved[count] += "0";
                        break;
                    }
                    }
                    catch { }
                    if ("0123456789".Any(digit => input[count].Substring(whichchar, 1) == digit.ToString()))
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
                    try { 
                    if (reversedLine.Substring(whichchar, 3) == "eno")
                    {
                        solved[count] += "1";
                        break;
                    }
                    }
                    catch { }
                    try { 
                    if (reversedLine.Substring(whichchar, 3) == "owt")
                    {
                        solved[count] += "2";
                        break;
                    }
                    }
                    catch { }
                    try { 
                    if (reversedLine.Substring(whichchar, 3) == "eerht")
                    {
                        solved[count] += "3";
                        break;
                    }
                    }
                    catch { }
                    try { 
                    if (reversedLine.Substring(whichchar, 3) == "ruof")
                    {
                        solved[count] += "4";
                        break;
                    }
                    }
                    catch { }
                    try { 
                    if (reversedLine.Substring(whichchar, 3) == "evif")
                    {
                        solved[count] += "5";
                        break;
                    }
                    }
                    catch { }
                    try { 
                    if (reversedLine.Substring(whichchar, 3) == "xis")
                    {
                        solved[count] += "6";
                        break;
                    }
                    }
                    catch { }
                    try { 
                    if (reversedLine.Substring(whichchar, 3) == "neves")
                    {
                        solved[count] += "7";
                        break;
                    }
                    }
                    catch { }
                    try { 
                    if (reversedLine.Substring(whichchar, 3) == "thgie")
                    {
                        solved[count] += "8";
                        break;
                    }
                    }
                    catch { }
                    try { 
                    if (reversedLine.Substring(whichchar, 3) == "enin")
                    {
                        solved[count] += "9";
                        break;
                    }
                    }
                    catch { }
                    try { 
                    if (reversedLine.Substring(whichchar, 3) == "orez")
                    {
                        solved[count] += "0";
                        break;
                    }
                    }
                    catch { }

                    if ("0123456789".Any(digit => reversedLine.Substring(whichchar, 1) == digit.ToString()))
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

