using ChapeauModel;
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
            string query = "SELECT id, Order_id, MenuItem_id, amount, comment, status FROM [OrderItem]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));

        }
        public OrderItem GetById(int id)
        {
            string query = $"SELECT id, Order_id, MenuItem_id, amount, comment, status FROM [OrderItem] WHERE id = @id";
            SqlParameter[] sqlParameters = new SqlParameter[]
             {
                new SqlParameter("@id", id ),
             };
            return ReadSingle(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<OrderItem> GetOrderItemsById(int orderId)
        {
            string query = $"SELECT id, Order_id, MenuItem_id, amount, comment, status FROM [OrderItem] WHERE Order_id = @orderId";
            SqlParameter[] sqlParameters = new SqlParameter[]
             {
                new SqlParameter("@orderId", orderId),
             };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<OrderItem> GetOrderItemsById(int orderId, Role role, bool showServed)
        {
            StringBuilder query = new StringBuilder("SELECT OI.id, OI.Order_id, OI.MenuItem_id, OI.amount, OI.comment, OI.[status] FROM OrderItem AS OI JOIN MenuItem AS M ON OI.MenuItem_id = M.id WHERE M.Menu_id ");
            if (role == Role.Chef)
            {
                query.Append("IN (1,2) ");
            }
            else if (role == Role.Barista) 
            {
                query.Append("= 3 ");
            }
            if (showServed)
                query.Append($"AND OI.status != {(int)OrderStatus.Served} ");
            query.Append("AND OI.Order_id = @orderId ORDER BY OI.[status] ASC");

            SqlParameter[] sqlParameters = new SqlParameter[]
             {
                new SqlParameter("@orderId", orderId),
             };
            return ReadTables(ExecuteSelectQuery(query.ToString(), sqlParameters));
        }
        public void UpdateStatusById (int id, OrderStatus status)
        {
            string query = $"UPDATE OrderItem SET [status] = @status WHERE id = @id";
            SqlParameter[] sqlParameters = new SqlParameter[]
             {
                new SqlParameter("@id", id ),
                new SqlParameter("@status", (int)status ),
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
                    orderItemId = (int)row["id"],
                    orderId = (int)row["Order_id"],
                    menuItemId = (int)row["MenuItem_id"],
                    amount = (int)row["amount"],
                    comment = (string)row["comment"],
                    status = (OrderStatus)row["status"]
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
                orderItemId = (int)row["id"],
                orderId = (int)row["Order_id"],
                menuItemId = (int)row["MenuItem_id"],
                amount = (int)row["amount"],
                comment = (string)row["comment"],
                status = (OrderStatus)row["status"]
            };
            return orderItem;
        }
    }
}
