using System;

public class Subscriber : User
{
    public Subscriber(string email) : base(email)
    {
    }

    public override void Notify(Training training)
    {
        Console.WriteLine($"[POWIADOMIENIE] {Email}: Nowe szkolenie -> {training.Title} w {training.City} ({training.StartDate.ToShortDateString()} - {training.EndDate.ToShortDateString()})");
    }
}