using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("969 E Citadel Ln", "Saratoga Springs", "UT", "USA");
        Customer customer1 = new Customer("Garren Meisman", address1);
        Product prodcut1 = new Product("Picture Frame", 56287, 5, 8);
        Product product2 = new Product("Picture", 951257, 12, 8);
        Order order1 = new Order(customer1);
        order1._products.Add(prodcut1);
        order1._products.Add(product2);
        order1.PackingLabel();
        order1.ShippingLabel();


        Address address2 = new Address("1st Tree", "Jungle", "Misiones", "AR");
        Customer customer2 = new Customer("George of the Jungle", address2);
        Product product3 = new Product("Art Stand", 95476, 20, 2);
        Product product4 = new Product("Eisel", 654785, 10, 4);
        Product product5 = new Product("Variety Paints", 657825, 5, 6);
        Order order2 = new Order(customer2);
        order2._products.Add(product3);
        order2._products.Add(product4);
        order2._products.Add(product5);
        order2.PackingLabel();
        order2.ShippingLabel();
    }
}