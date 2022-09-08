public class MoneyExchange
{
    public void MoneyExchangeCalculator(double money)
    {
        money = money * 100;

        int change;
        int thousand;
        int fiveHundred;
        int hundred;
        int fifty;
        int twenty;
        int ten;
        int five;
        int one;
        int pointfive;
        int pointtwofive;

        thousand = (int)money / 100000;
        change = (int)money % 100000;

        fiveHundred = change / 50000;
        change = change % 50000;

        hundred = change / 10000;
        change = change % 10000;

        fifty = change / 5000;
        change = change % 5000;

        twenty = change / 2000;
        change = change % 2000;

        ten = change / 1000;
        change = change % 1000;

        five = change / 500;
        change = change % 500;

        one = change / 100;
        change = change % 100;

        pointfive = change / 50;
        change = change % 50;

        pointtwofive = change / 25;
        change = change % 25;

        Console.WriteLine("1000 Baht :{0}", thousand);
        Console.WriteLine("500 Baht :{0}", fiveHundred);
        Console.WriteLine("100 Baht :{0}", hundred);
        Console.WriteLine("50 Baht :{0}", fifty);
        Console.WriteLine("20 Baht :{0}", twenty);
        Console.WriteLine("10 Baht :{0}", ten);
        Console.WriteLine("5 Baht :{0}", five);
        Console.WriteLine("1 Baht :{0}", one);
        Console.WriteLine("0.50 Baht :{0}", pointfive);
        Console.WriteLine("0.25 Baht :{0}", pointtwofive);
    }
}