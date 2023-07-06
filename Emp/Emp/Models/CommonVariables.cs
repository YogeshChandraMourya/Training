namespace Emp.Models
{
    public static class CommonVariables
    {
        public  static string conString= "Data Source=YBANALA-L-5498\\SQLEXPRESS;Initial Catalog=Employee;Persist Security Info=True;User ID=sa;Password=Welcome2evoke@1234";
        public static string select = "Select * from EmpTbl";
        public static string insert = $"insert into EmpTbl(Id,Name,Description) values (@Id,@Name,@Description)";
        public static string insert2 = $"insert into CustTbl(CustId,CustType,Address,City,Contact) values(@CustId,@CustType,@Address,@City,@Contact)";
      
    }
}
