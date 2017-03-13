using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ').ToArray();
        string first = input[0];
        string second = input[1];
        Dictionary<char, char> checker = new Dictionary<char, char>();
        if (first.Length == second.Length)
        {
            bool equal = true;
            for (int i = 0; i < first.Length; i++)
            {
                if (checker.ContainsKey(first[i]) == false)
                {
                    checker.Add(first[i], second[i]);
                }
                else
                {
                    if (second[i] != checker[first[i]])
                    {
                        equal = false;
                        break;
                    }
                }
            }
            if (equal)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
        else
        {
            if (first.Length < second.Length)
            {
                string secondShort = second.Substring(0, first.Length);
                bool equal = true;
                for (int i = 0; i < first.Length; i++)
                {
                    if(checker.ContainsKey(first[i]) == false)
                        {
                            checker.Add(first[i], second[i]);
                        }
                    else
                    {
                        if (second[i] != checker[first[i]])
                        {
                            equal = false;
                            break;
                        }
                    }
                }
                if (equal)
                {
                    for (int i = first.Length; i < second.Length; i++)
                    {
                        if ( secondShort.Contains(second[i]) == false)
                        {                           
                            equal = false;
                            break;
                        }
                    }
                }
                if (equal)
                {
                    
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
            else
            {
                string firstShort = first.Substring(0, second.Length);
                bool equal = true;

                for (int i = 0; i < second.Length ; i++)
                {
                    if (checker.ContainsKey(first[i]) == false)
                    {
                        checker.Add(first[i], second[i]);
                    }
                    else
                    {
                        if (second[i] != checker[first[i]])
                        {
                            equal = false;
                            break;
                        }
                    }
                }
                if (equal)
                {
                    for (int i = second.Length; i < first.Length; i++)
                    {
                        if ( firstShort.Contains(first[i]) == false)
                        {
                            equal = false;
                            break;
                        }
                    }
                }               
                if (equal)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }
    }
}

