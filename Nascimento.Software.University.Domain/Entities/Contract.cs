namespace Nascimento.Software.University.Domain.Entities;

public class Contract
{
    public decimal Price { get; set; }
    public int ParcelsQuantity { get; set; }
    public Course Course { get; set; }
    //1 contrato pode ser apenas para um curso

    public IList<ContractParcelas> Parcels { get; set; }

    public Contract(Course course, int parcelsQuantity)
    {
        
    }

    public void GenerateContract()
    {
        //
    }

    private void GenerateParcels()
    {
        
    }
    
}