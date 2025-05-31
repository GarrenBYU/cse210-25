using System;

public class Order
{
    public List<Product> _products = new List<Product>();
    public int _totalCost;
    public Customer _customer;
    public void Order(Customer customer){
        _customer = customer;
    }
    public int TotalCost(){
        foreach(Product p in _products){
            _totalCost = p._cost + _totalCost;
            return _totalCost;
        }
    }
    public int LivesUSA(){
        if(_customer.InUSA() == true){
            _totalcost = _totalCost + 5;
            return _totalCost;
        }
        else(){
            _totalcost = _totalCost + 35;
            return _totalCost;
        }
    }
    public void PackingLabel(){
        foreach(Product p in _products){
            Console.WriteLine($"{p.name}, {p._productId}\n");
        }
    }
    public void ShippingLabel(){
        _customer.Display()
    }

}