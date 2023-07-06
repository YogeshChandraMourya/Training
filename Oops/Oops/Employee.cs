using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
   public class MyClass{

        public string Name { get; set; }
        public int Id { get; set; }
        public MyClass()
        {
            string ObjectData = DateTime.Now.ToString(); 
        }
        public MyClass(int Id):this()
        {
            this.Id = Id;
        }
        public MyClass(int Id,string Name):this(Id)
        {
            this.Name= Name;
        }

    }
    
     

}
