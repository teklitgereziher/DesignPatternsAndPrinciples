using DesignPatterns.Creational.AbstractFactory.AbstractProduct;

namespace DesignPatterns.Creational.AbstractFactory.Factory
{
  public interface IVehicleFactory
  {
    ICar GetCar(string carName, string[] carFeatures);
    IBike GetBike(string bikeName, string[] bikeFeatures);
  }
}
