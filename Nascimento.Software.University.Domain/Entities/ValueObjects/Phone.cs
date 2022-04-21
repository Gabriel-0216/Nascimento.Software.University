namespace Nascimento.Software.University.Domain.Entities.ValueObjects;

public class Phone : ValueObject
{
    public string Number { get; private set; }
    public Phone()
    {
        
    }
    public Phone(int Ddd, string number)
    {
        if(string.IsNullOrWhiteSpace(number)) AddNotification("NUmber", "Number can't be empty or null;");

        Number = $"{Ddd}-{number}";
    }
}