using System;

class Desafio3{
	public static void Main (string[] args) {
		int R = Int32.Parse(Console.ReadLine());
		int V = 0;
		int sum = 0;
		int totalOfIterations = 0;

		while(V < R){
 
		V = Int32.Parse(Console.ReadLine());	
		}

		while (sum <= V){
			sum += R;
			R++;
			totalOfIterations++;
		}
		Console.Write(totalOfIterations);
	}
}