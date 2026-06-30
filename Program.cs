using System;

class Program
{
    static void Main(string[] args)
    {
        TrainingService service = new TrainingService();

        User user = new Subscriber("test@mail.com");

        service.Subscribe(user);

        service.AddTraining(
    "Strzyżenie psów",
    "Szkolenie podstawowe dla początkujących groomerów",
    "Warszawa",
    "Anna Kowalska",
    new DateTime(2026, 9, 10),
    new DateTime(2026, 9, 12));
    }
}