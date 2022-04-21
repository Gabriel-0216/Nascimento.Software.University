namespace Nascimento.Software.University.Domain.Entities;

public class Payment
{
    public int PaidBy { get; set; }
    public IndividualPerson PaymentPerson { get; set; }
    public Contract Contract { get; set; }
    
    
    //add payment
}