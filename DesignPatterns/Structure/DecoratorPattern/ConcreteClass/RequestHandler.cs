using DesignPatterns.Structure.DecoratorPattern.Interface;

namespace DesignPatterns.Structure.DecoratorPattern.ConcreteClass
{
  public class RequestHandler : IRequestHandler
  {
    public string Handle(string request)
    {
      return $"Request '{request}' has been handled.";
    }
  }
}
