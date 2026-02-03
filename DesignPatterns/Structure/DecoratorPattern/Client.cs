using DesignPatterns.Structure.DecoratorPattern.ConcreteClass;
using DesignPatterns.Structure.DecoratorPattern.DecoratorClass;
using DesignPatterns.Structure.DecoratorPattern.Interface;

namespace DesignPatterns.Structure.DecoratorPattern
{
  /// <summary>
  /// We can stack decorators to handle multiple responsibilities in sequence.
  /// </summary>
  public class Client
  {
    public static void DecoratorMain()
    {
      // Base request handler
      IRequestHandler requestHandler = new RequestHandler();
      // Wrap with authorization decorator
      var authorizedUsers = new List<string> { "alice", "bob" };
      requestHandler = new AuthorizationHandler(requestHandler, authorizedUsers);
      // Wrap with logging decorator
      requestHandler = new LoggingHandler(requestHandler);

      // Create requests
      var requests = new List<string>
      {
        "alice: <data>Important Info</data>",
        "eve: <data>Malicious Info</data>"
      };
      // Process requests
      foreach (var request in requests)
      {
        var response = requestHandler.Handle(request);
        Console.WriteLine(response);
      }
    }
  }
}
