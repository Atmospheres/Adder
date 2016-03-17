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
            List<bool> binaryListOneAndAddTwo = new List<bool>();
            List<bool> binaryListOneOrAddTwo = new List<bool>();
            int inputIntOne;
            int inputIntTwo;
            int convertedInt;
            int convertedAndInt;
            int convertedOrInt;

            inputIntOne = adder.GetInputInt();
            inputIntTwo = adder.GetInputInt();
            binaryListOne = adder.ConvertIntToBinary(inputIntOne);
            binaryListTwo = adder.ConvertIntToBinary(inputIntTwo);
            binaryListOneAddTwo = adder.AddBinary(binaryListOne, binaryListTwo);
            binaryListOneAndAddTwo = adder.AndAddBinary(binaryListOne, binaryListTwo);
            binaryListOneOrAddTwo = adder.OrAddBinary(binaryListOne, binaryListTwo);
            adder.PrintBoolList(binaryListOneAddTwo);
            adder.PrintBoolList(binaryListOneAndAddTwo);
            adder.PrintBoolList(binaryListOneOrAddTwo);
            convertedInt = adder.ConvertBinaryToInt(binaryListOneAddTwo);
            convertedAndInt = adder.ConvertBinaryToInt(binaryListOneAndAddTwo);
            convertedOrInt = adder.ConvertBinaryToInt(binaryListOneOrAddTwo);
            adder.WriteInt(convertedInt);
            adder.WriteInt(convertedAndInt);
            adder.WriteInt(convertedOrInt);

        }
    }
}
