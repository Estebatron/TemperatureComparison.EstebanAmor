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
    }// end of user input loop



    if ( dailyTemp[0] > dailyTemp[1] && dailyTemp[1] > dailyTemp[2] &&               dailyTemp[2] > dailyTemp[3] && dailyTemp[3] > dailyTemp[4])
        {
          Console.WriteLine(outputs[0]);
        }
    else if( dailyTemp[0] < dailyTemp[1] && dailyTemp[1] < dailyTemp[2] &&           dailyTemp[2] < dailyTemp[3] && dailyTemp[3] < dailyTemp[4])
        {
         Console.WriteLine(outputs[1]);
        }   
    else {
          Console.WriteLine(outputs[2]);
        }
 
    
    // above  statement checks if the temperatures are in order from coldest to hottest, hottest to coldest or neither
    
     Console.Write("5-day temperature ["); // displays the 5 day temperatures
 foreach(double temp in dailyTemp)
    {
        Console.Write(temp+", ");
    }
     Console.WriteLine("]");
    
   double total = 0; // creates a value to store all the days temp added together
    for(int k = 0; k < 5; k++)
       { 
           total  = total + (dailyTemp[k]);
      }
    Console.WriteLine("Average temperature is "+(total/5)+ " degrees");// displays the average weekly temperature
 }
}