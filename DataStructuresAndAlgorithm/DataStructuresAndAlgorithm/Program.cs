﻿using DataStructuresAndAlgorithm.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayProcessing arrayProcessing = new ArrayProcessing();
            int input = 0;

            Console.WriteLine("Welcome to Data Structure and Algorithm solution");
            Console.WriteLine("Press 1 for Reversing array");
            Console.WriteLine("Press 2 for Max of hourglass");
            Console.WriteLine("Press 3 for Left rotation of an array");
            Console.WriteLine();//just to leave a line 
            input = int.Parse(Console.ReadLine());
            Console.WriteLine();//just to leave a line 
            switch (input)
            {
                case 1:
                    int[] arrayOfIntegers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                    arrayProcessing.ReverseArrayInASingleSpaceSeparatedIntegers(arrayOfIntegers);
                    break;
                case 2:
                    int[][] array = new int[6][] {
                                                    new int[] {1, 1, 1, 0, 0, 0},
                                                    new int[] {0, 1, 0, 0, 0, 0},
                                                    new int[] {1, 1, 1, 0, 0, 0},
                                                    new int[] {0, 0, 2, 4, 4, 0},
                                                    new int[] {0, 0, 0, 2, 0, 0},
                                                    new int[] {0, 0, 1, 2, 4, 0}
                                                  };

                    arrayProcessing.MaxOfTheSumOfHourGlass(array);
                    break;
                case 3:
                    int[] arrayToRotate = { 1, 2, 3, 4, 5 };
                    Console.WriteLine("Input the number of rotations");
                    int numberOfRotations = int.Parse(Console.ReadLine());
                    arrayProcessing.LeftRotationOfAnArray(arrayToRotate, numberOfRotations);
                    break;
                case 4:
                    string[] strings = { "def", "de","jemil","jemil", "fgh","jemil" };
                    string[] queries = { "de", "lmn", "fgh", "jemil" };
                    arrayProcessing.SparceArrays(strings, queries);
                    break;
                default:
                    Console.WriteLine("Press a valid key between 1 and 2");
                    break;
            }
            // Keep the console window open in debug mode.
            Console.WriteLine("\n Press any key to exit.");
            Console.ReadKey();
        }
    }
}
