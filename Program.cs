using OOP;

class Program
{
    static void Main(string[] args)
    {
        Learners learner1 = new Learners("Malesela", "Letsoalo", "Male", 'J', 30);
        Learners learner2 = new Learners("Petrus", "Shai", "Male", 'P', 24);
        Learners learner3 = new Learners("Precious", "Mpuru", "Female", 'M', 23);
        Learners learner4 = new Learners("Thuli", "Baloyi", "Female", 'J', 24);
        Console.WriteLine(learner1.firstname + " " + learner1.lastname + " " + learner1.initial + " " + learner1.gender + " " + learner1.age);
        Console.WriteLine(learner2.firstname + " " + learner2.lastname + " " + learner2.initial + " " + learner2.gender + " " + learner2.age);
        Console.WriteLine(learner3.firstname + " " + learner3.lastname + " " + learner3.initial + " " + learner3.gender + " " + learner3.age);
        Console.WriteLine(learner4.firstname + " " + learner4.lastname + " " + learner4.initial + " " + learner4.gender + " " + learner4.age);

    }

}
