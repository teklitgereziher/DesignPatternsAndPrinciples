namespace DesignPatterns
{
  internal class Program
  {
    public static void TestSingleTokenThreadSafe(string value)
    {
      Creational.Singleton.ThreadSafe.SingleToken singleton =
        Creational.Singleton.ThreadSafe.SingleToken
        .GetSingleTokenInstance(value);
      Console.WriteLine(singleton.TokenValue);
    }

    public static void TestSingleTokenNonThreadSafe(string value)
    {
      Creational.Singleton.NonThreadSafe.SingleToken singleton =
        Creational.Singleton.NonThreadSafe.SingleToken
        .GetSingleTokenInstance();
    }

    public static void TestSingleTokenEagerLoading(string value)
    {
      Creational.Singleton.EagerLoading.SingleToken singleton =
        Creational.Singleton.EagerLoading.SingleToken
        .GetSingleTokenInstance(value);
    }

    public static void TestSingleTokenLazyLoading(string value)
    {
      Creational.Singleton.LazyLoading.SingleToken singleton =
        Creational.Singleton.LazyLoading.SingleToken
        .GetSingleTokenInstance(value);
    }

    static void Main(string[] args)
    {
      // BEGIN --------------------- Singleton Pattern ---------------------------
      //DemoSingletonPattern();
      // END --------------------- Singleton Pattern ---------------------------

      // Begin --------------------- Strategy Pattern
      DemoStrategyPattern();
      // End --------------------- Strategy Pattern
    }

    private static void DemoStrategyPattern()
    {
      var items = new List<int> { 5, 3, 8, 1, 2 };
      Console.WriteLine("Original items: " + string.Join(", ", items));
      var context = new Behavioral.Strategy.SortableContext();
      context.SetSortStrategy(new Behavioral.Strategy.SortAscending());
      var sortedItems = context.Sort(items);
      Console.WriteLine("Sorted items: " + string.Join(", ", sortedItems));
    }

    private static void DemoSingletonPattern()
    {
      // None thread safe Singleton pattern
      //NoThreadSafeSingleton.SingleToken token1 = NoThreadSafeSingleton.SingleToken.GetSingleTokenInstance();
      //NoThreadSafeSingleton.SingleToken token2 = NoThreadSafeSingleton.SingleToken.GetSingleTokenInstance();
      ////Check if the two instances are equal
      //if (token1 == token2) Console.WriteLine("Creation of Single instance succeeded!");
      //else Console.WriteLine("Creation of Single instance failed!");
      //Parallel.Invoke(() => TestSingleTokenNonThreadSafe("PUBLIC_TOKEN"), () => TestSingleTokenNonThreadSafe("PRIVATE_TOKEN"));

      // Thread safe Singleton pattern
      //Thread thread1 = new Thread(() => { TestSingleton("PUBLIC_TOKEN"); });
      //Thread thread2 = new Thread(() => { TestSingleton("PRIVATE_TOKEN"); });

      //thread1.Start();
      //thread2.Start();

      //thread1.Join();
      //thread2.Join();

      //Parallel.Invoke(() => TestSingleTokenThreadSafe("PUBLIC_TOKEN"), () => TestSingleTokenThreadSafe("PRIVATE_TOKEN"));

      // Singleton instance using Eager Loading
      //Parallel.Invoke(() => TestSingleTokenEagerLoading("PUBLIC_TOKEN"), () => TestSingleTokenEagerLoading("PRIVATE_TOKEN"));

      // Singleton instance using Lazy Loading
      Parallel.Invoke(() => TestSingleTokenLazyLoading("PUBLIC_TOKEN"), () => TestSingleTokenLazyLoading("PRIVATE_TOKEN"));
    }
  }
}
