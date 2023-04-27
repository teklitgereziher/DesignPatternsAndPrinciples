namespace SolidPrinciples.OCP.BeforeOCP
{
    /// <summary>
    /// This class is not closed for modification.
    /// We added an EmployeeType property and modified the CalculateBonus method
    /// to add the feature bonus calculation by employee type.
    /// </summary>
    public class Employee
    {
        public int ID { get; set; }       
        public string Name { get; set; }
        // To handle the bonus calculation for permanent and contract employees.
        public string EmployeeType { get; set; }

        public Employee() { }
        public Employee(int id, string name, string type)
        {
            ID = id;
            Name = name;
            EmployeeType = type;
        }

        public decimal CalculateBonus(decimal salary)
        {
            if (this.EmployeeType == "Permanent")
                return salary * .1M;
            else
                return salary * .05M;
        }
    }
}
