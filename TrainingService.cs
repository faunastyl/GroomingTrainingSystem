using System;
using System.Collections.Generic;

public class TrainingService
{
    private List<Training> trainings = new List<Training>();
    private List<User> users = new List<User>();

    // SUBSKRYPCJA (Observer)
    public void Subscribe(User user)
    {
        users.Add(user);
    }

    public void Unsubscribe(User user)
    {
        users.Remove(user);
    }

    // DODAWANIE SZKOLENIA
    public void AddTraining(Training training)
    {
        trainings.Add(training);
        NotifyUsers(training);
    }

    // PRZECIĄŻENIE METODY (wymóg z zadania)
    public void AddTraining(string title, string city, string trainer)
    {
        Training t = new Training(title, city, trainer, DateTime.Now);
        AddTraining(t);
    }

    // LISTA SZKOLEŃ
    public List<Training> GetTrainings()
    {
        return trainings;
    }

    // FILTROWANIE PO MIEŚCIE
    public List<Training> GetByCity(string city)
    {
        return trainings.FindAll(t => t.City == city);
    }

    // FILTROWANIE PO TRENERZE
    public List<Training> GetByTrainer(string trainer)
    {
        return trainings.FindAll(t => t.Trainer == trainer);
    }

    // OBSERVER – powiadomienia
    private void NotifyUsers(Training training)
    {
        foreach (var user in users)
        {
            user.Notify(training);
        }
    }
}