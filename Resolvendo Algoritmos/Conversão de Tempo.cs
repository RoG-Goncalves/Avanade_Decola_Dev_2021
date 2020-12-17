using System;

class Desfaio4 {
	static void Main (string[] args) {
		var time = int.Parse(Console.ReadLine());
		var hours = time/3600;
		var minutes = (time%3600)/60;
		var seconds = (time%3600)%60;

		Console.Write($"{hours}:{minutes}:{seconds}");
	}
	
}