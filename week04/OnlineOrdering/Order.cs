using System;

public class Order
{
    public List<Product> _products = new List<Product>();
    public int _totalCost = 0;
    public Customer _customer;
    public Order(Customer customer){
        _customer = customer;
    }
    public int TotalCost(){
        foreach(Product p in _products){
            _totalCost = p._cost + _totalCost;
        }
        return _totalCost;
    }
    public int LivesUSA(){
        if(_customer.InUSA() == true){
            _totalCost = _totalCost + 5;
            return _totalCost;
        }
        else{
            _totalCost = _totalCost + 35;
            return _totalCost;
        }
    }
    public void PackingLabel(){
        foreach(Product p in _products){
            Console.WriteLine($"{p._name}, {p._productId}\n");
        }
    }
    public void ShippingLabel(){
        _customer.Display();
    }

}