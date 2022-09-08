public class Program
{
    public static string InputName()
    {
        Console.Write("Please input Name: ");
        return Console.ReadLine();
    }
    public static string InputNumber()
    {
        Console.Write("Please input Number: ");
        return Console.ReadLine();
    }
    public static string InputOwnerName()
    {
        Console.Write("Please input Owner Name: ");
        return Console.ReadLine();
    }
    public static string InputRegisteredValue()
    {
        Console.Write("Please input Registered Value: ");
        return Console.ReadLine();
    }
    public static string InputMoney()
    {
        Console.Write("Please input Money: ");
        return Console.ReadLine();
    }
    public static double ConvertStringToDouble(string baht)
    {
        if (double.TryParse(baht, out double All))
        {
            return All;
        }
        throw new Exception("Please input money again");
    }
    static void Main (string[] args)
    {
        string ShopName = InputName();
        string TINumber = InputNumber();
        string ShopOwnerName = InputOwnerName();
        string Value = InputRegisteredValue();
        ShopInformation info = new ShopInformation();
        info.PrintInformation(ShopName, TINumber, ShopOwnerName, Value);
        string baht = InputMoney();
        double money = ConvertStringToDouble(baht);
        MoneyExchange Money = new MoneyExchange();
        Money.MoneyExchangeCalculator(money);
    }
}