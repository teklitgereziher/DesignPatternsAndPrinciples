using DesignPatterns.Creational.AbstractFactory.AbstractProduct;

namespace DesignPatterns.Creational.AbstractFactory.ConcreteProducts
{
  /// <summary>
  /// Represents a high-end car with advanced features and premium specifications.
  /// </summary>
  /// <remarks>This class is intended to model luxury vehicles that implement the <see cref="ICar"/> interface.
  /// It can be extended to include additional properties and methods specific to high-end cars.</remarks>
  public class HighEndCar(string carName, string[] carFeatures) : ICar
  {
    private readonly string carName = carName;
    private readonly string[] carFeatures = carFeatures;

    public string GetCarFeatures()
    {
      return string.Join(", ", carFeatures);
    }

    public string GetCarName()
    {
      return carName;
    }
  }
}
