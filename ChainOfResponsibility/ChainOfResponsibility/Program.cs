using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            ICurrencyBill currency500 = new CurrencyBill(500, 10);
            ICurrencyBill currency200 = new CurrencyBill(200, 7);
            ICurrencyBill currency100 = new CurrencyBill(100, 13);
            ICurrencyBill currency50 = new CurrencyBill(50, 25);
            ICurrencyBill currency20 = new CurrencyBill(20, 15);
            ICurrencyBill currency10 = new CurrencyBill(10, 9);

            currency500.registerNext(currency200).registerNext(currency100).registerNext(currency50).registerNext(currency20).registerNext(currency10);

            Console.WriteLine(currency500.dispenseRequest(5));
        }
    }
}
