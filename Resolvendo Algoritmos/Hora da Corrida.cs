using System;

namespace desafio
{
  class Desafio1
  {
    static void Main(string[] args)
    {
      string[] entry = Console.ReadLine().Split(" ");
      int TotalOfLaps = int.Parse(entry[0]), NumberOfPLates = int.Parse(entry[1]);
      
      int TotalOfPlates = TotalOfLaps * NumberOfPLates;
      
      for(int i=10; i<= 90; i+= 10)
      {
        double HowMuchOfTheRunInPercentage = (double)TotalOfPlates / 100 * i;
        Console.Write(Math.Ceiling(HowMuchOfTheRunInPercentage) + " ");
      }
    }
  }
}