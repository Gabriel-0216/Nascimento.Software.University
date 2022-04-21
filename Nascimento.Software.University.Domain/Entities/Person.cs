using Nascimento.Software.University.Domain.Entities.ValueObjects;

namespace Nascimento.Software.University.Domain.Entities;

public class Person : BaseEntity
{
    public Name Name { get; private set; }

    public Address? Address { get; private set; }

    public Person(string firstName, string? lastName)
    {
        Validator(firstName, lastName);
        if(IsValid){
            Name = new Name(firstName, lastName);
        }
    }
    public void SetAddress(string state, string city,
     string street, string number, string? referencePoint)
    {
        var address = new Address(state, city, street, number, referencePoint);
        if(address.IsValid)
        {
            Address = address;
        }
    }

    public void Validator(string firstName, string? lastName)
    {
            var name = new Name(firstName, lastName);
            if(!name.IsValid){
            AddNotifications(name.Notifications);
            return;
        }
    }

}