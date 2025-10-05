using DesignPatterns.Creational.AbstractFactory.AbstractProduct;
using DesignPatterns.Creational.AbstractFactory.ConcreteProducts;
using DesignPatterns.Creational.AbstractFactory.Factory;

namespace DesignPatterns.Creational.AbstractFactory.ConcreteFactories
{
  /// <summary>
  /// Represents a factory for creating high-end vehicles, including bikes and cars.
  /// </summary>
  /// <remarks>This factory produces high-end implementations of the <see cref="IBike"/> and <see cref="ICar"/>
  /// interfaces. Use this factory when luxury or premium vehicle types are required.</remarks>
  public class HighEndVehicleFactory : IVehicleFactory
  {
    public IBike GetBike(string bikeName, string[] bikeFeatures)
    {
      return new HighEndBike(bikeName, bikeFeatures);
    }

    public ICar GetCar(string carName, string[] carFeatures)
    {
      return new HighEndCar(carName, carFeatures);
    }
  }
}
