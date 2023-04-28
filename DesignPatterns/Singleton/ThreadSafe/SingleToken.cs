namespace DesignPatterns.Singleton.ThreadSafe
{
    /// <summary>
    /// This implementation is called "double check lock" and is safe in multithreaded environment.
    //  It provides lazy initialization for the Singleton object.
    /// </summary>
    public class SingleToken
    {
        private static SingleToken _token;
        private static int _counter = 0;
        public string TokenValue { get; private set; }
        // The lock object will be used to synchronize threads during first access to the Singleton
        private static object _lock = new object();

        private SingleToken() 
        {
            _counter++;
            Console.WriteLine($"Counter = {_counter}");
        }

        public static SingleToken GetSingleTokenInstance(string value)
        {
            // This condition is needed to avoid threads race for the lock while the instance is already crated.
            if (_token == null)
            {
                // Imagine that the program is launched for the first time and there is not Singleton instance yet.
                // Then multiple threads can pass the previous condition and reach this lock simultaneously.
                // Then one of the threads will get the lock and the remaining threads wait there.
                lock (_lock)
                {
                    // The thread that gets the lock proceeds further inside the condition and creates the Singleton instance.
                    // Once it releases the lock, the other thread waiting will get the lock, but the Singleton instance was
                    // already created and did not enter to the condition.
                    if (_token == null)
                    {
                        _token = new SingleToken();
                        _token.TokenValue = value;
                    }
                }
            }

            return _token;
        }

        public void PrintToken()
        {
            Console.WriteLine("Hello Token");
        }
    }
}
