using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;

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
        public List<Order> GetAll(Role role, bool showServed)
        {
            string query = "SELECT id, Table_id, Employee_id, Bill_id, dateTime, status FROM [Order] ORDER BY id DESC";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters), role, showServed);
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

        public int AddOrder(int tableId, int employeeId, int billId, DateTime dateTime, OrderStatus status)
        {
            string query = "INSERT INTO [Order] OUTPUT INSERTED.id VALUES (@Table_id, @Employee_id, @Bill_id, @dateTime, @status)";

            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@Table_id", tableId),
                new SqlParameter("@Employee_id", employeeId),
                new SqlParameter("@Bill_id", billId),
                new SqlParameter("@dateTime", dateTime),
                new SqlParameter("@status", (int)status),
            };
        private List<OrderItem> GetOrderItemsById(int orderId)
        {
            OrderItemDao orderItemDao = new OrderItemDao();
            return orderItemDao.GetOrderItemsById(orderId);
        }
        private List<OrderItem> GetOrderItemsById(int orderId, Role role, bool showServed)
        {
            OrderItemDao orderItemDao = new OrderItemDao();
            return orderItemDao.GetOrderItemsById(orderId, role, showServed);
        }

        //public void AddOrder(List<OrderItem> orderItems)
        //{
        //    string query = "INSERT INTO Order (orderItems) VALUES (@orderItems)";


            return ExecuteInsertQuery(query, sqlParameters);
        }
        private List<Order> ReadTables(DataTable dataTable)
        {
            List<Order> orders = new List<Order>();
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
        private List<Order> ReadTables(DataTable dataTable, Role role, bool showServed)
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
                    OrderItems = GetOrderItemsById((int)row["id"], role, showServed)
                };
                orders.Add(order);
            }
            return orders;
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
        private Order AddSingle(DataTable dataTable)
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
