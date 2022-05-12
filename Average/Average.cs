using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average
{
    public class Average
    {
        public double avg(int[] arr)
        {
            checked
            {
                double sum = 0;

                for (int i = 0; i < arr.Length; i++)

                {
                    sum += arr[i];
                }
                double avg = sum / arr.Length;
                return avg;
            }
        }
    }
}
