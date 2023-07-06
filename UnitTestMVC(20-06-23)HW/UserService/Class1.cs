using DataService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UserService
{
    public class UserMessageService : IUserMessageService
    {
        private readonly IDatabaseConnector _dataservice;
        public UserMessageService(IDatabaseConnector dataService)
        {
            _dataservice = dataService;
        }
        public string GetMessageFromDB()
        {
            string msg = _dataservice.GetMessageFromMsgTbl();
            return msg;
        }
        public string GetElevationFromDB(string userID)
        {
            string msg = _dataservice.ElevateMsg(userID);
            return msg;
        }
        public string GetHeroElevate(string userID)
        {
            string msg = _dataservice.ElevateMsg(userID);
            return msg;
        }

        public string GetHeroElevate()
        {
            throw new NotImplementedException();
        }
    }
}
