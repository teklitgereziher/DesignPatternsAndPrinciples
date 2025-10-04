namespace DesignPatterns.Behavioral.Strategy
{
  public class SortDescending : ISortStrategy
  {
    public IOrderedEnumerable<int> Sort(IEnumerable<int> numbers)
    {
      return numbers.OrderByDescending(x => x);
    }
  }
}
