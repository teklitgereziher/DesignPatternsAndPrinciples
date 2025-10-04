namespace DesignPatterns.Creational.Singleton.LazyLoading
{
    /// <summary>
    /// This implementation is called "double check lock" and is safe in multithreaded environment.
    //  It provides lazy initialization for the Singleton object.
    /// </summary>
    public class SingleToken
    {
        private static readonly Lazy<SingleToken> _token = new Lazy<SingleToken>(() => new SingleToken());
        private static int _counter = 0;
        public string TokenValue { get; private set; }

        private SingleToken() 
        {
            _counter++;
            Console.WriteLine($"Counter = {_counter}");
        }

        /// <summary>
        /// By default, Lazy<T> objects are thread-safe. 
        /// That is, if the constructor does not specify the kind of thread safety, the Lazy<T> objects it creates are thread-safe
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static SingleToken GetSingleTokenInstance(string value)
        {
            return _token.Value;
        }

        public void PrintToken()
        {
            Console.WriteLine("Hello Token");
        }
    }
}
