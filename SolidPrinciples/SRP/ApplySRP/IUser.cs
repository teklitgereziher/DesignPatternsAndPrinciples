namespace SolidPrinciples.SRP.ApplySRP
{
    public interface IUser
    {
        bool Login(string username, string password);
        bool Register(string username, string password, string email);
    }
}
