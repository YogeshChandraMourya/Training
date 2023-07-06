using Microsoft.AspNetCore.Identity;

namespace MVCApplicationForEvoke.Models
{
    #region draft1
    //public class Student
    //{
    //    public int stu_id { get; set; }
    //    public string stu_name { get; set; }
    //    public int marks { get; set; }

    //}

    //public class PGStudent : Student
    //{

    //    public int semester { get; set; }
    //    public string qualification { get; set; }
    //}
    #endregion

    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Man : Person
    {
        public string PlayingGames { get; set; }
    }

    public class Woman : Person
    {
        public string Dancing { get; set; }
    }
}
