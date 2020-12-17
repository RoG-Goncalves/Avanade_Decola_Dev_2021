using System;

class Desafio 6 {
	public static void Main (string[] args) {
		int timeUntillEndOfWork = int.Parse(Console.ReadLine());
		string[] minutesToMakeGift = Console.ReadLine().Split(' ');
		int minutesGiftOne = int.Parse(minutesToMakeGift[0]), minutesGiftTwo = int.Parse(minutesToMakeGift[1]);

		int timeToMakeAllGifts = minutesGiftOne + minutesGiftTwo;

		if(timeToMakeAllGifts>timeUntillEndOfWork){
			Console.Write("Deixa para amanha!");
		}
		else{
			Console.Write("Farei hoje!");

		}
	}
}