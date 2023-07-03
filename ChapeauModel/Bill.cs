using System;
using System.Collections.Generic;

namespace ChapeauModel
{
    public class Bill
    {
        List<Order> orders;
        public int billId;
        public Table table;
        public Employee employee;
        public string comment;
        public PaymentMethod paymentMethod;
        public bool payed;
        public double tip;
        public DateTime dateTime;
        public double billPrice;


        public Bill()
        {
            orders = new List<Order>();
        }

        public void CalculateBill()
        {

        }

        public double CalculateVAT(double vat, double price)
        {
            return price * (vat / 100); //8 * 0.21
        }

        public double CalculateTotalPrice(double vat, double amount, double price) 
        {
            return (price * amount) * (1 + vat); //(8 * 2) * (1 + vat) = 
        }

        public double CalculateTotalVAT(double price, double vat)
        {
            return price * (vat / 100);    
        }

        public void UpdateBill() 
        {

        }

        public string StringOverride(double value)
        {
            return "€ " + value.ToString("F");
        }
    }
}
