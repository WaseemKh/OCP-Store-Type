// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


public abstract class Store
{
    public int StoreId { get; set; }
    public string StoreName { get; set; }
    public string Type { get; set; }


    public abstract   void DoSomthing(Store obj);
   
}


public class OnlineStore : Store
{
    public override void DoSomthing(Store obj)
    {
        throw new NotImplementedException();
    }
}

public class RealityStore : Store
{
    public override void DoSomthing(Store obj)
    {
        throw new NotImplementedException();
    }
}

public class DeafoultStore : Store
{
    public override void DoSomthing(Store obj)
    {
        throw new NotImplementedException();
    }
}