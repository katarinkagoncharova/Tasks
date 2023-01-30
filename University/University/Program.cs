using System;
using System.Collections.Immutable;
using System.Security.Cryptography.X509Certificates;

namespace MyApplication;

internal class Program
{
    static void Main(string[] args)
    {
        //* start TASK 1* start

        /*const string subject = "Language";

        Candidate c1 = new Candidate(new Person("Ivanov", "Anton", new Address("Mogilev", "Lenina", 36, 74)),
                                      new List <SubjectScore>
                                        {
                                          new SubjectScore(90, "Math"),
                                          new SubjectScore(80, "Physics"),
                                          new SubjectScore(70, "Literature"),
                                          new SubjectScore(95, "Language")
                                        }
                                      );

        Candidate c2 = new Candidate(new Person("Petrov", "Oleg", new Address("Omsk", "Mira", 5, 18)),
                                     new List<SubjectScore>
                                       {
                                         new SubjectScore(100, "Math"),
                                         new SubjectScore(100, "Physics"),
                                         new SubjectScore(100, "Literature"),
                                         new SubjectScore(100, "Language")
                                       }
                                     );

        Candidate c3 = new Candidate(new Person("Sidorov", "Ivan", new Address("Gomel", "Chernomorskaya", 4, 40)),
                                     new List<SubjectScore>
                                       {
                                         new SubjectScore(50, "Math"),
                                         new SubjectScore(60, "Physics"),
                                         new SubjectScore(70, "Literature"),
                                         new SubjectScore(80, "Language")
                                       }
                                     );

        Candidate c4 = new Candidate(new Person("Abramov", "Semen", new Address("Minsk", "Amurskaya", 5, 48)),
                                     new List<SubjectScore>
                                       {
                                         new SubjectScore(60, "Math"),
                                         new SubjectScore(70, "Physics"),
                                         new SubjectScore(80, "Literature"),
                                         new SubjectScore(90, "Language")
                                       }
                                     );

        Candidate c5 = new Candidate(new Person("Koroleva", "Olga", new Address("Minsk", "Vladimirova", 15, 64)),
                                     new List<SubjectScore>
                                       {
                                         new SubjectScore(70, "Math"),
                                         new SubjectScore(80, "Physics"),
                                         new SubjectScore(85, "Literature"),
                                         new SubjectScore(90, "Language")
                                       }
                                     );

        List<Candidate> Candidates = new List<Candidate> { c1, c2, c3, c4, c5 };

        Console.WriteLine("All streets: ");


        for (int i = 0; i < Candidates.Count; i++)
        {
            Console.WriteLine(Candidates[i].Person.Address.Street);
        }

        int max = 0;

        for (int i = 0; i < Candidates.Count; i++)
        {
            for (int j = 0; j < Candidates[i].SubjectScores.Count; j++)
            {

                if (Candidates[i].SubjectScores[j].SubjectName == subject &&
                    Candidates[i].SubjectScores[j].Score > max)
                {
                    max = Candidates[i].SubjectScores[j].Score;
                }
            }
        }
        Console.WriteLine($"Max score for {subject} is {max}");
        Console.ReadKey(true);*/
        //* end TASK 1* end



        //* start TASK 2* start
        /*UniversityEmployee employee1 = new UniversityEmployee(
            new Person("Ivanov", "Ivan", new Address("Minsk", "Gomelskaya", 5, 6)),
            "12345kk");

        Teacher teacher1 = new Teacher(
            new Person("Donskaya", "Irina", new Address("Minsk", "Sovetskaya", 41, 17)),
            "23344jj",
            new Course("Language", "Belarusian language course"));

        DegreeTeacher dTeacher1 = new DegreeTeacher(
            new Person("Smirnov", "Alexsandr", new Address("Smolevichi", "Mira", 81, 19)),
            "52364gh",
            new Course("Mathematics", "Probability theoty"),
            "Doctor of Sciences",
            "Docent");

        SupportStaff staff1 = new SupportStaff(
            new Person("Kuzina", "Elena", new Address("Minsk", "Angarskaya", 15, 27)),
            "14236jy",
            "Cleaner");

        SupportStaff staff2 = new SupportStaff(
            new Person("Kuzin", "Viktor", new Address("Minsk", "Angarskaya", 15, 27)),
            "85236oi", "Driver");

        List<UniversityEmployee> employees = new List<UniversityEmployee> { teacher1, dTeacher1, staff1, staff2 };

        /*Console.WriteLine("University employees:");

        foreach (UniversityEmployee employee in employees)
        {
            Console.WriteLine(employee.GetOfficialDuties());
        }

       Console.WriteLine("Teachers:");

       foreach (UniversityEmployee employee in employees)
       {
            if (employee is Teacher)
            {
                Console.WriteLine($"{employee.Person.Name} {employee.Person.Surname}");
            }
            
       }*/
        //* end TASK 2* end

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
              }),

          }
        );


        var filter = un1.Employees.Where(x => x.Person.Surname.StartsWith("S")).OrderBy(x => x.TaxID).ToList();
        Console.WriteLine($"1. Surnames of employees starting with a letter S:");
        foreach (var i in filter)
        {
            Console.WriteLine(i.TaxID + " " + i.Person.Surname);
        }

        var filter2 = un1.Employees.Select(x => x as Teacher).Where(x => x?.Course.CourseName == "Physics").ToList();
        Console.WriteLine($"2. Employees who teach Physics:");
        foreach (var i in filter2)
        {
            Console.WriteLine(i.Person.Name + " " + i.Person.Surname);
        }

        Console.WriteLine($"3. Employees' TaxID and GetOfficialDuties:");
        var filter3 = un1.Employees.Select(x => (x.TaxID, x.GetOfficialDuties())).ToList();
        foreach (var i in filter3)
        {
            Console.WriteLine(i);

            Console.WriteLine($"4. Addresses of building that have room 101:");
            var filter4 = un1.Buildings.Select(x => (x.Address, x.Rooms.Where(x => x.Number == 101))).Select(x => x.Address).ToList();
            //var filter5 = un1.Buildings.Where(x => x.Rooms.Any(x => x.Number == 101)).Select(x =>x.Address).ToList();
            foreach (var f in filter4)
            {
                Console.WriteLine(f.City + " " + f.Street + " " + f.HouseNumber);
            }

            Console.WriteLine($"5. Address of building with the maximum number of rooms:");
            var filter6 = un1.Buildings.OrderByDescending(x => x.Rooms.Count).First().Address;
            Console.WriteLine(filter6.City + " " + filter6.Street + " " + filter6.HouseNumber);

            Console.WriteLine($"6. Most common surname:");
            var filter7 = un1.Employees.GroupBy(x => x.Person.Surname).MaxBy(x => x.Count());
            Console.WriteLine($"Surname {filter7?.Key}, repeats {filter7?.Count()} times");


            un1.Employees.Sort();
            un1.Employees.Sort(new NameSurnameLenghtComparer());
            var filter8 = un1.Employees.OrderByDescending(x => (x.Person.Name.Length + x.Person.Surname.Length));



            Console.ReadKey();
        }
    }
}