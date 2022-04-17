﻿using System;

namespace ValidateSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] nums = new int[] { 5, 1, 22, 25};
            int[] nums = new int[] { 5, 1, 22, 25, 6, -1, 8, 10 };
            var subSequence = new int[] { 1, 22,5, 6, -1, 8 };
            var result = ValidateSubsequence(nums, subSequence);

            Console.WriteLine(result.ToString());
        }

        private static bool ValidateSubsequence(int[] array, int[] subSequence)
        {
            bool result = false;
            int indexToStart = 0;
            for (int i = 0; i < subSequence.Length; i++)
            {
                for(int j = indexToStart; j < array.Length; j++)
                {
                    if(subSequence[i] == array[j])
                    {
                        indexToStart = j;
                        result = true;
                        break;
                    }
                    else
                    {
                        result = false;
                    }
                }

                if(result == false)
                {
                    break;
                }
            }

            return result;
        }
    }
}