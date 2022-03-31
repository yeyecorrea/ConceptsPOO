namespace ConceptsPOO
{
    public abstract class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        /*Estas propiedades son de tipo Date, de la clase que se creo manualmente
         a esto se le llama composicion ya que la clase Employee se compone de otra que es Date
         */
        public Date BirthDate { get; set; }
        public Date HiringDate { get; set; }
        public bool IsActive { get; set; }

        public abstract decimal GetValueToPay();
        public override string ToString()
        {
            return $"{Id} - {FirstName} {LastName}, Birth: {BirthDate}, Hirin: {HiringDate}, is Active: {IsActive}";
        }


    }
}
