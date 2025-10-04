namespace DesignPatterns.Creational.Singleton.EagerLoading
{
    /// <summary>
    /// This implementation is called "double check lock" and is safe in multithreaded environment.
    //  It provides lazy initialization for the Singleton object.
    /// </summary>
    public class SingleToken
    {
        private static readonly SingleToken _token = new SingleToken();
        private static int _counter = 0;
        public string TokenValue { get; private set; }

        private SingleToken() 
        {
            _counter++;
            Console.WriteLine($"Counter = {_counter}");
        }

        public static SingleToken GetSingleTokenInstance(string value)
        {
            // How it is thread safe?
            // The CLR takes care of the variable initialization and it is thread safe.
            // No need to write code for thread safety
            return _token;
        }

        public void PrintToken()
        {
            Console.WriteLine("Hello Token");
        }
    }
}
