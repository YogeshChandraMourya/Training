namespace UserService
{
    public interface IUserMessageService
    {
        string GetMessageFromDB();

        string GetElevationFromDB(string userID);

        string GetHeroElevate();
        //string LocalGetMessageTestData();
    }
}