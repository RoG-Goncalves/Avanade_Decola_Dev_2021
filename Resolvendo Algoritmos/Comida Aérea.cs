using System;

class Desafio2 { 
  
  public static void Main (string[] args) {
    
    string[] availableMeals = Console.ReadLine().Split(' ');
      int availablePizzas = int.Parse(availableMeals[0]);
      int availableSalads = int.Parse(availableMeals[1]);
      int availablePastas = int.Parse(availableMeals[2]);
    
      string[] requiredMeals = Console.ReadLine().Split(' ');
      int requiredPizzas = int.Parse(requiredMeals[0]);
      int requiredSalads = int.Parse(requiredMeals[1]);
      int requiredPastas = int.Parse(requiredMeals[2]);

      int unservedCostumers = 0;
  
      int unservedPizzas = availablePizzas - requiredPizzas;
      int unservedSalads = availableSalads - requiredSalads;
      int unservedPastas = availablePastas - requiredPastas;

      if(unservedPizzas < 0)
      unservedCostumers = unservedCostumers + unservedPizzas;
      
      if(unservedSalads < 0)
      unservedCostumers = unservedCostumers + unservedSalads;
      
      if(unservedPastas < 0)
      unservedCostumers = unservedCostumers + unservedPastas;
    
      Console.Write(unservedCostumers*-1);
    
  }
}