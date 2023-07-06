using DataService;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using UserService;

namespace UnitTestMVC_20_06_23_HW
{
    [TestClass()]
    public class UserMessageTest
    {
        UserMessageService messageService;

        [TestInitialize]
        public void Initialize()
        {
            Mock<IDatabaseConnector> mockDatabaseConnector =new Mock<IDatabaseConnector>();
            mockDatabaseConnector.Setup(m => m.GetMessageFromMsgTbl()).Returns(LocalGetMessageTestData);
            messageService=new UserMessageService(mockDatabaseConnector.Object);
        }
        private string LocalGetMessageTestData()
        {
            return "This message is for testing data";
        }
        [TestMethod()]
        public void GetMessageFromDBTest()
        {
            string msg = messageService.GetMessageFromDB();
            string expectedString = "This message is for testing data";
            Assert.AreEqual(expectedString, msg);
            Assert.IsTrue(msg.Count() > 0);
        }
        [TestMethod()]
        public void Welcome_User_Test_SuccessFull()
        {
            string msg = messageService.GetHeroElevate("2");

            Assert.IsTrue(msg.Count() > 0);
        }

        [TestMethod()]
        public void Welcome_User_Test_SuccessFull_With_Existing_UserId_As_Empty()
        {
            Mock<IDatabaseConnector> mockDabaseConnector = new Mock<IDatabaseConnector>();
            mockDabaseConnector.Setup(m => m.ElevateMsg("")).Returns("User not found");
            messageService = new UserMessageService(mockDabaseConnector.Object);
            string msg = messageService.GetHeroElevate("1");

            Assert.AreEqual("User not found", msg);
            Assert.IsTrue(msg.Count() > 0);
        }



    }
}
