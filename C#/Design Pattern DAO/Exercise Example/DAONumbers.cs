using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Example
{
    internal class DAONumbers:IDAO
    {
        
        Random r=new Random();
        //all the signatures get implemented in the classes that inherit his methods
        public int ReadRandomValueFromArray1(int[]array1)
        {
            int randomValue=r.Next(0,array1.Length);
            return array1[randomValue];
            
        }

        public int ReadRandomValueFromArray2(int[]array2)
        {
            int randomValue = r.Next(0, array2.Length);
            return array2[randomValue];
        }

        public int SumBothArray(int[] array1, int[]array2)
        {
            int sum = 0;
            foreach (int i in array1)
            {
                sum += i;
            }
            foreach (int i in array2)
            {
                sum += i;
            }
            return sum;
        }
        public string PrintFirstArray(int[] array1)
        {
            string ris="";
            foreach (int i in array1)
            {
                ris += i + ", ";
            }
            return ris;
        }
        public string PrintSecondArray(int[] array2)
        {
            string ris= "";
            foreach (int i in array2)
            {
                ris += i + ", ";
            }
            return ris;
        }
    }
}
