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
                        if (input[count].Substring(whichchar, 3).Equals("One"))
                    {
                        solved[count] += "1";
                        break;
                    }
                        if (input[count].Substring(whichchar, 3).Equals("Two"))
                    {
                        solved[count] += "2";
                        break;
                    }
                    if (input[count].Substring(whichchar, 3).Equals("Three"))
                    {
                        solved[count] += "3";
                        break;
                    }
                    if (input[count].Substring(whichchar, 3).Equals("Four"))
                    {
                        solved[count] += "4";
                        break;
                    }
                    if (input[count].Substring(whichchar, 3).Equals("Five"))
                    {
                        solved[count] += "5";
                        break;
                    }
                    if (input[count].Substring(whichchar, 3).Equals("Six"))
                    {
                        solved[count] += "6";
                        break;
                    }
                    if (input[count].Substring(whichchar, 3).Equals("Seven"))
                    {
                        solved[count] += "7";
                        break;
                    }
                    if (input[count].Substring(whichchar, 3).Equals("Eight"))
                    {
                        solved[count] += "8";
                        break;
                    }
                    if (input[count].Substring(whichchar, 3).Equals("Nine"))
                    {
                        solved[count] += "9";
                        break;
                    }
                    if (input[count].Substring(whichchar, 3).Equals("Zero"))
                    {
                        solved[count] += "0";
                        break;
                    }
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

                    if (reversedLine.Substring(whichchar, 3).Equals("Eno"))
                    {
                        solved[count] += "1";
                        break;
                    }
                    if (reversedLine.Substring(whichchar, 3).Equals("Owt"))
                    {
                        solved[count] += "2";
                        break;
                    }
                    if (reversedLine.Substring(whichchar, 3).Equals("eerht"))
                    {
                        solved[count] += "3";
                        break;
                    }
                    if (reversedLine.Substring(whichchar, 3).Equals("ruof"))
                    {
                        solved[count] += "4";
                        break;
                    }
                    if (reversedLine.Substring(whichchar, 3).Equals("evif"))
                    {
                        solved[count] += "5";
                        break;
                    }
                    if (reversedLine.Substring(whichchar, 3).Equals("xis"))
                    {
                        solved[count] += "6";
                        break;
                    }
                    if (reversedLine.Substring(whichchar, 3).Equals("neves"))
                    {
                        solved[count] += "7";
                        break;
                    }
                    if (reversedLine.Substring(whichchar, 3).Equals("thgie"))
                    {
                        solved[count] += "8";
                        break;
                    }
                    if (reversedLine.Substring(whichchar, 3).Equals("enin"))
                    {
                        solved[count] += "9";
                        break;
                    }
                    if (reversedLine.Substring(whichchar, 3).Equals("orez"))
                    {
                        solved[count] += "0";
                        break;
                    }

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

