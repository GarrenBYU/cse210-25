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
    }
}