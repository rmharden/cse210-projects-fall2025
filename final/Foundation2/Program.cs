/*
Rebekah Harden
CSE 210: Programming with Classes
Brother Randall Booth
December 10, 2025

W13 Prove: Developer: Final Project

Program 2: Encapsulation with Online Ordering
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("\nWelcome to Program 2: Encapsulation with Online Ordering!\n");

        List<Product> products1 = new List<Product>();

        Address a1 = new Address("Tradespark Road", "Nairn", "Highland", "Scotland, UK");
        Customer c1 = new Customer("Helen Rose Falconer", a1);
        Product p1 = new Product("Chair", "ch1234", 499.99, 2);
        products1.Add(p1);
        Product p2 = new Product("Storage Bench", "sb1234", 299.99, 1);
        products1.Add(p2);
        Product p3 = new Product("Cabinet", "cs1234", 439.99, 2);
        products1.Add(p3);

        Order o1 = new Order(products1, c1);
        o1.GetShippingLabel();
        o1.GetPackingLabel();

        Console.WriteLine($"\nTotal Price: {o1.GetOrderTotalCost()}");



    }
}

/*
Sites I used for help:

Brother Chad Macbeth BYU-I Videos:
https://video.byui.edu/media/t/1_fnsp1qsi


*/