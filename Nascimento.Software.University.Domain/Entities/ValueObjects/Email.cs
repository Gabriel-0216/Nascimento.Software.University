using Flunt.Notifications;

namespace Nascimento.Software.University.Domain.Entities.ValueObjects;

public class Email : ValueObject
{
    public string EmailAddress { get; private set; } = string.Empty;

    public Email()
    {
        
    }

    public Email(string address)
    {
        Validator(address);
        if (IsValid) EmailAddress = address;
    }

    private void Validator(string address)
    {
        if(string.IsNullOrWhiteSpace(address)) AddNotification("Email", "Email Address can't be empty or null");
        //if is valid email... rege
    }
}