using System;

public class Training
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string City { get; set; }
    public string Trainer { get; set; }

    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    public Training(
        string title,
        string description,
        string city,
        string trainer,
        DateTime startDate,
        DateTime endDate)
    {
        Title = title;
        Description = description;
        City = city;
        Trainer = trainer;
        StartDate = startDate;
        EndDate = endDate;
    }

    public override string ToString()
    {
        return $"{Title} | {City} | {Trainer} | " +
               $"{StartDate.ToShortDateString()} - {EndDate.ToShortDateString()}";
    }
}