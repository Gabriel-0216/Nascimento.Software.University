using Nascimento.Software.University.Domain.Entities.ValueObjects;

namespace Nascimento.Software.University.Domain.Entities;

public class Person : BaseEntity
{
    public Name Name { get; set; }

    public Address Address { get; set; }

    public Person()
    {
        
    }
}