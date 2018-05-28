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


        public void MaxOfTheSumOfHourGlass(int[][] array)
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

        public void LeftRotationOfAnArray(int[] array, int numberOfRotations)
        {
            int tempStorage = 0;
            Queue<int> queue = new Queue<int>();
            //Put the elements on queue
            foreach (var item in array)
            {
                queue.Enqueue(item);
            }

            //Rotate the elements based on the number of rotations supplied
            for (int count = 0; count < numberOfRotations; count++)
            {
                //get the element in front of the queue
                tempStorage = queue.Dequeue();

                //add the element to the back of the queue
                queue.Enqueue(tempStorage);
            }

            Console.WriteLine("The array before rotation");
            foreach (var item in array)
            {
                Console.Write(item.ToString() + " ");
            }
            Console.WriteLine();
            //new array after rotation
            Console.WriteLine("The array after rotating it {0} times", numberOfRotations);
            foreach (var item in queue)
            {
                Console.Write(item + " ");
            }
        }

        public void SparceArrays(string[] strings, string[] queries)
        {
            //Given a collection of input strings and a collection of query strings. 
            //For each query string, determine how many times it occurs in the list of input strings.
            Console.WriteLine("Given a collection of input strings and a collection of query strings.");
            Console.WriteLine("This module determine how many times each query string occure in the input string.\n");
            List<int> result = new List<int>();
            foreach (var query in queries)
            {
                int counter = 0;
                foreach (var item in strings)
                {
                    if (query == item)
                    {
                        counter++;
                    }   
                }

                Console.WriteLine(" *{0}* appears {1} times in the input strings", query, counter);
            }
           
        }
    }
}
