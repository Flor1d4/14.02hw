using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._02
{
    internal class Program
    {
        #region 1
        public interface ICalc
        {
            int Less(int valueToCompare);
            int Greater(int valueToCompare);
        }
        public class MyArray : ICalc
        {
            private int[] func;

            public MyArray(int[] func)
            {
                this.func = func;
            }

            public int Less(int valueToCompare)
            {
                int count = 0;
                foreach (int item in func)
                {
                    if (item < valueToCompare)
                    {
                        count++;
                    }
                }
                return count;
            }

            public int Greater(int valueToCompare)
            {
                int count = 0;
                foreach (int item in func)
                {
                    if (item > valueToCompare)
                    {
                        count++;
                    }
                }
                return count;
            }
            #endregion
            #region 3
            interface ICalc2
            {
                int CountDistinct();
                int EqualToValue(int valueToCompare);
            }

            class Array : ICalc2
            {
                private int[] func2;

                public Array(int[] func2)
                {
                    this.func2 = func2;
                }

                public int CountDistinct()
                {
                    HashSet<int> distinctValues = new HashSet<int>(func2);
                    return distinctValues.Count;
                }

                public int EqualToValue(int valueToCompare)
                {
                    int count = 0;
                    foreach (int value in func2)
                    {
                        if (value == valueToCompare)
                        {
                            count++;
                        }
                    }
                    return count;
                }
                #endregion
                #region Main
                static void Main(string[] args)
                {
                    int[] testfunc = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                    MyArray myArr = new MyArray(testfunc);
                   int lessCount = myArr.Less(7);
                    int greaterCount = myArr.Greater(8);
                    Console.WriteLine("Less than 7: " + lessCount);
                    Console.WriteLine("Greater than 8: " + greaterCount);

                    Console.WriteLine("------------");

                    int[] testfunc2 = { 10, 7, 8, 2, 6, 8, 10, 4, 5, 1, 7, 8, 3, 1, 4, 7, 9, 3, 7 };
                    Array myArr2 = new Array(testfunc2);
                    Console.WriteLine("Distinct values: " + myArr2.CountDistinct());
                    int valueToCompare = 7;
                    Console.WriteLine("Values equal to " + valueToCompare + ": " + myArr2.EqualToValue(valueToCompare));
                    valueToCompare = 8;
                    Console.WriteLine("Values equal to " + valueToCompare + ": " + myArr2.EqualToValue(valueToCompare));
                }
                #endregion

            }

        }
    }
}