using SolidDesignPrinciples.LSP.AfterLSP;

namespace SolidPrinciples.LSP.Implementations.AfterLSP
{
    /// <summary>
    /// Contract employee is not eligible for bonus.
    /// Hence, the CalculateBonus methods throws exception.
    /// </summary>
    public class ContractEmployee : IEmployee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ContractEmployee() { }
        public ContractEmployee(int id, string name) 
        {
            Id = id;
            Name = name;
        }

        public decimal GetMinimumSalary()
        {
            return 5000;
        }

        public override string ToString()
        {
            return string.Format("ID : {0} Name : {1}", Id, Name);
        }
    }
}
