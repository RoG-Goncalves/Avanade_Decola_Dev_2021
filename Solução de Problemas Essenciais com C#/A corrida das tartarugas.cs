using System;

class Desafio2 {
	public static void Main (string[] args) {
		string totalOfTurtles = Console.ReadLine();

do {
string[] speedsOfTurtles;
if (!string.IsNullOrWhiteSpace(totalOfTurtles)) {

speedsOfTurtles = Console.ReadLine().Split(' ');
int greatestSpeed = 0;

foreach (var individualSpeed in speedsOfTurtles) {
	if (Int32.Parse(individualSpeed) > greatestSpeed)
		greatestSpeed = Int32.Parse(individualSpeed);
}

if (greatestSpeed < 10)
{
    Console.WriteLine(1);
}
else if (greatestSpeed >= 10 && greatestSpeed < 20)
{
    Console.WriteLine(2);
}
else
{
    Console.WriteLine(3);
}

}
totalOfTurtles = Console.ReadLine();
} while(!string.IsNullOrWhiteSpace(totalOfTurtles));
	}
}