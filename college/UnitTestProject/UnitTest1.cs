using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UnitTestProject
{
    [TestClass]
    public class TCollege
    {

        [TestMethod]
        public void TestGetStudentsByGroup()
        {
            
            College college = new College();
            string groupName = "П-30";
            List<string> students = new List<string> { "Егор", "Роге" };
            college.AddGroup(groupName, students);

            
            List<string> GettedStudents = college.GetStudentsByGroup(groupName);

            
            CollectionAssert.AreEqual(students, GettedStudents);
        }

        [TestMethod]
        public void TestGetStudentsByGroup1()
        {

            College college = new College();
            string groupName = "П-30";
            List<string> students = new List<string> { "Егор", "Роге" };
            college.AddGroup(groupName, students);


            string fakeGroupName = "";
            List<string> fakeGettedStudents = college.GetStudentsByGroup(fakeGroupName);
            Assert.IsTrue(fakeGettedStudents.Count == 0);
           
        }

        [TestMethod]
        public void TestGetStudentsByGroups()
        {

            College college = new College();
            college.AddGroup("П-30", new List<string> { "Егор", "Роге" });
            college.AddGroup("П-20", new List<string> { "Адун", "Жумагулов" });
            college.AddGroup("П-10", new List<string> { "Димадик", "Венедиктов" });

            List<string> exp30 = new List<string> { "Егор", "Роге" };
            List<string> exp20 = new List<string> { "Адун", "Жумагулов" };
            List<string> exp10 = new List<string> { "Димадик", "Венедиктов" };

            List<string> GettedStudents30 = college.GetStudentsByGroup("П-30");
            List<string> GettedStudents20 = college.GetStudentsByGroup("П-20");
            List<string> GettedStudents10 = college.GetStudentsByGroup("П-10");


            CollectionAssert.AreEqual(exp30, GettedStudents30);
            CollectionAssert.AreEqual(exp20, GettedStudents20);
            CollectionAssert.AreEqual(exp10, GettedStudents10);
        }
    }
}
