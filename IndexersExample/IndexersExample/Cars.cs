using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexersExample
{
    public class CarParts
    {
        public string Name { get; set; }
        public string Part1 { get; set; }
        public string Part2 { get; set; }
        public string Part3 { get; set; }
        public string Part4 { get; set; }
    }

    public class Cars
    {
        CarParts[] parts = new CarParts[5];

        public CarParts this[int index]
        {
            get => parts[index];
            set => parts[index] = value;
        }


    }
}



