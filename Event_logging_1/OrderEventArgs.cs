using System;

namespace Event_logging_1
{
    public class OrderEventArgs : EventArgs
    {
        public string Message { get; }
        public ulong Id { get; }
        public string JuridicalPerson { get; }

        public OrderEventArgs(string message, ulong id, string juridicalPerson)
        {
            Message = message;
            Id = id;
            JuridicalPerson = juridicalPerson;
        }
    }
}