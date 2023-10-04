using PatternsApp.Models;
using System.Runtime.CompilerServices;

namespace PatternsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создание кофе
            CoffeeBuilder builder = new CoffeeBuilder();
            var coffee1 = builder.Build();

            builder = new CoffeeBuilder();
            var coffee2 = builder.AddEspressoShot()
                                .AddEspressoShot()
                                .AddMilk()
                                .Build();

            // Добавление топпингов
            coffee1 = new Caramel(coffee1);
            Console.WriteLine(coffee1);

            coffee2 = new Caramel(coffee2);
            coffee2 = new Chocolate(coffee2);
            Console.WriteLine(coffee2);

            // Создание заказа
            Order order = new Order();
            order.AddItem(coffee1);
            order.AddItem(coffee2);

            // Оплата заказа
            order.SetPaymentStrategy(new OnlinePayment());
            order.Pay();

            // order.SetPaymentStrategy(new CashPayment());
            // order.Pay();
        }
    }
}