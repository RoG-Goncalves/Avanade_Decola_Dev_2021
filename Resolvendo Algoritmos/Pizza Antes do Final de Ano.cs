using System;

class Desafio3 { 
  
  public static void Main () {
    string[] entry = Console.ReadLine().Split(' ');
    int howManyPeople = int.Parse(entry[0]);
    int howManyDates = int.Parse(entry[1]);
    string date = "";
    int amountOfAvailablePeopleInTheDate = 0;
    bool match = false;

for(int givenDate = 0; givenDate < howManyDates ; givenDate++) {
	amountOfAvailablePeopleInTheDate = 0;
	string[] data = Console.ReadLine().Split(' ');
	date = data[0];
for (int singleVote = 1; singleVote < howManyPeople+1 ; singleVote++) {
	amountOfAvailablePeopleInTheDate += int.Parse(data[singleVote]);
}
match = (amountOfAvailablePeopleInTheDate == howManyPeople);
if(match) {break;}
  }
  if (match){ Console.Write(date); }
  else { Console.Write("Pizza antes de FdA"); }
  }
}