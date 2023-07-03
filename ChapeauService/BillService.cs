﻿using ChapeauDAL;
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
        public List<Bill> GetAll()
        {
            return billDao.GetAll();
        }
        public Bill GetById(int id)
        {
            return billDao.GetById(id);
        }
        public Bill GetBillByTableId(int tableId)
        {
            return billDao.GetBillByTableId(tableId);
        }
        public int CheckAndCreateBill(Employee employee, Table table, string comment, int paymentMethod, double tip, int payed)
        {
            return billDao.CheckAndCreateBill(employee, table,comment, paymentMethod, tip, payed);
        }
        public void UpdateBill(int id, string comment, int paymentMethod, double tip, int payed)
        {
            billDao.UpdateBill(id, comment, paymentMethod, tip, payed);
        }
    }
}
