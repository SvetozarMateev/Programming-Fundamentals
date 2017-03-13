using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.FoldAndSumm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int k = nums.Count / 4;
            List<int> K1 = nums.Take(k).Reverse().ToList();
            List<int> K2 = nums.Skip(k).Take(2*k-1).ToList();
            List<int> K3 = nums.Skip(2*k).Take(3*k-2).ToList();
            List<int> K4 = nums.Skip(3*k).Take(4*k).Reverse().ToList();
            int[] sum = new int[k];
            int[] sum2 = new int[k];
            for (int i = 0; i < k; i++)
            {
                sum[i] = K1[i] + K2[i];
                sum2[i] = K3[i] + K4[i];
            }
            
            Console.WriteLine(string.Join(" ", sum)+ " " + string.Join(" ", sum2));
        }
    }
}
