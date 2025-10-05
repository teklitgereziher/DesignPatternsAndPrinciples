using DesignPatterns.Creational.AbstractFactory.AbstractProduct;

namespace DesignPatterns.Creational.AbstractFactory.ConcreteProducts
{
  /// <summary>
  /// Represents a basic implementation of a bike with minimal features.
  /// </summary>
  /// <remarks>This class is intended for scenarios where a simple, low-cost bike implementation is sufficient.
  /// It implements the <see cref="IBike"/> interface, providing the required functionality for a bike.</remarks>
  public class LowEndBike(string bikeName, string[] bikeFeatures) : IBike
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
