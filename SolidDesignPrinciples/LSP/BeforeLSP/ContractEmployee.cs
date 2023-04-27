namespace SolidPrinciples.LSP.BeforeLSP
{
    /// <summary>
    /// Contract employee is not eligible for bonus.
    /// Hence, the CalculateBonus methods throws exception.
    /// </summary>
    public class ContractEmployee : Employee
    {
        public ContractEmployee() { }
        public ContractEmployee(int id, string name) : base(id, name) { }
        public override decimal CalculateBonus(decimal salary)
        {
            throw new NotImplementedException();
        }
    }
}
