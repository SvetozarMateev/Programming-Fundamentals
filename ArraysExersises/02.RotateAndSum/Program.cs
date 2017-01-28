using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int numberOfRotations = int.Parse(Console.ReadLine());
            int[][] rotations = new int[numberOfRotations][];
            int[] sum = new int[input.Length];


            for (int r = 0; r < numberOfRotations; r++)
            {
                rotations[r] = new int[input.Length];

                for (int i = 0; i < input.Length; i++)
                {
                    if (i == 0)
                    {
                        if(r==0)
                            rotations[r][i] = input[input.Length - 1];
                        else
                        {
                            if(i==0)
                                rotations[r][i] = rotations[r - 1][input.Length-1];
                            else                        
                                rotations[r][i] = rotations[r - 1][i - 1];
                        }

                    }
                    else
                    {
                        if(r==0)
                            rotations[r][i] = input[i - 1];
                        else
                        {
                            rotations[r][i] = rotations[r - 1][i-1];
                        }

                    }

                    sum[i] += rotations[r][i];
                }
                
            }
            Console.WriteLine(string.Join(" ",sum));
        }
    }
}
