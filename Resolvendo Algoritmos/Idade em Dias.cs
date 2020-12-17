using System;

class Desfaio5 {
	static void Main (string[] args) {
		var age = int.Parse(Console.ReadLine());
		var years = age/365;
		var months = (age%365)/30;
		var days = (age%365)%30;

		Console.Write($"{years} ano(s)\n{months} mes(es)\n{days} dia(s)");
	}
	
}