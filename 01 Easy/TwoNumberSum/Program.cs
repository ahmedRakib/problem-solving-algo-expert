using System;
using System.Collections.Generic;

namespace TwoNumberSum
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] nums = new int[] { 3,2,4 };

            //int[] nums = new int[] { 1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1 };
            int[] result = new int[2];
           
            int target = 6;

            #region using hashmap
            //var tempResult = new Dictionary<int, int>();
            //tempResult.Add(nums[0], 0);
            //for (int i = 1; i < nums.Length; i++)
            //{
            //    int temp = target - nums[i];
            //    if (tempResult.ContainsKey(temp))
            //    {
            //        tempResult.TryGetValue(temp, out result[0]);
            //        result[1] = i;
            //        break;
            //    }
            //    else
            //    {
            //        if (!tempResult.ContainsKey(nums[i]))
            //        {
            //            tempResult.Add(nums[i], i);
            //        }
            //    }
            //}
            #endregion

            #region using sorting and pointer
            //to keep track of the index of original array
            int[] clonedNums = (int[])nums.Clone();
            Array.Sort(clonedNums);
            int x = 0; int y = nums.Length - 1;

            for (int i = 0; i < nums.Length; i++)
            {
                int tempSum = clonedNums[x] + clonedNums[y];
                if (tempSum == target)
                {
                    result[0] = Array.IndexOf(nums, clonedNums[x]);
                    //if the array contains same value, then to restrict to return the same index again 
                    nums[result[0]] = int.MinValue;
                    result[1] = Array.IndexOf(nums, clonedNums[y]);
                    nums[result[1]] = int.MinValue;
                    break;
                }
                else if (tempSum < target)
                {
                    x++;
                }
                else if (tempSum > target)
                {
                    y--;
                }
            }
            #endregion

            Console.WriteLine("[" + result[0].ToString() + " , " + result[1].ToString() + "]");
        }
    }
}
