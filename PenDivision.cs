using System;

class PenDivision{
	static void Main(){
		
 		int pens = 14;
 		int students = 3;
 		int eachStudent = pens / students;
		int remaining = pens % students;
		
		Console.WriteLine("The Pen Per Student is " + eachStudent + " and the remaining pen not distributed is "+remaining);

 	}
}