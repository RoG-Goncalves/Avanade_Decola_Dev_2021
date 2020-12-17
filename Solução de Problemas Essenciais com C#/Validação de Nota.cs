using System;

class Desafio4{
	public static void Main(string[] args){
		double sum = 0;
		int validGrades = 0;


do{

	double grades = double.Parse(Console.ReadLine());

	if (grade < 0 || grade > 10) 
	{
	Console.WriteLine("nota invalida");
	}
	else 
	{
	sum += grade;	
	validGrades++;
	}
} while(validGrades < 2);

		
Console.WriteLine("media = " +(sum/2).ToString("N2"));
	}
}