using System;

namespace TwoNumberSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] nums = new int[] { 3, 2, 4 };
            int[] nums = new int[] { 3, 5, -4, 8, 11, 1, -1, 6 };

            int[] result = new int[2];

            int target = 10;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        result[0] = i;
                        result[1] = j;
                        break;
                    }
                }
            }

            Console.WriteLine("[" + result[0].ToString() + " , " + result[1].ToString() + "]");
        }
    }
}
