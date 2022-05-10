using System;
    
public class Program
{
enum days {
Monday = 0, //0
Tuesday = 1,    //2
Wednesday = 2,
Thursday = 3,
Friday = 4,
Saturday = 5,
Sunday =6    //6
}

public static void Main()
{
 try 
 {
  Console.WriteLine("Enter Day of the week:");
  var day = Console.ReadLine();
  switch(day) 
   {
     case "Monday":
      // code block 
    Console.WriteLine("Monday");
       break;
     case "Tuesday":
      // code block
       Console.WriteLine("Tuesday");
    break;
   case "Wednesday":
      // code block
       Console.WriteLine("Wednesday");
    break;
   case "Thursday":
      // code block
       Console.WriteLine("Thursday");
    break;
   case "Friday":
      // code block
       Console.WriteLine("Friday");
    break;
   case "Saturday":
      // code block
       Console.WriteLine("Saturday");
    break;
   case "Sunday":
      // code block
       Console.WriteLine("Sunday");
    break;
    
     default:
       // code block
    Console.WriteLine("Please enter an actual day of the week");
       break;
  }
 }
