using System;

class Desafio1{
	public static void Main (){
		string[] number = int.Parse(Console.ReadLine());
		

		for(int i = 1; i <= number ; i++) {
			int square = i * i;
			int cubic = square * i;

			Console.Write(i + " "+ square + " " + cubic); 
		}
	}
}