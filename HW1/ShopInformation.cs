public class ShopInformation
{
    public void PrintInformation(string ShopName, string TINumber, string ShopOwnerName, string Value)
    {
        Console.WriteLine("---------- Shop Information ----------");
        Console.WriteLine("Name: {0}", ShopName);
        Console.WriteLine("Number: {0}", TINumber);
        Console.WriteLine("Owner Name: {0}", ShopOwnerName);
        Console.WriteLine("Regitered Value: {0}", Value);
        Console.WriteLine("—-------------------------------------");
    }
}