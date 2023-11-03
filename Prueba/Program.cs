using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = {1, 2, 3, 4, 5};

            int sum = 0;

            for(int i = 0; i < array.Length; i++)
            {
                array[i] = array[i] % 2;
            }

            //d = a > b ? (a > c ? a : c) : (b > c? b : c);
        }
    }
}
