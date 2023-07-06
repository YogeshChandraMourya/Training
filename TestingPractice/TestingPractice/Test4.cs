using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingPractice
{
    public class Test4
    {
        public int Div(int a, int b)
        {
            int ans = 0;
            try
            {
                checked
                {
                    ans = a / b;
                    return ans;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
