using DesignPatterns.Structure.DecoratorPattern.Interface;

namespace DesignPatterns.Structure.DecoratorPattern.DecoratorClass
{
  public class SanitizeRequest : IRequestHandler
  {
    private readonly IRequestHandler _requestHandler;

    public SanitizeRequest(IRequestHandler requestHandler)
    {
      _requestHandler = requestHandler;
    }

    public virtual string Handle(string request)
    {
      var sanitizedRequest = Sanitize(request);
      return _requestHandler.Handle(sanitizedRequest);
    }

    private static string Sanitize(string request) =>
      // Simple sanitization logic (for demonstration purposes)
      request.Replace("<", "&lt;").Replace(">", "&gt;");
  }
}
