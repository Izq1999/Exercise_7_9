using System;

public class Average{
	public static void Main(){
		double sum=0, mark, quantity=0, average;
		string input;
		Console.Write("Insert a mark: ");
		input=Console.ReadLine();	// we read the mark as string to check the word "end"	 
		while(input!="end"){  // if the mark isn't an end then we pass it to double to work with it
			mark=Convert.ToDouble(input);
			quantity++;   //counter of numbers
			sum+=mark;  // sum of all the notes
			Console.Write("Insert a mark: ");
			input=Console.ReadLine();
		}
		if(quantity!=0){
			average=sum/quantity;  //calculate the average
			Console.WriteLine("The average is {0}.",average);
		}
	}
}
