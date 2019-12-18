using System;
using System.Runtime.Remoting.Channels;

namespace Event_logging_1
{
    public enum OrderType
    {
        Banner = 0,
        PriorityInTheRubric,
        CommentToTheCompany,
        AmountOfClicks,
        AdsInOtherCompany,
    }

    public class Order
    {
        public event EventHandler<OrderEventArgs> Notified = delegate {  };

        public ulong Id { get; set; }
        public string JuridicalPerson { get; set; }
        private double Cost { get; set; }

        public Order(ulong id, string jurPerson)
        {
            Id = id;
            JuridicalPerson = jurPerson;
            Cost = 0;
        }

        public void AddPosition(OrderType type)
        {
            Cost += OrderTypeCostMapper.GetCost[type];
            Notified(this, new OrderEventArgs($"Добавлена позиция по типу заказа: {type}. Сумма на счету {JuridicalPerson} - {Cost} руб.", Id, JuridicalPerson));
        }
    }
}