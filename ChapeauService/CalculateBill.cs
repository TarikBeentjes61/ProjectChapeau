using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauService
{
    public static class CalculateBill
    {
        public static double CalculateVAT(double vat, double price)
        {
            return price * (vat / 100); //8 * 0.21
        }

        public static double CalculatePriceInclVat(double vat, double amount, double price)
        {
            return (price * amount) + CalculateVAT(vat, price);
        }

        public static double CalculateTotalPriceInclVat(List<OrderItem> items)
        {
            double total = 0;
            
            foreach (OrderItem item in items)
            {
                total += CalculatePriceInclVat(item.menuItem.tax, item.amount, item.menuItem.price);
            }
            return total;
        }
        public static double CalculateTotalVat(List<OrderItem> items)
        {
            double total = 0;
            
            foreach (OrderItem item in items)
            {
                total += CalculateVAT(item.menuItem.tax, item.menuItem.price);
            }
            return total;
        }
    }
}
