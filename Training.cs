public class Training
{
    public string Title { get; set; }
    public string City { get; set; }
    public string Trainer { get; set; }
    public DateTime Date { get; set; }

    public Training(string title, string city, string trainer, DateTime date)
    {
        Title = title;
        City = city;
        Trainer = trainer;
        Date = date;
    }

    public override string ToString()
    {
        return $"{Title} | {City} | {Trainer} | {Date.ToShortDateString()}";
    }
}