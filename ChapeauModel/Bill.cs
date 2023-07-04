using System;
using System.Collections.Generic;

namespace ChapeauModel
{
    public class Bill
    {
        public int billId;
        public Table table;
        public Employee employee;
        public string comment;
        public PaymentMethod paymentMethod;
        public bool payed;
        public double tip;
        public DateTime dateTime;
        public double billPrice;
    }
}
