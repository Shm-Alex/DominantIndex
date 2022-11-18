using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDominantIndex
{
    internal class Program
    {
        public static  int DominantIndex(int[] nums)
        {
            int fistMax,secondMax,maxIndex ;

            if (nums[0] > nums[1])
            {
                fistMax = nums[0];
                secondMax = nums[1];
                maxIndex = 0;
            }
            else
            {
                fistMax = nums[1];
                secondMax = nums[0];
                maxIndex = 1;

            }
            for (int index = 2; index < nums.Length; index++) 
            {if (nums[index] > fistMax)
                {
                    secondMax = fistMax;
                    fistMax = nums[index];
                    maxIndex = index;
                }
                else {
                    if (secondMax < nums[index]) secondMax = nums[index];
                }

            }
            return secondMax+ secondMax<=fistMax?maxIndex:-1;
        }
        static void Main(string[] args)
        {
            //Console.WriteLine(DominantIndex(new int []{ 3,6,1,0}));
            //Console.WriteLine(DominantIndex(new int[] { 1, 2, 3, 4 }));
            Console.WriteLine(DominantIndex(new int[] { 0, 0, 3, 2 }));
            Console.ReadLine();
        }
    }
}
