using System;
using System.Collections.Generic;
using System.Linq;

class Program {
  
  static void Main(string[] args) {
 	var gems = new List<string>();
 	int counter = 0;

 	while(counter<106)
 	{
 		string gem = Console.ReadLine();
 		if(!gems.Contains(gem) && !string.IsNullOrWhiteSpace(gem))
 		{
			gems.Add(gem);
			
 		}
 	counter++;
 	} 
 	 	Console.Write(gems.Count());
  }

}