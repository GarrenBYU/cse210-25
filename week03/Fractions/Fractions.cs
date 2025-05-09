using System.Security.Cryptography.X509Certificates;

class Fractions
{
    private int _numerator;
    private int _denominator;
    public Fractions(){
        _numerator = 1;
        _denominator = 1;
    }
        public Fractions(int wholeNumber){
        _denominator = 1;
        _numerator = wholeNumber;
    }
    public Fractions(int top, int bottom){
        _numerator = top;
        _denominator = bottom;
    }
    public string GetMakeFraction()
    {
        string text = $"{_numerator}/{_denominator}";
        return text;
    }
    public double GetDecimalValue()
    {
        return (double)_numerator / (double)_denominator;
    }
}