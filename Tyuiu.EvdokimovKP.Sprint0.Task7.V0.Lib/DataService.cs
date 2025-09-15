using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.EvdokimovKP.Sprint0.Task7.V0.Lib
{
    public class DataService
    {
        //Пример циклической структыры (цикл с параметрами) for|
        public static int[] AdditionArrays(int[] numOne, int[] numTwo)
        {
            int[] resultArray = new int[5];
            for (var i = 0; 1 < resultArray.Length; i++)
            {
                resultArray[i] = numOne[i] + numTwo[i];
            }
            return resultArray;
        }
    }
}
