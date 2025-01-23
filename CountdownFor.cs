using System;

class CountdownFor{
	static void Main(string[] args){
		//Take input from user
 		int n = Convert.ToInt32(Console.ReadLine());
		
		for(int i = n; i > 0; i--){ //run loop from n till 1 to get countdown
			Console.WriteLine(i);
		}
 	}
}