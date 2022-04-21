namespace Nascimento.Software.University.Domain.Entities.ValueObjects;

public class Name : ValueObject
{
    public string FirstName { get; private set; } = string.Empty;
    public string? LastName { get; private set; }

    public Name()
    {
        
    }

    public Name(string firtName, string? lastName)
    {
        Validator(firtName, lastName);
        if (!IsValid) return;
        
        FirstName = firtName;
        if (lastName is not null) LastName = lastName;
    }

    private void Validator(string firstName, string? lastName)
    {
        if(string.IsNullOrWhiteSpace(firstName)) AddNotification("First name", "The first name is required.");
        if(firstName.Length < 1) AddNotification("First name", "The minimum lenght is one character");
    }
}