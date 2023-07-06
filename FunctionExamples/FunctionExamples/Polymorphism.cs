using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionExamples
{
    public class Polymorphism
    {
        /// <summary>
        /// To add two integers
        /// </summary>
        /// <param name="x is an integer"></param>
        /// <param name="y is an integer"></param>
        /// <returns>integer</returns>
        public int Add(int x, int y)
        {
            return x + y;
        }
        /// <summary>
        /// To add three values
        /// </summary>
        /// <param name="x is int"></param>
        /// <param name="y is int"></param>
        /// <param name="obj is float"></param>
        /// <returns>integer</returns>
        public object Add(int x,int y, float obj)
        {
            return x + y + obj;
        }
        /// <summary>
        /// To add two floats
        /// </summary>
        /// <param name="x is float"></param>
        /// <param name="y is float"></param>
        /// <returns>integer</returns>
        public int Add(float x, float y) {
            return (int)(x + y);

        }
        /// <summary>
        /// To add three numbers
        /// </summary>
        /// <param name="x is int"></param>
        /// <param name="y is int"></param>
        /// <param name="z is int"></param>
        /// <returns>integer</returns>
        public float Add(int x,int y, int z)
        {
            return x + y + z;
        }


      
    }
    public class KingsMan
    {
        public virtual string GetAgentName()
        {
            return "Fedrick";
        }
    }

    public class Intern : KingsMan
    {
        public override string GetAgentName()
        {
            return "Becky";
        }
    }
}
