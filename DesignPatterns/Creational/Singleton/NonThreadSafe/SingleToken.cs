namespace DesignPatterns.Creational.Singleton.NonThreadSafe
{
    public sealed class SingleToken
    {
        private static SingleToken _token;
        private static int _counter = 0;

        private SingleToken() 
        {
            _counter++;
            Console.WriteLine($"Counter = {_counter}");
        }

        public static SingleToken GetSingleTokenInstance()
        {
            if (_token == null) _token = new SingleToken();

            return _token;
        }

        public void PrintToken()
        {
            Console.WriteLine("Hello Token");
        }
    }
}
