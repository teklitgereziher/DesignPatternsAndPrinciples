using DesignPatterns.Creational.AbstractFactory.AbstractProduct;

namespace DesignPatterns.Creational.AbstractFactory.ConcreteProducts
{
  /// <summary>
  /// Represents a high-end bicycle with advanced features and premium components.
  /// </summary>
  /// <remarks>This class is intended for use in scenarios where high performance and quality are required, such
  /// as competitive cycling or long-distance rides.</remarks>
  public class HighEndBike(string bikeName, string[] bikeFeatures) : IBike
  {
    private readonly string bikeName = bikeName;
    private readonly string[] bikeFeatures = bikeFeatures;

    public string GetBikeFeatures()
    {
      return string.Join(", ", bikeFeatures);
    }

    public string GetBikeName()
    {
      return bikeName;
    }
  }
}
