using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks
namespace LinearSearch {
    public class LinearSearch
    {
        public static int Search(int[] list, int data)
        {
            for (int i = 0; i < list.Length; i++)
            {
                if (data == list[i]) return i;
            }

            return -1;
        }
    }
}