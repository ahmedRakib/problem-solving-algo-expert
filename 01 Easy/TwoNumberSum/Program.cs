using System;
using System.Collections.Generic;

namespace TwoNumberSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] nums = new int[] { 3, 2, 4 };

           

            int[] nums = new int[] { 1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1 };
            int[] result = new int[2];
            var tempResult = new Dictionary<int, int>();
            tempResult.Add(nums[0], 0);

            int target = 11;

            for (int i = 1; i < nums.Length; i++)
            {
                int temp = target - nums[i];
                if(tempResult.ContainsKey(temp))
                {
                    tempResult.TryGetValue(temp, out result[0]);
                    result[1] = i;
                    break;
                }
                else
                {
                    if(!tempResult.ContainsKey(nums[i]))
                    {
                        tempResult.Add(nums[i], i);
                    }
                }
            }

            Console.WriteLine("[" + result[0].ToString() + " , " + result[1].ToString() + "]");
        }
    }
}
