using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParentLib
{
    public delegate string GetCompanyNameDelegate();
    public class CompanyDetails
    {
        public event GetCompanyNameDelegate MyEvent;
        public GetCompanyNameDelegate GetCompDelegate { get; set; }

        public string Caller()
        {
            MyEvent();
            return GetCompDelegate();
        }
    }
}
