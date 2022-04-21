namespace Nascimento.Software.University.Domain.Entities;

public class Course
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }

    public IList<Contract> Contracts { get; set; }

    public Course(string name, string description, decimal price)
    {
        
    }
    //um curso pode gerar N contratos
}

/*
Uma pessoa fisica tem n cursos, gera 1 contrato com n parcelas

*/