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
            

            while (n != 0)
            {
                list.Add(arrayOfElements[n - 1]);
                n--;
            }

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
        }
    }
}
