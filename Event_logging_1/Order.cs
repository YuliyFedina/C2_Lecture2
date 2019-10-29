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
        public delegate void OrderHandler(OrderEventArgs orderEventArgs);
        public event OrderHandler Notify;

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
            Notify?.Invoke(new OrderEventArgs($"Добавлена позиция по типу заказа: {type}, на сумму {OrderTypeCostMapper.GetCost[type]} руб. Сумма на счету {JuridicalPerson} - {Cost} руб.", Id, JuridicalPerson));
        }
    }
}