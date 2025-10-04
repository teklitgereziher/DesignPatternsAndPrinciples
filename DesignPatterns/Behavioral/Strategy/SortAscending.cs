namespace DesignPatterns.Behavioral.Strategy
{
  public class SortAscending : ISortStrategy
  {
    public IOrderedEnumerable<int> Sort(IEnumerable<int> numbers)
    {
      return numbers.OrderBy(x => x);
    }
  }
}
