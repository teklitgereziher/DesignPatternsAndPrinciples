namespace DesignPatterns.Behavioral.Strategy
{
  public interface ISortStrategy
  {
    IOrderedEnumerable<int> Sort(IEnumerable<int> numbers);
  }
}
