namespace DesignPatterns.Behavioral.Strategy
{
  public class SortableContext
  {
    private ISortStrategy _sortStrategy;

    public void SetSortStrategy(ISortStrategy sortStrategy)
    {
      _sortStrategy = sortStrategy;
    }

    public IEnumerable<int> Sort(IEnumerable<int> items)
    {
      if (_sortStrategy == null)
      {
        throw new InvalidOperationException("Sort strategy not set.");
      }
      return _sortStrategy
      .Sort(items);
    }
  }
}
