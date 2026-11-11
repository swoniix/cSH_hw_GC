using System;
using cSH_hw_GC;

class Program
{
    static void Main()
    {
        Console.WriteLine("Task 1: ");
        //1
        Piesa piesa = new Piesa(
            "Cook book",
            "Kyka Kykovich Kykov",
            "horror",
            Convert.ToInt32("1967"));
        
        Console.WriteLine("Title: " + piesa.Title);
        Console.WriteLine("Author: " + piesa.Author);
        Console.WriteLine("Genre: " + piesa.Genre);
        Console.WriteLine("Year: " + piesa.Year);
        
        piesa.Dispose();
        piesa = null;
        // GC.Collect();
        // GC.WaitForPendingFinalizers();
        
        //2
        Console.WriteLine("\nTask 2:");
        Shop shop = new Shop(
            "Misya",
            "5 Street",
            ShopType.Grocery);
        Console.WriteLine("Shop Name: " + shop.Name);
        Console.WriteLine("Shop Address: " + shop.Address);
        Console.WriteLine("Shop Type: " + shop.Type);
        
        shop.Dispose();
        shop = null;
        GC.Collect();
        GC.WaitForPendingFinalizers();
    }
   
}