using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adder
{
    class Program
    {
        static void Main(string[] args)
        {

            BinaryAdder adder = new BinaryAdder();
            List<bool> binaryListOne = new List<bool>();
            List<bool> binaryListTwo = new List<bool>();
            List<bool> binaryListOneAddTwo = new List<bool>();
            int inputIntOne;
            int inputIntTwo;
            int convertedInt;

            inputIntOne = adder.GetInputInt();
            inputIntTwo = adder.GetInputInt();

            binaryListOne = adder.ConvertIntToBinary(inputIntOne);
            binaryListTwo = adder.ConvertIntToBinary(inputIntTwo);

            binaryListOneAddTwo = adder.AddBinary(binaryListOne, binaryListTwo);

            adder.PrintBoolList(binaryListOneAddTwo);
            convertedInt = adder.ConvertBinaryToInt(binaryListOneAddTwo);
            Console.WriteLine();
            Console.WriteLine(convertedInt);
        }
    }
}
