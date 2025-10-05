using DesignPatterns.Creational.AbstractFactory.AbstractProduct;

namespace DesignPatterns.Creational.AbstractFactory.ConcreteProducts
{
  /// <summary>
  /// Represents a low-end car model.
  /// This class implements the <see cref="ICar"/> interface and is intended to model
  /// basic, entry-level vehicles with minimal features and lower cost.
  /// </summary>
  public class LowEndCar(string carName, string[] carFeatures) : ICar
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
