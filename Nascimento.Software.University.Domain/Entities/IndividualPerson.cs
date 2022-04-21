using Nascimento.Software.University.Domain.Entities.ValueObjects;

namespace Nascimento.Software.University.Domain.Entities;

public class IndividualPerson
{
    public Person Person { get; set; }
    public DateTime BirthdayDate { get; set; }
    public Email Email { get; set; }
    public Phone Phone { get; set; }


    public IList<Contract> Contracts { get; set; }

    public IList<Payment> Payments { get; set; }
    // 1 pessoa pode gerar n contratos
    // 1 pessoa pode realizar n pagamentos
    
}