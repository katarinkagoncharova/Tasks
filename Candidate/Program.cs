namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
                               
            
            Candidate C1 = new Candidate (new Person("Ivanov", "Anton", new Address("Mogilev", "Lenina", 36, 74)), new SubjectScore[]{
                                                                                                            new SubjectScore(90, "Math"),
                                                                                                            new SubjectScore(80, "Physics"),
                                                                                                            new SubjectScore(70, "Literature"),
                                                                                                            new SubjectScore(95, "Language")});

            Candidate C2 = new Candidate(new Person("Petrov", "Oleg", new Address("Omsk", "Mira", 5, 18)),  new SubjectScore[]{ 
                                                                                                            new SubjectScore(100, "Math"),
                                                                                                            new SubjectScore(100, "Physics"),
                                                                                                            new SubjectScore(100, "Literature"),
                                                                                                            new SubjectScore(100, "Language")});
            
            Candidate C3 = new Candidate(new Person("Sidorov", "Ivan", new Address("Gomel", "Chernomorskaya", 4, 40)), new SubjectScore[]{
                                                                                                            new SubjectScore(50, "Math"),
                                                                                                            new SubjectScore(60, "Physics"),
                                                                                                            new SubjectScore(70, "Literature"),
                                                                                                            new SubjectScore(80, "Language")});

            Candidate C4 = new Candidate(new Person("Abramov", "Semen", new Address("Minsk", "Amurskaya", 5, 48)), new SubjectScore[]{
                                                                                                            new SubjectScore(60, "Math"),
                                                                                                            new SubjectScore(70, "Physics"),
                                                                                                            new SubjectScore(80, "Literature"),
                                                                                                            new SubjectScore(90, "Language")});

            Candidate C5 = new Candidate(new Person("Koroleva", "Olga", new Address("Minsk", "Vladimirova", 15, 64)), new SubjectScore[]{
                                                                                                            new SubjectScore(70, "Math"),
                                                                                                            new SubjectScore(80, "Physics"),
                                                                                                            new SubjectScore(85, "Literature"),
                                                                                                            new SubjectScore(90, "Language")});

            Candidate[] Candidates = { C1, C2, C3, C4, C5 };

            Console.WriteLine("All streets:  ");

            for (int i = 0; i < Candidates.Length; i++)
            {
                Console.WriteLine(Candidates[i].Person.Address.Street );
            }

            string Subject = "Language";
            int max = 0;

            for (int i = 0; i < Candidates.Length; i++)
            {
                for (int j = 0; j < Candidates[i].SubjectScores.Length; j++)
                {

                    if (Candidates[i].SubjectScores[j].SubjectName == Subject && Candidates[i].SubjectScores[j].Score > max)
                    {
                        max = Candidates[i].SubjectScores[j].Score;
                    }
                 }



            }

            Console.WriteLine($"Max score for Language is {max}");





            //Console.WriteLine($"City: {Person1.Address.City}  Street: {Person1.Address.Street}   ");
            //Console.WriteLine(Person1.Address.City);
            //Console.WriteLine(C5.SubjectScores[3].Score);
            Console.ReadKey(true);
            
        }
    }
    
}