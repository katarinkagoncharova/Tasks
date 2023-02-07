using MyApplication;

namespace UniversityUnitTest
{
    [TestClass]
    public class UniversityUnitTests
    {
 
        [TestMethod]
        public void AddEmployeeIfNotExist()
        {
        Teacher teacher1 = new Teacher(new Person("Irina", "Donskaya", null),"12345kj", null);

        Teacher teacher2 = new Teacher(new Person("Olga", "Donskaya", null),"23456jo", null);

        DegreeTeacher dTeacher1 = new DegreeTeacher(new Person("Alexsandr", "Smirnov", null),
                "13344jj", null, null, null);

        DegreeTeacher dTeacher2 = new DegreeTeacher(new Person("Alexsandra", "Smirnova", null),
                "34567hy", null, null, null);


        SupportStaff staff1 = new SupportStaff(new Person("Elena", "Kuzina", null), "36985ty", null);

        SupportStaff staff2 = new SupportStaff(new Person("Viktor", "Kuzin", null),"85236oi", null);

        List<UniversityEmployee> employees = new List<UniversityEmployee> { teacher1, teacher2, dTeacher1, dTeacher2, staff1, staff2 };

         University un1 = new University(
              new Address("Gomel", "Sovetskaya", 5, 0),
              new Rector(new Person("Chernov", "Maxim", new Address("Gomel", "Bogdanovicha", 20, 30)), "12345jk"),
              employees, null);

              var newEmployee = new SupportStaff(
                  new Person("Marina", "Petrova", new Address("Minsk", "Angarskaya", 15, 27)),
                  "00124hh",
                  "Cleaner");

            Assert.IsTrue(un1.AddEmployee(newEmployee));                  
            Assert.AreEqual(7, un1.Employees.Count());
            Assert.IsTrue(un1.Employees.Contains(newEmployee));
        }

        
        
        
      




    }
}