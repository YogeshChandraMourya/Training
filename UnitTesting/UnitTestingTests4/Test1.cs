using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    public class Test1
    {
        public int ans = 0;
        public int Add(int a, int b)
        {
            try
            {
                checked
                {

                    ans = a + b;
                }
                return ans;

            }
            catch(Exception e)
            {
                throw new Exception( e.Message);
            }
           

        }

    }
}
