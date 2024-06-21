using System;

class Program {
  public static void Main (string[] args) {
    
int day1 = 0;
int day2 = 0;
int day3 = 0;
int day4 = 0;
int day5 = 0;
    
    int[] tempArr = {day1,day2,day3,day4,day5};
    String[] outputs = {"Its getting colder", "Its getting warmer", "Its a mixed bag"};
  for(int i = 0; i < 5; i++)
      {
      Console.WriteLine ("Input temperature for day " + (i+1) );
        tempArr[i] = int.Parse(Console.ReadLine());
      if( tempArr[i] >130 || tempArr[i] < -30)
        {
          Console.WriteLine("Invalid input");
          i--;
        }
      }
    Console.WriteLine(tempArr[4]);
  }
}