namespace  Practice.Make
{
  public class CarSpecs
  {
    private string _carMake;
    private int _mileage;
    private int _price;
  

  public CarSpecs(string carMake, int mileage, int price)
  {
    _carMake = carMake;
    _mileage = mileage;
    _price = price;
  }

  public string GetCarMake()
  {
    return _carMake;
  }

  public int GetPrice()
  {
    return _price;
  }

  public int GetMileage()
  {
    return _mileage;
  }

  public bool UnderBudget(int Budget)
  {
    return (_price<Budget);
  }
  }
}