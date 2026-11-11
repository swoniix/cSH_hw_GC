namespace cSH_hw_GC;

enum ShopType
{
    Grocery,
    Household,
    Clothing,
    Shoes
}
class Shop : IDisposable
{
    public string Name{get;set;}
    public string Address{get;set;}
    public ShopType Type{get;set;}

    public Shop(string name, string address, ShopType type)
    {
        Name = name;
        Address = address;
        Type = type;
    }

    public void Dispose()
    {
        Console.WriteLine("Method Dispose has been called");
    }
    ~Shop()
    {
        Console.WriteLine("Method Dispose has been called");
    }
}