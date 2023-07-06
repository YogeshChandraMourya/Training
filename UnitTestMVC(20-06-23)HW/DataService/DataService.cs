using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataService
{
    public class DatabaseConnector : IDatabaseConnector
    {
        List<UserObj> userList = new List<UserObj>();
        public DatabaseConnector()
        {
            userList.Add(new UserObj() { Id = 1, Name = "Hulk" });
            userList.Add(new UserObj() { Id = 2, Name = "IronMan" });
            userList.Add(new UserObj() { Id = 3, Name = "CaptainAmerica" });
            userList.Add(new UserObj() { Id = 4, Name = "Hawkeye" });
            userList.Add(new UserObj() { Id = 5, Name = "Thor" });
            userList.Add(new UserObj() { Id = 6, Name = "BlackWidow" });
            userList.Add(new UserObj() { Id = 7, Name = "Vision" });
        }
        public string GetMessageFromMsgTbl()
        {
            return "I hereby Command MVC Assemble lets rock and roll";
        }
        public string ElevateMsg(string userID)
        {
            string result = "user Not found";
            try
            {
                string foundHero = userList.Where(u => u.Id.ToString().Equals(userID)).First().Name;
                result = "The Hero " + foundHero +" is back";
            }
            catch(Exception)
            {

            }
            return result;
        }
    }
}
