namespace Employee;

internal class Program
{
    static void Main(string[] args)
    {
        UniversityEmployee employee1 = new UniversityEmployee(
            new Person("Ivanov", "Ivan", new Address("Minsk", "Gomelskaya", 5, 6)),
            "12345kk");

        Teacher teacher1 = new Teacher(
            new Person("Donskaya", "Irina", new Address("Minsk", "Sovetskaya", 41, 17)),
            "23344jj", 
            new Course ("Language", "Belarusian language course"));

        DegreeTeacher dTeacher1 = new DegreeTeacher(
            new Person("Smirnov", "Alexsandr",new Address("Smolevichi", "Mira", 81, 19)),
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
            "85236oi","Driver");

        UniversityEmployee[] employees = new UniversityEmployee[] {employee1, teacher1, dTeacher1, staff1, staff2 };

        Console.WriteLine("University employees:");

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
            
       }
        Console.ReadKey(); 
    }
}