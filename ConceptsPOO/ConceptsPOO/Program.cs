using ConceptsPOO;
/*
try
{
    Date dato1 = new Date(2022, 2, 29);
    Console.WriteLine(dato1);
}
catch (Exception error)
{

    Console.WriteLine(error.Message);
}
*/
/*
 No hacerlo de esta forma ya que la clase SalaryEmploye hereda de la clase Employee, (SalaryEmploye salary1 = new SalaryEmploye();)
deberia de quedar asi
 */
Console.WriteLine("------------------------------------------------------------------------------");
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

Console.WriteLine("------------------------------------------------------------------------------");

Employee employee2 = new CommissionEmployee()
{
    Id = 1020,
    FirstName = "Carlos",
    LastName = "Cardona",
    BirthDate = new Date(1979, 08, 27),
    HiringDate = new Date(2019, 06, 02),
    IsActive = true,
    // Se le pone M al final para indicar que es Money
    Sales = 40000000M,
    CommissionPorcentaje = 0.05F
};
Console.WriteLine(employee2);

Console.WriteLine("------------------------------------------------------------------------------");

Employee employee3 = new HourlyEmployee()
{
    Id = 1030,
    FirstName = "Jaime",
    LastName = "Gutierrez",
    BirthDate = new Date(1989, 05, 17),
    HiringDate = new Date(2022, 06, 01),
    IsActive = true,
    Hours = 123.5F,
    HourValue = 1234.56M
};
Console.WriteLine(employee3);

Console.WriteLine("------------------------------------------------------------------------------");

Employee employee4 = new BasicComissionEmployee()
{
    Id = 1030,
    FirstName = "Jaime",
    LastName = "Gutierrez",
    BirthDate = new Date(1989, 05, 17),
    HiringDate = new Date(2022, 06, 01),
    IsActive = true,
    Basic = 320000000M,
    Sales = 500000000M,
    CommissionPorcentaje = 0.08F
};
Console.WriteLine(employee4);

Console.WriteLine("------------------------------------------------------------------------------");

// Conoctacion diamante se llama
ICollection<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3, employee4
};

decimal payroll = 0;

foreach (var employe in employees)
{
    Console.WriteLine(employe);
    payroll += employe.GetValueToPay();
}
Console.WriteLine("                              ============");
Console.WriteLine($"TOTAL:                       {payroll:C2}");

Console.WriteLine("-------------------------------------------------------------------------------");

Invoice invoice1 = new Invoice()
{
    Description = "Venta de camisas",
    Id = 1,
    Price = 45000000M,
    Quantity = 20.0F
};

Invoice invoice2 = new Invoice()
{
    Description = "Venta de zapatos",
    Id = 2,
    Price = 235000M,
    Quantity = 10.0F
};

Console.WriteLine(invoice1);
Console.WriteLine(invoice2);
