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
Console.WriteLine("current name is "+Name);
Console.WriteLine("suggest a name");
string NewName = Console.ReadLine();
LetsStartNewGame.SetName("NewName");
Console.WriteLine("new suggested name is "+LetsStartNewGame.GetName());
}
}
}

