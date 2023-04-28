namespace DesignPatterns.Singleton.NonThreadSafe
{
    public sealed class SingleToken
    {
        private static SingleToken _token;

        private SingleToken() { }

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
