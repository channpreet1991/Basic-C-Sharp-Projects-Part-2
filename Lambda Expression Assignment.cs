using System;
namespace HelloWorld {
   class Program {
       static void Main(string[] args) {
           string[] weekDays = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
           Console.Write("Select an index from 0-6: "); 
           int index = Convert.ToInt32(Console.ReadLine());
           if (index>6 || index<0) {
               Console.WriteLine("Index doesn't exist");
           } else {
               Console.WriteLine(weekDays[index]);
           }
           
           int[] numbers = {10, 20, 30, 40, 50, 60, 70};
           Console.Write("Select an index from 0-6: "); 
           index = Convert.ToInt32(Console.ReadLine());
           if (index>6 || index<0) {
               Console.WriteLine("Index doesn't exist");
           } else {
               Console.WriteLine(numbers[index]);
           }
           
           List<string> cities = new List<string>{"New York", "London", "Mumbai", "Chicago", "Jakarta", "Tokyo", "Beijing"}; 
           
           Console.Write("Select an index from 0-6: "); 
           index = Convert.ToInt32(Console.ReadLine());
           if (index>6 || index<0) {
               Console.WriteLine("Index doesn't exist");
           } else {
               Console.WriteLine(cities[index]);
           }
       }
   }
}