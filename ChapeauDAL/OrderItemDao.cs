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
            string query = "SELECT OI.id AS OI_id, OI.Order_id, OI.MenuItem_id, OI.amount, OI.comment, OI.[status]," +
                "MI.id AS MI_id, MI.Menu_id, MI.stock, MI.priceExc, MI.itemName, MI.itemType, MI.tax, " +
                "O.id AS O_id, O.Table_id, O.Employee_id, O.Bill_id, O.[dateTime], O.[status], " +
                "M.id AS M_id, M.[name], " +
                "T.id AS T_id, T.[status], " +
                "E.id AS E_id, E.[name], E.[hash], E.salt, E.[role] " +
                "B.id AS B_id, B.comment, B.paymentMethod, B.tip, B.payed " +
                "FROM OrderItem AS OI " +
                "JOIN [MenuItem] AS MI ON OI.menuItem_id = MI.id " +
                "JOIN [Order] AS O ON OI.order_id = O.id " +
                "JOIN [Menu] AS M ON MI.Menu_id = M.id " +
                "JOIN [Table] AS T ON O.Table_id = T.id " +
                "JOIN [Employee] AS E ON O.Employee_id = E.id " +
                "JOIN [Bill] AS B ON O.Bill_id = B.id ";
                return ReadTables(ExecuteSelectQuery(query));
        }
        public OrderItem GetById(int id)
        {
            string query = "SELECT OI.id AS OI_id, OI.Order_id, OI.MenuItem_id, OI.amount, OI.comment, OI.[status]," +
                "MI.id AS MI_id, MI.Menu_id, MI.stock, MI.priceExc, MI.itemName, MI.itemType, MI.tax, " +
                "O.id AS O_id, O.Table_id, O.Employee_id, O.Bill_id, O.[dateTime], O.[status], " +
                "M.id AS M_id, M.[name], " +
                "T.id AS T_id, T.[status], " +
                "E.id AS E_id, E.[name], E.[hash], E.salt, E.[role] " +
                "B.id AS B_id, B.comment, B.paymentMethod, B.tip, B.payed " +
                "FROM OrderItem AS OI " +
                "JOIN [MenuItem] AS MI ON OI.menuItem_id = MI.id " +
                "JOIN [Order] AS O ON OI.order_id = O.id " +
                "JOIN [Menu] AS M ON MI.Menu_id = M.id " +
                "JOIN [Table] AS T ON O.Table_id = T.id " +
                "JOIN [Employee] AS E ON O.Employee_id = E.id " +
                "JOIN [Bill] AS B ON O.Bill_id = B.id " +
                "WHERE OI.id = @id";
            SqlParameter[] sqlParameters = new SqlParameter[]
             {
                new SqlParameter("@id", id ),
             };
            return ReadSingle(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<OrderItem> GetByOrderId(int orderId)
        {
            string query = "SELECT OI.id AS OI_id, OI.Order_id, OI.MenuItem_id, OI.amount, OI.comment, OI.[status]," +
                "MI.id AS MI_id, MI.Menu_id, MI.stock, MI.priceExc, MI.itemName, MI.itemType, MI.tax, " +
                "O.id AS O_id, O.Table_id, O.Employee_id, O.Bill_id, O.[dateTime], O.[status], " +
                "M.id AS M_id, M.[name], " +
                "T.id AS T_id, T.[status], " +
                "E.id AS E_id, E.[name], E.[hash], E.salt, E.[role] " +
                "B.id AS B_id, B.comment, B.paymentMethod, B.tip, B.payed " +
                "FROM OrderItem AS OI " +
                "JOIN [MenuItem] AS MI ON OI.menuItem_id = MI.id " +
                "JOIN [Order] AS O ON OI.order_id = O.id " +
                "JOIN [Menu] AS M ON MI.Menu_id = M.id " +
                "JOIN [Table] AS T ON O.Table_id = T.id " +
                "JOIN [Employee] AS E ON O.Employee_id = E.id " +
                "JOIN [Bill] AS B ON O.Bill_id = B.id " +
                "WHERE O.id = @id";
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
        
        
        public List<OrderItem> GetOrderItemsByIdAndRole(int orderId, Role role)
        {
            StringBuilder query = new StringBuilder
            (
                "SELECT OI.id AS OI_id, OI.Order_id, OI.MenuItem_id, OI.amount, OI.comment, OI.[status]," +
                "MI.id AS MI_id, MI.Menu_id, MI.stock, MI.priceExc, MI.itemName, MI.itemType, MI.tax, " +
                "O.id AS O_id, O.Table_id, O.Employee_id, O.Bill_id, O.[dateTime], O.[status], " +
                "M.id AS M_id, M.[name], " +
                "T.id AS T_id, T.[status], " +
                "E.id AS E_id, E.[name], E.[hash], E.salt, E.[role] " +
                "B.id AS B_id, B.comment, B.paymentMethod, B.tip, B.payed " +
                "FROM OrderItem AS OI " +
                "JOIN [MenuItem] AS MI ON OI.menuItem_id = MI.id " +
                "JOIN [Order] AS O ON OI.order_id = O.id " +
                "JOIN [Menu] AS M ON MI.Menu_id = M.id " +
                "JOIN [Table] AS T ON O.Table_id = T.id " +
                "JOIN [Employee] AS E ON O.Employee_id = E.id " +
                "JOIN [Bill] AS B ON O.Bill_id = B.id " +
                "WHERE M.id "
            );
            if (role == Role.Chef)
            {
                query.Append("IN (1,2) ");
            }
            else if (role == Role.Barista) 
            {
                query.Append("= 3 ");
            }
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
                OrderItem orderItem_ = CreateOrderItemFromRow(row);

                orderItems.Add(orderItem_);
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
        private OrderItem CreateOrderItemFromRow(DataRow row)
        {
            Menu menu_ = new Menu()
            {
                menuId = (int)row["M_id"],
                name = (string)row["name"],
            };
            Table table_ = new Table()
            {
                tableId = (int)row["T_id"],
                status = (TableStatus)row["status"]
            };
            Employee employee_ = new Employee()
            {
                employeeId = (int)row["E_id"],
                name = (string)row["name"],
                hash = (string)row["hash"],
                salt = (string)row["salt"],
                role = (Role)row["role"]
            };
            Order order_ = new Order()
            {
                id = (int)row["O_id"],
                table = table_,
                employee = employee_,
                date = (DateTime)row["dateTime"],
                status = (OrderStatus)row["status"]
            };
            MenuItem menuItem_ = new MenuItem()
            {
                menuItemId = (int)row["MI_id"],
                menu = menu_,
                stock = (int)row["stock"],
                price = Convert.ToDouble(row["priceExc"]),
                itemName = (string)row["itemName"],
                tax = Convert.ToDouble(row["tax"]),
                itemType = (ItemType)row["itemType"],
            };
            OrderItem orderItem_ = new OrderItem()
            {
                orderItemId = (int)row["OI_id"],
                order = order_,
                menuItem = menuItem_,
                amount = (int)row["amount"],
                comment = (string)row["comment"],
                status = (OrderStatus)row["status"]
            };
            return orderItem_;
        }
    }
}
