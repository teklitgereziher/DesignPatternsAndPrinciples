using DesignPatterns.Creational.AbstractFactory.AbstractProduct;
using DesignPatterns.Creational.AbstractFactory.ConcreteProducts;
using DesignPatterns.Creational.AbstractFactory.Factory;

namespace DesignPatterns.Creational.AbstractFactory.ConcreteFactories
{
  /// <summary>
  /// Represents a factory for creating low-end vehicles, including bikes and cars.
  /// </summary>
  /// <remarks>This factory produces vehicles that are designed for basic functionality and affordability.
  /// Use this class when low-end vehicle options are required.</remarks>
  public class LowEndVehicleFactory : IVehicleFactory
  {
    public IBike GetBike(string bikeName, string[] bikeFeatures)
    {
      return new LowEndBike(bikeName, bikeFeatures);
    }

    public ICar GetCar(string carName, string[] carFeatures)
    {
      return new LowEndCar(carName, carFeatures);
    }
  }
}
