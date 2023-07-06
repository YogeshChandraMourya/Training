
// See https://aka.ms/new-console-template for more information
using ParentLib;

Console.WriteLine("Hello, World!");


CompanyDetails companyDetails=new CompanyDetails();

companyDetails.GetCompDelegate = new GetCompanyNameDelegate(MyClientFunction);

companyDetails.MyEvent += MyEventExecution;

string MyEventExecution()
{
    return "Your Event Executed";
}

string companyName = companyDetails.Caller();

Console.WriteLine(companyName);

string MyClientFunction()
{
    return "Yogesh Product";
}