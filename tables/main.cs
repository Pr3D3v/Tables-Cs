using System;


class MainClass {
 
 public static void Main (string[] args)
 {

 Console.WriteLine ("tables");

Console.WriteLine("enter the number of the table you want to see");
	
int m = Convert.ToInt32(Console.ReadLine());
	
Console.WriteLine("enter the number how many times table you want to see");
	
int n = Convert.ToInt32(Console.ReadLine());
	
Console.WriteLine(m + " times table");
	
for (int i = 0; i < n+1; i++) 
   
  {
  
   Console.WriteLine(m + " * " + i + " = " + m*i);
  
   }    
			
string a = Console.ReadLine();

Console.WriteLine(a);
			
  
}
}
//string input
//string d = Console.ReadLine();
//int input
//int e = Convert.ToInt32(Console.ReadLine());
