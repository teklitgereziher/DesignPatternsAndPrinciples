namespace SolidPrinciples.LSP.BeforeLSP
{
    public class PermanentEmployee : Employee
    {
        public PermanentEmployee() { }
        public PermanentEmployee(int id, string name) : base(id, name) { }
        public override decimal CalculateBonus(decimal salary)
        {
            return salary * .1M;
        }
    }
}
