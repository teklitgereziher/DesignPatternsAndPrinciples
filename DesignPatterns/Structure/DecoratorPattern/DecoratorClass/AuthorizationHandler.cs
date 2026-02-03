using DesignPatterns.Structure.DecoratorPattern.Interface;

namespace DesignPatterns.Structure.DecoratorPattern.DecoratorClass
{
  public class AuthorizationHandler(
    IRequestHandler requestHandler,
    IEnumerable<string> authorizedUsers
      ) : SanitizeRequest(requestHandler)
  {
    private readonly HashSet<string> _authorizedUsers = [.. authorizedUsers];

    public override string Handle(string request)
    {
      var user = ExtractUserFromRequest(request);
      if (!_authorizedUsers.Contains(user))
      {
        return $"User '{user}' is not authorized to make this request.";
      }
      return base.Handle(request);
    }

    private static string ExtractUserFromRequest(string request)
    {
      // Simple extraction logic (for demonstration purposes)
      var parts = request.Split(':');
      return parts.Length > 1 ? parts[0] : "unknown";
    }
  }
}
