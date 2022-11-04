// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


public class Store
{
    public int StoreId { get; set; }
    public string StoreName { get; set; }
    public string Type { get; set; }


    public void _doSomthing(Store obj)
    {

        if(obj.Type  == "hypothetical")
        {

        //do by EF Operation 
        }else if(obj.Type == "Physical")
        {
            //do by EF Operation 
        }
        else if(obj.Type == "unscheduled")
        {
            //do by EF Operation 
        }
    }
}