using System;

public class Address
{
    public string _streetAddress;
    public string _city;
    public string _state;
    public string _country;

    public Address(string streetAddress = "", string city ="", string state ="", string country =""){
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool InUSA(){
        if(_country == "USA"){
            return true;
        }
        else{
            return false;
        }
    }

    public string Display(){
        return ($"The Address is:\n{_streetAddress}\n{_city}, {_state}\n{_country}");
    }
}