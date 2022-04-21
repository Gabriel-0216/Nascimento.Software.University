namespace Nascimento.Software.University.Domain.Entities;

public class Course : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; } = 0.0M;

    public IList<Contract> Contracts { get; set; }

    public Course(string name, string description, decimal price)
    {
        Validator(name, description, price);

        if(!IsValid) return;

        SetData(name, description, price);
        
    }
    public void UpdateCourseData(string name, string description, decimal price){
        Validator(name, description, price);

        if(!IsValid) return;

        SetData(name, description, price);
    }

    private void SetData(string name, string description, decimal price){

        Name = name;
        Description = description;
        Price = price;
    }
    private void Validator(string name, string description, decimal price)
    {
        if (string.IsNullOrWhiteSpace(name)) AddNotification("Name", "The course's name cant be empty or null.");

        if (string.IsNullOrWhiteSpace(description)) AddNotification("description", "The course's description cant be empty or null.");

        if (price < 0.0M) AddNotification("Price", "The cost of a course cant be minus zero");
    }
    //um curso pode gerar N contratos
}

/*
Uma pessoa fisica tem n cursos, gera 1 contrato com n parcelas

*/