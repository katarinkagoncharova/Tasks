using MyApplication;

namespace UniversityUnitTests
{
    [TestClass]
    public class UniversityEmployeeUnitTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IfTaxIdIsNullOrEmpty()

        {
            var teacher1 = new Teacher(new Person("Antonova", "Aliaksandra", new Address("Minsk", "Bogdanova", 5, 10))
                , "", new Course("Math", "Math"));
        }

        [TestMethod]
        public void CheckSortEmployees()
        {
            Teacher teacher1 = new Teacher(new Person("Irina", "Donskaya", null),"12345kj", null);
            Teacher teacher2 = new Teacher(new Person("Olga", "Donskaya", null),"23456jo", null);
            DegreeTeacher dTeacher1 = new DegreeTeacher(new Person("Alexsandr", "Smirnov", null),"13344jj", null, null, null);
            DegreeTeacher dTeacher2 = new DegreeTeacher(new Person("Alexsandra", "Smirnova", null),"34567hy", null, null, null);
            SupportStaff staff1 = new SupportStaff(new Person("Elena", "Kuzina", null),"36985ty", null);
            SupportStaff staff2 = new SupportStaff(new Person("Viktor", "Kuzin", null),"85236oi", null);
            List<UniversityEmployee> employees = new List<UniversityEmployee> 
                                  { teacher1, teacher2, dTeacher1, dTeacher2, staff1, staff2 };
            employees.Sort();
            Assert.AreEqual(employees[0].Person.FullNameLength(), 18);
            Assert.AreEqual(employees[5].Person.FullNameLength(), 11);
        }

        [TestMethod]
        public void CheckSortEmployeesWithNameLengthComparer()
        {
            Teacher teacher1 = new Teacher(new Person("Irina", "Donskaya", null), "12345kj", null);
            Teacher teacher2 = new Teacher(new Person("Olga", "Donskaya", null), "23456jo", null);
            DegreeTeacher dTeacher1 = new DegreeTeacher(new Person("Alexsandr", "Smirnov", null), "13344jj", null, null, null);
            DegreeTeacher dTeacher2 = new DegreeTeacher(new Person("Alexsandra", "Smirnova", null), "34567hy", null, null, null);
            SupportStaff staff1 = new SupportStaff(new Person("Elena", "Kuzina", null), "36985ty", null);
            SupportStaff staff2 = new SupportStaff(new Person("Viktor", "Kuzin", null), "85236oi", null);
            List<UniversityEmployee> employees = new List<UniversityEmployee>
                                  { teacher1, teacher2, dTeacher1, dTeacher2, staff1, staff2 };
            employees.Sort(new NameLenghtComparer());
            Assert.AreEqual(employees[0].Person.FullNameLength(), 18);
            Assert.AreEqual(employees[5].Person.FullNameLength(), 11);
        }
    }
}
