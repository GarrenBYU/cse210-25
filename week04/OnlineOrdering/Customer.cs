using System;

public class Customer
{
    public string _name;
    Address _address();

    public void Customer(string name, Address address){
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