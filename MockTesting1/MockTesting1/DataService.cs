using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockTesting1
{
    public class DataService : IDataService
    {


        public List<Student> GetStudentsData()
        {
            List<Student> list = new List<Student>();
            list.Add(new Student() { RoleNo = 1, Name = "classy" });
            list.Add(new Student() { RoleNo = 2, Name = "glossy" });
            list.Add(new Student() { RoleNo = 3, Name = "messy" });
            list.Add(new Student() { RoleNo = 4, Name = "fussy" });
            return list;
        }
    }
}
