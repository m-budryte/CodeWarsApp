using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWarsApp
{
    public static class EqualSidesOfArrayExercise
    {
        public static int FindEvenIndex(int[] arr)
        {
            var rightSum = arr.Sum();
            List<int> leftList = new List<int>();
            
            for (int i = 0; i < arr.Length; i++)
            {
                var currentNumber = arr[i];
                var leftSum = leftList.Sum();
                
                if (rightSum - currentNumber - 2*leftSum == 0)
                {
                    return i;
                }
                
                leftList.Add(currentNumber);
            }

            return -1;
        }
        
    }

}