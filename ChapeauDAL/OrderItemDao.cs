﻿using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauDAL
{
    public class OrderItemDao : BaseDao
    {
        public List<OrderItem> GetAll()
        {
            string query = "SELECT id, Order_id, MenuItem_id, amount, comment FROM [OrderItem]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));

        }
        public OrderItem GetById(int id)
        {
            string query = $"SELECT id, Order_id, MenuItem_id, amount, comment FROM [OrderItem] WHERE id = @id";
            SqlParameter[] sqlParameters = new SqlParameter[]
             {
                new SqlParameter("@id", id ),
             };
            return ReadSingle(ExecuteSelectQuery(query, sqlParameters));
        }
        public void AddOrderItems(int orderId, int menuitemId, int amount, string comment, OrderStatus status)
        {
            string query = "INSERT INTO OrderITem VALUES (@Order_id, @MenuItem_id, @amount, @comment, @status) ";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@Order_Id", orderId),
                new SqlParameter("@MenuItem_id", menuitemId),
                new SqlParameter("@amount", amount),
                new SqlParameter("@comment", comment),
                new SqlParameter("@status", (int)status),
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        private List<OrderItem> ReadTables(DataTable dataTable)
        {
            List<OrderItem> orderItems = new List<OrderItem>();
            foreach (DataRow row in dataTable.Rows)
            {
                OrderItem orderItem = new OrderItem()
                {
                    orderId = (int)row["Order_id"],
                    menuItemId = (int)row["MenuItem_id"],
                    amount = (int)row["amount"],
                    comment = (string)row["comment"]
                };
                orderItems.Add(orderItem);
            }
            return orderItems;
        }
        private OrderItem ReadSingle(DataTable dataTable)
        {
            DataRow row = dataTable.Rows[0];
            OrderItem orderItem = new OrderItem()
            {
                orderId = (int)row["Order_id"],
                menuItemId = (int)row["MenuItem_id"],
                amount = (int)row["amount"],
                comment = (string)row["comment"]
            };
            return orderItem;
        }
    }
}
