using System;

public class Customer
{
    public string _name;
    public Address _address;

    public Customer(string name, Address address){
        _name = name;
        _address = address;
    }

    public bool InUSA(){
        return _address.InUSA();
    }
    public void Display(){
        Console.WriteLine($"Customer: {_name}\nAddress: {_address.Display()}");
    }
}