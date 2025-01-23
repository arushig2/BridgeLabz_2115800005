using System;

class CountdownWhile{
	static void Main(string[] args){
		//Take input from user
 		int n = Convert.ToInt32(Console.ReadLine());
		
		while(n != 0){ //using while loop print the countdown
			Console.WriteLine(n);
			n--; //decrement by 1 after printing
		}
 	}
}