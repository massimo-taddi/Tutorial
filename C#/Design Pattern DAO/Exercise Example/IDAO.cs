using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Example
{
    public interface IDAO
    {
        //all the methods signature
        public int ReadRandomValueFromArray1(int[] array1);
        public int ReadRandomValueFromArray2(int[] array2);
        public int SumBothArray(int[] array1, int[] array2);
        public string PrintFirstArray(int[] array1);
        public string PrintSecondArray(int[] array2);


    }
}
