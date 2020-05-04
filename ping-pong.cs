using System;
using System.Collections.Generic;
class PingPong
{
  static void Main()
  {
    Console.WriteLine("Enter a number for ping pong!");
    string stringNumEntry = Console.ReadLine();
    int numEntry = int.Parse(stringNumEntry);
    List<string> numList = new List<string> { };
    for (int i = 1; i <= numEntry; i++)
    {
      if (i % 15 == 0)
      {
        numList.Add("ping-pong");
      }
      else if (i % 3 == 0)
      {
        numList.Add("ping");
      }
      else if (i % 5 == 0)
      {
        numList.Add("pong");
      }
      else
      {
        numList.Add(i.ToString());
      }
    }
    foreach (string i in numList)
    {
      Console.WriteLine(i);
    }
  }
}