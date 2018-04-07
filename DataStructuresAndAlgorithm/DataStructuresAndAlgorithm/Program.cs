using DataStructuresAndAlgorithm.Implementations;
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
            int[] arrayOfIntegers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            arrayProcessing.ReverseArrayInASingleSpaceSeparatedIntegers(arrayOfIntegers);

            Console.ReadLine();
        }
    }
}
