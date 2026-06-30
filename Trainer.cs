using System;

public class Trainer : User
{
    public string Name { get; set; }

    public Trainer(string email, string name) : base(email)
    {
        Name = name;
    }

    public override void Notify(Training training)
    {
        Console.WriteLine($"[TRAINER] {Name} dodał szkolenie: {training.Title}");
    }
}