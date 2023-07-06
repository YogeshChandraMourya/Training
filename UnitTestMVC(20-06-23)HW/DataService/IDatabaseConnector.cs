namespace DataService
{
    public interface IDatabaseConnector
    {
        string GetMessageFromMsgTbl();

        string ElevateMsg(string userID);
       // string LocalGetMessageTestData();
    }
}