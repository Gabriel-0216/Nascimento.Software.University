namespace Nascimento.Software.University.Domain.Entities;

public class ContractParcelas
{
    public int ParcelNumber { get; set; }
    public Contract Contract { get; set; }
    public Payment? Payment { get; set; }
}