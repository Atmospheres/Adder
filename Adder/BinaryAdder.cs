using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adder
{
    class BinaryAdder
    {
        public BinaryAdder() { }

        public int GetInputInt()
        {
            Console.WriteLine("Please enter an integer.");
            int inputInt = 0;
            bool inputBool = false;
            while (inputBool == false)
            {
                inputBool = Int32.TryParse(Console.ReadLine(), out inputInt);
            }
            return inputInt;
        }
        public List<bool> ConvertIntToBinary(int InputInt)
        {
            List<bool> currentBoolList = new List<bool>();
            while(InputInt > 0)
                for(int power = 31; power >= 0; power--)
                {
                    if(InputInt >= Math.Pow(2, power))
                    {
                        currentBoolList.Add(true);
                        InputInt = Convert.ToInt32(InputInt - Math.Pow(2, power));
                    }
                    else
                    {
                        currentBoolList.Add(false);
                    }
                }
            return currentBoolList;
        }

        public List<bool> AddBinary(List<bool> BinaryListOne , List<bool> BinaryListTwo)
        {
            List<bool> boolListOneAddTwo = new List<bool>(32);
            boolListOneAddTwo.AddRange(new bool[32]);
            int boolTrueCounter = 0;
            for(int index = 31; index>=0; index--)
            {
                if(BinaryListOne[index] == true)
                {
                    boolTrueCounter += 1;
                }
                if(BinaryListTwo[index] == true)
                {
                    boolTrueCounter += 1;
                }
                switch(boolTrueCounter)
                {
                    case 0:
                        boolListOneAddTwo[index] = false;
                        break;
                    case 1:
                        boolListOneAddTwo[index] = true;
                        boolTrueCounter -= 1;
                        break;
                    case 2:
                        boolListOneAddTwo[index] = false;
                        boolTrueCounter -= 1;
                        break;
                    case 3:
                        boolListOneAddTwo[index] = true;
                        boolTrueCounter -= 2;
                        break;
                    default:
                        break;
                        
                }
            }
            return boolListOneAddTwo;
        }
        public List<bool> AndAddBinary(List<bool> BinaryListOne, List<bool> BinaryListTwo)
        {
            List<bool> boolListOneAddTwo = new List<bool>(32);
            boolListOneAddTwo.AddRange(new bool[32]);
            
            for (int index = 31; index >= 0; index--)
            {
                int boolTrueCounter = 0;
                if (BinaryListOne[index] == true)
                {
                    boolTrueCounter += 1;
                }
                if (BinaryListTwo[index] == true)
                {
                    boolTrueCounter += 1;
                }
                switch (boolTrueCounter)
                {
                    case 0:
                        boolListOneAddTwo[index] = false;
                        break;
                    case 1:
                        boolListOneAddTwo[index] = false;
                        break;
                    case 2:
                        boolListOneAddTwo[index] = true;
                        break;
                    default:
                        break;

                }
            }
            return boolListOneAddTwo;
        }
        public List<bool> OrAddBinary(List<bool> BinaryListOne, List<bool> BinaryListTwo)
        {
            List<bool> boolListOneAddTwo = new List<bool>(32);
            boolListOneAddTwo.AddRange(new bool[32]);

            for (int index = 31; index >= 0; index--)
            {
                int boolTrueCounter = 0;
                if (BinaryListOne[index] == true)
                {
                    boolTrueCounter += 1;
                }
                if (BinaryListTwo[index] == true)
                {
                    boolTrueCounter += 1;
                }
                switch (boolTrueCounter)
                {
                    case 0:
                        boolListOneAddTwo[index] = false;
                        break;
                    case 1:
                        boolListOneAddTwo[index] = true;
                        break;
                    case 2:
                        boolListOneAddTwo[index] = true;
                        break;
                    default:
                        break;

                }
            }
            return boolListOneAddTwo;
        }
        public void PrintBoolList(List<bool> BoolList)
        {
            for (int index = 0; index <= 31; index++)
            {

                if (BoolList[index] == false)
                {
                    Console.Write("0");
                }
                else if (BoolList[index] == true)
                {
                    Console.Write("1");
                }
            }
            Console.WriteLine();
        }

        public int ConvertBinaryToInt(List<bool> BinaryList)
        {
            int power = 0;
            int convertedInt = 0;
            for (int index = 31; index >= 0; index--)
            {
                if (BinaryList[index] == true)
                {
                convertedInt += Convert.ToInt32(Math.Pow(2, power));
                power += 1;
                }
                else
                {
                    power += 1;
                }
            }
            return convertedInt;
        }
        public void WriteInt(int Int)
        {
            Console.WriteLine(Int);
        }
    }
}
