using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Example
{
    internal class Numbers
    {
        //it provides data when the object Number is called
        private int[] array1 = new int[5];
        private int[] array2 = new int[5];

        public int[] Array2 { get => array2; set => array2 = value; }
        public int[] Array1 { get => array1; set => array1 = value; }

        public Numbers(int[] array1, int[] array2)
        {
            Array2 = array2;
            Array1 = array1;
        }

    }
}
