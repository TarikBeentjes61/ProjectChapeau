using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ChapeauDAL
{
    public class OrderDao : BaseDao
    {
        public List<Order> GetAll()
        {
            string query = "SELECT id, Table_id, Employee_id, Bill_id, dateTime, status FROM [Order]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<Order> GetAllByState(OrderStatus status)
        {
            string query = "SELECT id, Table_id, Employee_id, Bill_id, dateTime, status FROM [Order] WHERE status = @status";
            SqlParameter[] sqlParameters = new SqlParameter[]
             {
                new SqlParameter("@status", (int)status),
             };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public Order GetById(int id)
        {
            string query = $"SELECT id, Table_id, Employee_id, Bill_id, dateTime, status FROM [Order] WHERE id = @id";
            SqlParameter[] sqlParameters = new SqlParameter[]
             {
                new SqlParameter("@id", id ),
             };
            return ReadSingle(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<Order> ReadTables(DataTable dataTable)
        {
            List<Order> orders= new List<Order>();
            foreach (DataRow row in dataTable.Rows)
            {
                Order order = new Order()
                {
                    tableId = (int)row["Table_id"],
                    employeeId = (int)row["Employee_id"],
                    billId = (int)row["Bill_id"],
                    date = (DateTime)row["dateTime"],
                    status = (OrderStatus)row["status"],
                    OrderItems = GetOrderItemsById((int)row["id"])
                };
                orders.Add(order);
            }
            return orders;
        }
        private List<OrderItem> GetOrderItemsById(int orderId)
        {
            string query = $"SELECT id, Order_id, MenuItem_id, amount, comment FROM [OrderItem] WHERE Order_id = @orderId";
            SqlParameter[] sqlParameters = new SqlParameter[]
             {
                new SqlParameter("@orderId", (int)orderId),
             };
            return ReadOrderItemTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<OrderItem> ReadOrderItemTables(DataTable dataTable) 
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
        private Order ReadSingle(DataTable dataTable)
        {
            DataRow row = dataTable.Rows[0];
            Order order = new Order()
            {
                tableId = (int)row["Table_id"],
                employeeId = (int)row["Employee_id"],
                billId = (int)row["Bill_id"],
                date = (DateTime)row["dateTime"],
                status = (OrderStatus)row["status"]
            };
            return order;
        }
    }
}
