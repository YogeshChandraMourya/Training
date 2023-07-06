using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionExamples
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace ConsoleApp4
    {
        public class Guardians
        {
            private string orbplace;
            private string StarLord;
            private string Missionstatus;
            private string Missionaccomplised;


            public Guardians()
            {
                string OrbTime = "135Sec";
            }

            public void FurtherMission()
            {
                // checking the review and updated
                Missionstatus = Missionaccomplised + " Done";
            }
            public void ExMethod()
            {
            }

            //read only property
            public string OrbTime { get; }

            public string GetStarLord()
            {
                return orbplace;
            }

            public void SetStarLord(string value)
            {
                orbplace = "Got" + value;
            }

            public string Missionaccomplished
            {
                set => Missionaccomplised = value;
            }

            public static int Assemble(int a, int b)
            {
                return a + b;

            }

            public int disperse(int a, int b)
            {
                return a / b;
            }



        }
    }
}
