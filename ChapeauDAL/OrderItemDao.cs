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
        //public List<OrderItem> GetAll()
        //{
        //    string query = "SELECT OI.id AS OI_id, OI.Order_id, OI.MenuItem_id, OI.amount, OI.comment, OI.[status],MI.id AS MI_id, MI.Menu_id, MI.stock, MI.priceExc, MI.itemName, MI.itemType, MI.tax,O.id AS O_id, O.Table_id, O.Employee_id, O.Bill_id, O.[dateTime], O.[status],M.id AS M_id, M.[name],T.id AS T_id, T.[status],E.id AS E_id, E.[name], E.[hash], E.salt, E.[role] FROM OrderItem AS OI JOIN [MenuItem] AS MI ON OI.menuItem_id = MI.id JOIN [Order] AS O ON OI.order_id = O.id OIN [Menu] AS M ON MI.Menu_id = M.id vJOIN [Table] AS T ON O.Table_id = T.id JOIN [Employee] AS E ON O.Employee_id = E.id ";
        //    return ReadTables(ExecuteSelectQuery(query));
        //}
        public OrderItem GetById(int id)
        {
            string query = $"SELECT id, Order_id, MenuItem_id, amount, comment, status FROM [OrderItem] WHERE id = @id";
            SqlParameter[] sqlParameters = new SqlParameter[]
             {
                new SqlParameter("@id", id ),
             };
            return ReadSingle(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<OrderItem> GetByOrderId(int orderId)
        {
            string query = $"SELECT id, Order_id, MenuItem_id, amount, comment, status FROM [OrderItem] WHERE Order_id = @Order_id";
            SqlParameter[] sqlParameters = new SqlParameter[]
             {
                new SqlParameter("@Order_id", orderId ),
             };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public void AddOrderItems(int orderId, int menuitemId, int amount, string comment, OrderStatus status)
        {
            string query = "INSERT INTO OrderItem VALUES (@Order_id, @MenuItem_id, @amount, @comment, @status) ";
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
                Menu menu = new Menu()
                {
                    menuId = (int)row["id"],
                    name = (string)row["name"],
                };
                MenuItem menuItem = new MenuItem()
                {
                    menuItemId = (int)row["MI_id"],
                    menu = menu,
                    stock = (int)row["stock"],
                    price = Convert.ToDouble(row["priceExc"]),
                    itemName = (string)row["itemName"],
                    tax = Convert.ToDouble(row["tax"]),
                    itemType = (ItemType)row["itemType"],
                };
                Table table = new Table()
                {
                    tableId = (int)row["id"],
                    status = (TableStatus)row["status"]
                };
                Employee employee = new Employee()
                {
                    employeeId = (int)row["id"],
                    name = (string)row["name"],
                    hash = (string)row["hash"],
                    salt = (string)row["salt"],
                    role = (Role)row["role"]
                };
                Order order = new Order()
                {
                    id = (int)row["O_id"],
                    table = table,
                    employee = employee,
                    bill = (Bill)row["Bill"],
                    date = (DateTime)row["dateTime"],
                    status = (OrderStatus)row["status"]
                };
                OrderItem orderItem = new OrderItem()
                {
                    orderItemId = (int)row["OI_id"],
                    order = order,
                    menuItem = menuItem,
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
                order = (Order)row["Order_id"],
                menuItem = (MenuItem)row["MenuItem_id"],
                amount = (int)row["amount"],
                comment = (string)row["comment"],
                status = (OrderStatus)row["status"]
            };
            return orderItem;
        }
    }
}
