namespace SolidPrinciples.SRP.WithoutSRP
{
    public interface IUser
    {
        bool Login(string username, string password);
        bool Register(string username, string password, string email);
        void LogError(string errMessage);
        bool SendEmail(string emailContent);
    }
}
