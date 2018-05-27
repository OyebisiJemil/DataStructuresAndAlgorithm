using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithm.Contracts
{
    public interface IArrayProcessing
    {
        void ReverseArrayInASingleSpaceSeparatedIntegers(int[] arrayOfElements);
        void MaxOfTheSumOfHourGlass(int[][] array);
        void LeftRotationOfAnArray(int[] array, int numberOfRotations);
    }
}
