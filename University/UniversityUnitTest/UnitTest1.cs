using MyApplication;

namespace UniversityUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckAddressHouseNumberLess1()
        {
            Address address = new Address("Minsk", "Bogdanovicha", 0, 7);
            Assert.AreEqual(0, address.HouseNumber);
        }

        [TestMethod]
        public void CheckAddressHouseNumberMore1000()
        {
            Address address = new Address("Minsk", "Bogdanovicha", 1001, 7);
            Assert.AreEqual(0, address.HouseNumber);
        }

        [TestMethod]
        public void CheckAddressApartmentNumberMore1000()
        {
            Address address = new Address("Minsk", "Bogdanovicha", 10, 1010);
            Assert.AreEqual(0, address.ApartmentNumber);
        }

        [TestMethod]
        public void CheckAddressApartmentNumberLess0()
        {
            Address address = new Address("Minsk", "Bogdanovicha", 10, -1);
            Assert.AreEqual(0, address.ApartmentNumber);
        }

        [TestMethod]
        public void CheckAddressEqual()
        {
            Address address = new Address("Minsk", "Bogdanovicha", 10, 10);
            Address address1 = new Address("Minsk", "Bogdanovicha", 10, 10);
            Assert.AreEqual(address, address1);
        }

        [TestMethod]
        public void CheckAddressNotEqual()
        {
            Address address = new Address("Minsk", "Bogdanovicha", 10, 10);
            Address address1 = new Address("Minsk", "Bogdanova", 10, 10);
            Assert.AreNotEqual(address, address1);
        }


        [TestMethod]
        public void CheckBuildingsEqual()
        {
            var building = new Building("Building", new Address("Minsk", "Bogdanovicha", 10, 10),
                                       new List<Room> {new Room(101, "lecture"), new Room(102, "laboratory")});

            var building1 = new Building("Building", new Address("Minsk", "Bogdanovicha", 10, 10),
                                      new List<Room> { new Room(101, "lecture"), new Room(102, "laboratory") });


            Assert.AreEqual(building, building1);
        }

        [TestMethod]
        public void CheckBuildingsNotEqual()
        {
            var building = new Building("Building", new Address("Minsk", "Bogdanovicha", 10, 10),
                                       new List<Room> { new Room(101, "lecture"), new Room(102, "laboratory") });

            var building1 = new Building("Building", new Address("Minsk", "Bogdanova", 5, 10),
                                      new List<Room> { new Room(101, "lecture"), new Room(102, "laboratory") });

            Assert.AreNotEqual(building, building1);
        }

        [TestMethod]
        public void CheckCandidatesEqual()
        {
            var candidate = new Candidate(new Person("Irina", "Smirnova", new Address("Minsk", "Bogdanova", 5, 10)),
                          new List<SubjectScore> { new SubjectScore(90, "Math"), new SubjectScore(80, "Physics") });

            var candidate1 = new Candidate(new Person("Irina", "Smirnova", new Address("Minsk", "Bogdanova", 5, 10)),
                          new List<SubjectScore> { new SubjectScore(90, "Math"), new SubjectScore(80, "Physics") });

            Assert.AreEqual(candidate, candidate1);
        }

        [TestMethod]
        public void CheckCandidatesNotEqual()
        {
            var candidate = new Candidate(new Person("Irina", "Smirnova", new Address("Minsk", "Bogdanova", 5, 10)),
                          new List<SubjectScore> { new SubjectScore(90, "Math"), new SubjectScore(80, "Physics") });

            var candidate1 = new Candidate(new Person("Olga", "Smirnova", new Address("Minsk", "Bogdanova", 5, 10)),
                          new List<SubjectScore> { new SubjectScore(90, "Math"), new SubjectScore(80, "Physics") });

            Assert.AreNotEqual(candidate, candidate1);
        }

        [TestMethod]
        public void DontAddIfSubjectExist()
        {
            var candidate = new Candidate(new Person("Irina", "Smirnova", new Address("Minsk", "Bogdanova", 5, 10)),
                          new List<SubjectScore> { new SubjectScore(90, "Math"), new SubjectScore(80, "Physics") });
            candidate.AddSubject(new SubjectScore(90, "Math"));
            Assert.AreEqual(2, candidate.SubjectScores.Count());
        }

        [TestMethod]
        public void CheckCoursesEqual()
        {
            var course = new Course("Math", "Probability theoty");
            var course1 = new Course("Math", "Algebra");
            Assert.AreEqual(course, course1);
        }

        [TestMethod]
        public void CheckCoursesNotEqual()
        {
            var course = new Course("Math", "Probability theoty");
            var course1 = new Course("Language", "Belarusian language course");
            Assert.AreNotEqual(course, course1);
        }

        [TestMethod]
        public void CheckFullNameLenght()
        {
            var person = new Person("Ivanov", "Aliaksandr", new Address("Minsk", "Bogdanova", 5, 10));
            Assert.AreEqual(person.FullNameLength(), 16);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CheckFullNameForPersonOver20Symbol()

        {
            var person = new Person("Antonovskaya", "Aliaksandra", new Address("Minsk", "Bogdanova", 5, 10));
        }

        [TestMethod]
        public void CheckPersonsEqual()
        {
            var person = new Person("Irina", "Smirnova", new Address("Minsk", "Bogdanova", 5, 10));
            var person1 = new Person("Irina", "Smirnova", new Address("Minsk", "Bogdanova", 5, 10));
            Assert.AreEqual(person, person1);
        }

        [TestMethod]
        public void CheckPersonsNotEqual()
        {
            var person = new Person("Anna", "Smirnova", new Address("Minsk", "Bogdanova", 5, 10));
            var person1 = new Person("Irina", "Smirnova", new Address("Minsk", "Bogdanova", 5, 10));
            Assert.AreNotEqual(person, person1);
        }

        [TestMethod]
        public void CheckRoomsNotEqual()
        {
            var room = new Room(101, "lecture" );
            var room1 = new Room(101, "laboratory");
            Assert.AreNotEqual(room, room1);
        }

        [TestMethod]
        public void CheckRoomsEqual()
        {
            var room = new Room(101, "lecture");
            var room1 = new Room(101, "lecture");
            Assert.AreEqual(room, room1);
        }

        [TestMethod]
        public void CheckScoreLess1()
        {
            var subjectScore = new SubjectScore(-10, "Math"); 
            Assert.AreEqual(0, subjectScore.Score);
        }

        [TestMethod]
        public void CheckScoreMore100()
        {
            var subjectScore = new SubjectScore(101, "Math");
            Assert.AreEqual(0, subjectScore.Score);
        }

        [TestMethod]
        public void CheckSubjectScoresNotEqual()
        {
            var subjectScore = new SubjectScore (70, "Math");
            var subjectScore1 = new SubjectScore(60, "Physics");
            Assert.AreNotEqual(subjectScore, subjectScore1);
        }

        [TestMethod]
        public void CheckSubjectScoresEqual()
        {
            var subjectScore = new SubjectScore(70, "Physics");
            var subjectScore1 = new SubjectScore(60, "Physics");
            Assert.AreEqual(subjectScore, subjectScore1);
        }

        [TestMethod]
        public void DontAddIfEmployeeExist()
        {
        Teacher teacher1 = new Teacher(
            new Person("Irina", "Donskaya", new Address("Minsk", "Sovetskaya", 41, 17)),
            "12345kj",
            new Course("Language", "Belarusian language course"));

        Teacher teacher2 = new Teacher(
                new Person("Olga", "Donskaya", new Address("Minsk", "Esinina", 144, 189)),
                "23456jo",
                new Course("Physics", "Mechanics"));


        DegreeTeacher dTeacher1 = new DegreeTeacher(
                new Person("Alexsandr", "Smirnov", new Address("Smolevichi", "Mira", 81, 19)),
                "13344jj",
                new Course("Mathematics", "Probability theoty"),
                "Doctor of Sciences",
                "Docent");

        DegreeTeacher dTeacher2 = new DegreeTeacher(
                new Person("Alexsandra", "Smirnova", new Address("Smolevichi", "Mira", 81, 19)),
                "34567hy",
                new Course("Physics", "Mechanics"),
                "Doctor of Sciences",
                "Professor");


        SupportStaff staff1 = new SupportStaff(
                new Person("Elena", "Kuzina", new Address("Minsk", "Angarskaya", 15, 27)),
                "36985ty",
                "Cleaner");

        SupportStaff staff2 = new SupportStaff(
                new Person("Viktor", "Kuzin", new Address("Minsk", "Angarskaya", 15, 27)),
                "85236oi", "Driver");

        List<UniversityEmployee> employees = new List<UniversityEmployee> { teacher1, teacher2, dTeacher1, dTeacher2, staff1, staff2 };


         University un1 = new University(
              new Address("Gomel", "Sovetskaya", 5, 0),
              new Rector(new Person("Chernov", "Maxim", new Address("Gomel", "Bogdanovicha", 20, 30)), "12345jk"),
              employees,
              new List<Building> {
            new Building("Building", new Address("Gomel", "Sovetskaya", 5, 0),
              new List < Room > {
                new Room(101, "lecture"),
                new Room(102, "laboratory"),
                new Room(103, "auxiliary")
              }),
            new Building("Building", new Address("Gomel", "Sovetskaya", 8, 0),
              new List < Room > {
                new Room(101, "lecture"),
                new Room(102, "laboratory"),
                new Room(103, "auxiliary"),
                new Room(104, "lecture"),
                new Room(201, "laboratory")
              })
              }
            );

            un1.AddEmployee(new SupportStaff(
                new Person("Elena", "Kuzina", new Address("Minsk", "Angarskaya", 15, 27)),
                "36985ty",
                "Cleaner"));
                              
            Assert.AreEqual(6, un1.Employees.Count());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IfTaxIdIsNullOrEmpty()

        {
            var teacher1 = new Teacher(new Person("Antonova", "Aliaksandra", new Address("Minsk", "Bogdanova", 5, 10))
                ,"",new Course("Math", "Math"));
        }
        
        
        [TestMethod]
        public void CheckSortEmployees()
        {
            Teacher teacher1 = new Teacher(
           new Person("Irina", "Donskaya", new Address("Minsk", "Sovetskaya", 41, 17)),
           "12345kj",
           new Course("Language", "Belarusian language course"));

            Teacher teacher2 = new Teacher(
                new Person("Olga", "Donskaya", new Address("Minsk", "Esinina", 144, 189)),
                "23456jo",
                new Course("Physics", "Mechanics"));


            DegreeTeacher dTeacher1 = new DegreeTeacher(
                new Person("Alexsandr", "Smirnov", new Address("Smolevichi", "Mira", 81, 19)),
                "13344jj",
                new Course("Mathematics", "Probability theoty"),
                "Doctor of Sciences",
                "Docent");

            DegreeTeacher dTeacher2 = new DegreeTeacher(
                new Person("Alexsandra", "Smirnova", new Address("Smolevichi", "Mira", 81, 19)),
                "34567hy",
                new Course("Physics", "Mechanics"),
                "Doctor of Sciences",
                "Professor");


            SupportStaff staff1 = new SupportStaff(
                new Person("Elena", "Kuzina", new Address("Minsk", "Angarskaya", 15, 27)),
                "36985ty",
                "Cleaner");

            SupportStaff staff2 = new SupportStaff(
                new Person("Viktor", "Kuzin", new Address("Minsk", "Angarskaya", 15, 27)),
                "85236oi", "Driver");

            List<UniversityEmployee> employees = new List<UniversityEmployee> { teacher1, teacher2, dTeacher1, dTeacher2, staff1, staff2 };

            employees.Sort();
            Assert.AreEqual(employees[0].Person.FullNameLength(), 18);
            Assert.AreEqual(employees[5].Person.FullNameLength(), 11);
        }

        [TestMethod]
        public void CheckSortEmployeesWithNameLengthComparer()
        {
            Teacher teacher1 = new Teacher(
           new Person("Irina", "Donskaya", new Address("Minsk", "Sovetskaya", 41, 17)),
           "12345kj",
           new Course("Language", "Belarusian language course"));

            Teacher teacher2 = new Teacher(
                new Person("Olga", "Donskaya", new Address("Minsk", "Esinina", 144, 189)),
                "23456jo",
                new Course("Physics", "Mechanics"));


            DegreeTeacher dTeacher1 = new DegreeTeacher(
                new Person("Alexsandr", "Smirnov", new Address("Smolevichi", "Mira", 81, 19)),
                "13344jj",
                new Course("Mathematics", "Probability theoty"),
                "Doctor of Sciences",
                "Docent");

            DegreeTeacher dTeacher2 = new DegreeTeacher(
                new Person("Alexsandra", "Smirnova", new Address("Smolevichi", "Mira", 81, 19)),
                "34567hy",
                new Course("Physics", "Mechanics"),
                "Doctor of Sciences",
                "Professor");


            SupportStaff staff1 = new SupportStaff(
                new Person("Elena", "Kuzina", new Address("Minsk", "Angarskaya", 15, 27)),
                "36985ty",
                "Cleaner");

            SupportStaff staff2 = new SupportStaff(
                new Person("Viktor", "Kuzin", new Address("Minsk", "Angarskaya", 15, 27)),
                "85236oi", "Driver");

            List<UniversityEmployee> employees = new List<UniversityEmployee> { teacher1, teacher2, dTeacher1, dTeacher2, staff1, staff2 };

            employees.Sort(new NameLenghtComparer());
            Assert.AreEqual(employees[0].Person.FullNameLength(), 18);
            Assert.AreEqual(employees[5].Person.FullNameLength(), 11);
        }




    }
}