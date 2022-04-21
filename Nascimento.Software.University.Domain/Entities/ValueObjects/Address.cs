namespace Nascimento.Software.University.Domain.Entities.ValueObjects;

public class Address : ValueObject
{
    public string State { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string Street { get; set; } = string.Empty;
    public string Number { get; set; } = string.Empty;
    public string? ReferencePoint { get; set; }

    public Address()
    {
        
    }

    public Address(string state, string city, string street, 
        string number, string? referencePoint)
    {
        
    }

    private void Validator(string state, string city, string street,
        string number, string? referencePoint)
    {
        
    }
}