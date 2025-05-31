using System;

public class Product
{
    public string _name;
    public int _productId;
    public int _price;
    public int _quantity;
    public int _cost;
    public Product(string name, int id, int price, int quantity){
        _name = name;
        _productId = id;
        _price = price;
        _quantity = quantity;
        _cost = _price * _quantity;
    }
}