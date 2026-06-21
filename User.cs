using System;

public abstract class User
{
    public string Email { get; set; }

    public User(string email)
    {
        Email = email;
    }

    // POLIMORFIZM (każdy typ użytkownika zachowuje się inaczej)
    public abstract void Notify(Training training);
}