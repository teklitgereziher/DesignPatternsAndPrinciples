using DesignPatterns.Structure.DecoratorPattern.Interface;

namespace DesignPatterns.Structure.DecoratorPattern.DecoratorClass
{
  public class LoggingHandler(
    IRequestHandler requestHandler
    ) : SanitizeRequest(requestHandler)
  {
    public override string Handle(string request)
    {
      Console.WriteLine($"[LOG] Handling request: {request}");
      var response = base.Handle(request);
      Console.WriteLine($"[LOG] Response: {response}");
      return response;
    }
  }
}
