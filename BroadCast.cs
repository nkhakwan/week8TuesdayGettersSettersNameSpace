using System;
using System.Collections.Generic;
using Gamer.Testing;


namespace Gamer
{
public class Program
{
public static void Main()
{
Game LetsStartNewGame = new Game("John");
string Name = LetsStartNewGame.GetName();
Console.WriteLine(Name);
LetsStartNewGame.SetName("ilya");
Console.WriteLine(LetsStartNewGame.GetName());
}
}
}

