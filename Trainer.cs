public class Trainer : User
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Description { get; set; }
    public string PhotoPath { get; set; }

    public Trainer(
        string email,
        string firstName,
        string lastName,
        string description,
        string photoPath) : base(email)
    {
        FirstName = firstName;
        LastName = lastName;
        Description = description;
        PhotoPath = photoPath;
    }

    public override void Notify(Training training)
    {
        Console.WriteLine($"[TRAINER] {FirstName} {LastName} dodał szkolenie: {training.Title}");
    }
}