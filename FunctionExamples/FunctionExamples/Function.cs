using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace FunctionExamples
{
    public class Function
    {
        public int SumAndAvg(int x,int y, ref int avg,ref int prod,out int big)
        {
            avg=(x+y)/2;
            prod = x * y;
            big=(x>y)?x:y;
            return x+y;
        }
    }
}
