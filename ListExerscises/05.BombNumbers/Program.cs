using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] bombs= Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int bomb = bombs[0];
            int power = bombs[1];
            List<int> answer = input;
            List<int> indexes = new List<int>();
            int output = 0;
            for (int i = 0; i < input.Count; i++)
            {
                if (bomb == input[i])
                {    
                    if(answer.Count-i>power&&i>=power)                
                        answer.RemoveRange(i-power,2*power+1);
                    else if(answer.Count - i > power && i < power)
                    {
                        int count =2*power+1-Math.Abs( i - power);
                        answer.RemoveRange(0,count);
                    }
                    else
                    {
                        answer.RemoveRange(i - power, answer.Count - (i - power));
                        i =0;
                    }                  
                }
            }
            answer.Remove(bomb);
            output += answer.Sum();
            Console.WriteLine(output);
            }
           
        }
    }

