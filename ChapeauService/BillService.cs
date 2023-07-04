using ChapeauDAL;
using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauService
{
    public class BillService
    {
        private BillDao billDao;

        public BillService()
        {
            billDao = new BillDao();
        }
        public Bill CheckBill(Table table)
        {
            return billDao.CheckBill(table);
        }
        public int CreateBill(Table table, Employee employee, string comment, int paymentMethod, double tip, bool payed, DateTime dateTime, double billPrice)
        {
            return billDao.CreateBill(table, employee, comment, paymentMethod, tip, payed, dateTime, billPrice);
        }
        public void UpdateBill(int id, string comment, int paymentMethod, double tip, bool payed, DateTime dateTime, double billPrice)
        {
            billDao.UpdateBill(id, comment, paymentMethod, tip, payed, dateTime, billPrice);
        }
    }
}
