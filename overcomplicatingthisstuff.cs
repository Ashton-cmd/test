using System;

class Program
{
     static void Main(string[] args)
     {

string[] OrderIDs =        { "B123",
                            "C234",
                            "A345",
                            "C15",
                            "B177",
                            "G3003",
                            "C235",
                            "B179" };

 foreach (string orderID in OrderIDs)
 {
     if (orderID.StartsWith("B"))
     {
       
         Console.WriteLine($"Order {orderID} is suspicious!");
         int index = Array.IndexOf(OrderIDs, orderID);
         if (index != -1)
         {
             OrderIDs[index] = $"{orderID} was removed due to having the letter b at the beginning.";
         }
     }
 }
  Console.WriteLine("Orders currently being proccessed:\n");
 Array.Sort(OrderIDs);
 
 foreach (string orderID in OrderIDs)
 {
    if (orderID.StartsWith("B"))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(orderID);
        Console.ResetColor();
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(orderID);
        Console.ResetColor();
    }
 }
    Console.ResetColor();

      }
}
