using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauService
{
    public class CalculateBill
    {
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
    }
}
