using System;
using System.Security.Cryptography.X509Certificates;

namespace Event_logging_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var someOrder = new Order(1, "McDonalds");
            someOrder.Notify += DisplayMessage;
            someOrder.AddPosition(OrderType.Banner);
            Console.ReadLine();
        }

        private static void DisplayMessage(OrderEventArgs orderEventArgs)
        {
            Console.WriteLine($"Транзакция с юр. лицом: {orderEventArgs.JuridicalPerson}");
            Console.WriteLine(orderEventArgs.Message);
        }
    }
}
