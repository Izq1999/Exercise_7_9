using System;

class digits{
	static void Main(){
		//counters of number of digits a is for one digit, b is for 2 digits, c is for 3 digits and d is for more than 3 digits
		int digit1 = 0, digit2 = 0, digit3 = 0, digit_more3 = 0;
		Console.Write("Insert a number: ");
		// read the number as string to check the word "end"
		string input = Console.ReadLine();
		while(input!="end"){
			int number = Convert.ToInt32(input);
			if(number != 0){
				if(number/10 == 0)
					digit1 ++;  // it only has one digit
				else if (number/100 == 0)
					digit2 ++;  // the number has 2 digits
				else if (number/1000 == 0)
					digit3 ++;  // the number has 3 digits
				else
					digit_more3 ++;  // the number has more than 3 digits
			}
			input = Console.ReadLine();
		}
		Console.WriteLine("one: {0} two: {1} three: {2} more: {3}", digit1, digit2, digit3, digit_more3); 
	}
}

