using System.Collections.Generic;

namespace ChapeauModel
{
    public class Bill
    {
        List<Order> orders;
        public int billId;
        public int employeeId;
        public string comment;
        public PaymentMethod paymentMethod;
        public int tip;
        public bool payed;

        public Bill()
        {
            orders = new List<Order>();
        }

        public void CalculateBill()
        {

        }

        public void CalculateVAT()
        {

        }

        public void CalculateTotalPrice() 
        {

        }

        public void UpdateBill() 
        {

        }
    }
}
