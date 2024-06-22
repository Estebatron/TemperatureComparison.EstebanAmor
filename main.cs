using System;

class Program {
  public static void Main (string[] args) {
    
    double day1 = 0;
    double day2 = 0;
    double day3 = 0;
    double day4 = 0;
    double day5 = 0;
    
  double[] dailyTemp = {day1,day2,day3,day4,day5};
  String[] outputs = {"Its getting colder", "Its getting warmer", "Its a mixed bag"};
    
 for(int i = 0; i < 5; i++)
    {
      Console.WriteLine ("Input temperature for day " + (i+1) );
        dailyTemp[i] = int.Parse(Console.ReadLine());
      if( dailyTemp[i] >130 || dailyTemp[i] < -30)
        {
          Console.WriteLine("Invalid input, please enter a temperature between -30 and 130");
          i--;
        }
    }
     Console.Write("5-day temperature [");
 foreach(double temp in dailyTemp)
    {
        Console.Write(temp+", ");
    }
     Console.WriteLine("]");
    
   double total = 0;
    for(int k = 0; k < 5; k++)
       { 
           total  = total + (dailyTemp[k]);
      }
    Console.WriteLine((total/5));
 }
}