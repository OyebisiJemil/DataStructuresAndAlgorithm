using DataStructuresAndAlgorithm.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithm.Implementations
{
    public class ArrayProcessing:IArrayProcessing
    {
        public void ReverseArrayInASingleSpaceSeparatedIntegers(int[] arrayOfElements)
        {
            int n = arrayOfElements.Length;
            List<int> list = new List<int>();

            Console.Write("The reverse of array (");
            foreach (var item in arrayOfElements)
            {
                Console.Write(item + " ");
            }

            while (n != 0)
            {
                list.Add(arrayOfElements[n - 1]);
                n--;
            }

            Console.Write(") is  (");
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.Write(")");
        }

        public void MaxOfHourGlasses(int[][] array)
        {
            int sum = 0;
            int max = 0;
            
            Console.WriteLine("The max of the sum of 6 by 6 array of hourglass \n");
            for (int row = 0; row < 6; row++)
            {
                for (int col = 0; col < 6; col++)
                {
                    Console.Write(array[row][col]+" ");
                }
                Console.WriteLine();
            }

            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    sum = array[row][col] + array[row][col + 1] + array[row][col + 2]
                                         + array[row + 1][col + 1]
                          + array[row + 2][col] + array[row + 2][col + 1] + array[row + 2][col + 2];
                 
                    if (sum > max)
                    {
                        max = sum;
                    }                   
                }
            }
            Console.WriteLine("\nis: {0}",max);
        }
    }
}
