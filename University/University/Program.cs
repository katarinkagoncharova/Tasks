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
              })
          }
        );


        Console.ReadKey(); 
    }
}