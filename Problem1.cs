using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projecteuler
{
    internal class Problem1
    {
        public static int SumOfMultiplesOf3or5()
        {
            int sum = 0;
            for (int loop = 1; loop < 1000; loop++)
            {
                if(loop%3==0 || loop % 5 == 0)
                {
                    sum += loop;
                }
            }
            return sum;
        }
    }
}
