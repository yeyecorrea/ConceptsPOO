namespace ConceptsPOO
{
    public class SalaryEmploye : Employee
    {
        public decimal Salary { get; set; }
        public override decimal GetValueToPay()
        {
            return Salary;
        }

        public override string ToString()
        {
            /* El formatao C2 es : Currenci con dos decimales, pasa de estar asi: 220000000 a asi: 220.000.000,00 
             por defecto el utiliza el formato que se tenga en la maquina
             */

            return $"{base.ToString()}" + $"\n\tValue to pay : {GetValueToPay():C2}";
        }
    }
}
