using Nascimento.Software.University.Domain.Entities.ValueObjects;

namespace Nascimento.Software.University.Domain.Entities;

public class IndividualPerson : BaseEntity
{
    public Person Person { get; private set; }
    public DateTime BirthdayDate { get; private set; }
    public Email? Email { get; private set; }
    public Phone? Phone { get; private set; }


    public IList<Contract> Contracts { get; set; }

    public IList<Payment> Payments { get; set; }
    // 1 pessoa pode gerar n contratos
    // 1 pessoa pode realizar n pagamentos

    public IndividualPerson(string firstName, string? lastName, DateTime birthdayDate)
    {
        Validator(firstName, lastName, birthdayDate);
        if(!IsValid) return;

        var person = new Person(firstName, lastName);
        BirthdayDate = birthdayDate;

    }

    public bool AddEmail(string emailAddress)
    {
        var email = new Email(emailAddress);
        if(!email.IsValid){
            AddNotifications(email.Notifications);
            return false;
        }
        Email = email;
        return true;
    }

    public bool AddPhone(int ddd, string number){
        var phone = new Phone(ddd, number);
        if(!phone.IsValid){
            AddNotifications(phone.Notifications);
            return false;
        }
        Phone = phone;
        return true;
    }


    private void Validator(string firstName, string? lastName, DateTime birthdayDate)
    {
        var person = new Person(firstName, lastName);
        if(!person.IsValid)
        {
            AddNotifications(person.Notifications);
        }
        if(birthdayDate > DateTime.UtcNow){
            AddNotification("Birthday date", "Você nasceu no futuro?");
        }

    }
    
}