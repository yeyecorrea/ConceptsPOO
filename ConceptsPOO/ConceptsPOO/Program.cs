using ConceptsPOO;

try
{
    Date dato1 = new Date(2022, 2, 29);
    Console.WriteLine(dato1);
}
catch (Exception error)
{

    Console.WriteLine(error.Message);
}
/*
 No hacerlo de esta forma ya que la clase SalaryEmploye hereda de la clase Employee, (SalaryEmploye salary1 = new SalaryEmploye();)
deberia de quedar asi
 */

// forma correcta de crear un objeto de una clase heredada
Employee employee1 = new SalaryEmploye()
{
    Id = 1010,
    FirstName = "Yeferson",
    LastName = "Correa Cardona",
    BirthDate = new Date(1999, 01, 17),
    HiringDate = new Date(2021, 03, 01),
    IsActive = true,
    // Se le pone M al final para indicar que es Money
    Salary = 220000000M
};
Console.WriteLine(employee1);

Employee employee2 = new CommissionEmployee()
{
    Id = 1010,
    FirstName = "Yeferson",
    LastName = "Correa Cardona",
    BirthDate = new Date(1999, 01, 17),
    HiringDate = new Date(2021, 03, 01),
    IsActive = true,
    // Se le pone M al final para indicar que es Money
    Sales = 40000000,
    CommissionPorcentaje = 0.05F
};
Console.WriteLine(employee2);
