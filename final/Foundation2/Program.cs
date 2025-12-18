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
        Console.WriteLine(o1.GetShippingLabel());
        Console.WriteLine($"\nOrder 1 Total Price: ${o1.GetOrderTotalCost():F2}");
        Console.WriteLine(o1.GetPackingLabel());


        List<Product> products2 = new List<Product>();

        Address a2 = new Address("Houvej 59", "Tranekær", "Region Syddanmark", "Danmark");
        Customer c2 = new Customer("Erastus Frandsen", a2);
        Product p1c2 = new Product("Chair", "ch1234", 499.99, 1);
        products2.Add(p1c2);
        Product p2c2 = new Product("Indoor Pouf", "IP1234", 99.99, 4);
        products2.Add(p2c2);
        Product p3c2 = new Product("Ivory Throw", "IT1234", 39.99, 1);
        products2.Add(p3c2);
        Product p4c2 = new Product("Throw Pillow", "TPi123", 9.99, 4);
        products2.Add(p4c2);

        Order o2 = new Order(products2, c2);
        Console.WriteLine(o2.GetShippingLabel());
        Console.WriteLine($"\nOrder 2 Total Price: ${o2.GetOrderTotalCost():F2}");
        Console.WriteLine(o2.GetPackingLabel());

        // I'm trying a different format for writing the last Order and Customer:


        Address a3 = new Address("420 N Main St", "Muenster", "Texas", "USA");
        Customer c3 = new Customer("Catherine Höpler", a3);

        List<Product> products3 = new List<Product>();
        Product p1c3 = new Product("", "", 0, 0);
        Product p2c3 = new Product("", "", 0, 0);
        Product p3c3 = new Product("", "", 0, 0);

        products3.Add(p1c3);
        products3.Add(p2c3);
        products3.Add(p2c3);

        Order o3 = new Order(products3, c3);
        Console.WriteLine(o3.GetShippingLabel());
        Console.WriteLine($"\nOrder 3 Total Price: ${o3.GetOrderTotalCost():F2}")
        

    }
}


/*
Shipping Label
================
Helen Rose Falconer
Tradespark Road, Nairn, Highland, Scotland, UK

Order 1 Total Cost: $2214.95
Packing Label
================
ch1234 - Chair
sb1234 - Storage Bench
cs1234 - Cabinet

*/

/*
Sites I used for help:

Brother Chad Macbeth BYU-I Videos:
https://video.byui.edu/media/t/1_fnsp1qsi


*/