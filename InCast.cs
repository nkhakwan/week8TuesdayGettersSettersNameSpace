namespace Gamer.Testing
{
public class Game
{
  // Private fields
  private string _name;
  private int _pointTotal;
  private string _stateOfMind;

  // Constructor
  public Game(string name)
  {
    _name = name;
    _pointTotal = 0;
    _stateOfMind = "neutral";
  }

  // Getters and Setters for fields
  public string GetName()
  {
    return _name;
  }

  public void SetName(string name)
  {
    _name = name;
  }

  public int GetPointTotal()
  {
    return _pointTotal;
  }

  public void SetPointTotal(int pointTotal)
  {
    _pointTotal = pointTotal;
  }

  public string GetStateOfMind()
  {
    return _stateOfMind;
  }

  public void SetStateOfMind(string stateOfMind)
  {
    _stateOfMind = stateOfMind;
  }

  // Public method
  public void DetermineNextSteps()
  {
    IncreasePoints();
    UpdateMood();
    IsGameOver();
  }

  // Private methods
  private void IncreasePoints()
  {
    _pointTotal++;
  }

  private void UpdateMood()
  {
    if (_pointTotal < 3)
    {
      _stateOfMind = "neutral";
    }
    else if (_pointTotal < 6)
    {
      _stateOfMind = "happy";
    }
    else
    {
      _stateOfMind = "thrilled";
    }
  }

  private string IsGameOver()
  {
    if (_stateOfMind == "thrilled")
    {
      return "You win!";
    }
    else
    {
      return "Keep playing...";
    }
  }
}
}