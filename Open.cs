using System;
using Practice.Make;
using System.Collections.Generic;

namespace Practice
{
  public class Program
  {

    public static void main()
    {
      CarSpecs suzuki = new CarSpecs ("alto",56000, 1902);
      CarSpecs hyndai = new CarSpecs ("Santro", 50000, 5000);
      CarSpecs gm     = new CarSpecs ("prizm", 81000, 4200);
      CarSpecs honda  = new CarSpecs ("Accord", 47000, 8300);

      List<CarSpecs> Inventory = new List<CarSpecs>(suzuki, hyndai, gm, honda);
      List<CarSpecs> WithInBudgetCars = new List<CarSpecs>(0);

      console.WriteLine("what is your budget?");
      string Answer = console.ReadLine();
      int Budget = int.Parse(Answer);

      foreach(CarSpecs auto in Inventory)
      {
        if (auto.UnderBudget(Budget))
        {
          WithInBudgetCars.Add(auto);
        }
      }

      foreach(CarSpecs auto in WithInBudgetCars)
      {
        console.WriteLine(auto.GetPrice);

      }

    }













  }
}