using System;

class Program
{
    static void Main(string[] args)
    {
        TrainingService service = new TrainingService();

        User user = new Subscriber("test@mail.com");

        service.Subscribe(user);

        service.AddTraining("Strzyżenie psów", "Warszawa", "Anna Kowalska");

        Console.WriteLine("Dodano szkolenie i wysłano powiadomienie.");

        Console.ReadLine();
    }
}