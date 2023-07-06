using Microsoft.VisualStudio.TestTools.UnitTesting;
using MockTesting1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
namespace MockTesting1.Tests
{
    [TestClass()]
    public class StudentOperationTests
    {
        Mock<IStudent> mockStudent = new Mock<IStudent>();
        [TestMethod()]
        public void GetStudentsTest()
        {
            mockStudent.Setup(S => S.GetStudents()).Returns(GetTestData);
            List<Student> students = mockStudent.Object.GetStudents();
            var expectedOutput = GetExpectedStudents();
            Assert.AreEqual(expectedOutput.Count, students.Count);
            //Assert.Fail();
        }
        [TestMethod()]
        public void GetStudent_Test_SuccessResult1()
        {
            Mock<IDataService> mockService = new Mock<IDataService>();

            Mock<StudentOperation> mockStudent = new Mock<StudentOperation>(mockService.Object);
            mockService.Setup(S => S.GetStudentsData()).Returns(GetTestData);
            List<Student> students = mockService.Object.GetStudentsData();
            var expectedOutput = GetExpectedStudents();
            Assert.AreEqual(expectedOutput.Count, students.Count);
        }
        private List<Student> GetTestData()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student() { RoleNo = 1, Name = "Test1" });
            students.Add(new Student() { RoleNo = 2, Name = "Test2" });
            students.Add(new Student() { RoleNo = 3, Name = "Test3" });
            students.Add(new Student() { RoleNo = 4, Name = "Test4" });
            return students;
        }


        private List<Student> GetExpectedStudents()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student() { RoleNo = 1, Name = "dsfghjk" });
            students.Add(new Student() { RoleNo = 2, Name = "fdyhfgc" });
            students.Add(new Student() { RoleNo = 3, Name = "jhgjkj" });
            students.Add(new Student() { RoleNo = 4, Name = "hghvhgv" });
            return students;

        }

    }
}