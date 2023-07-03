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
        private const string BaseQuery = 
            "SELECT OI.id AS OI_id, OI.Order_id, OI.MenuItem_id, OI.amount, OI.comment, OI.[status], " +
            "MI.id AS MI_id, MI.Menu_id, MI.stock, MI.priceExc, MI.itemName, MI.itemType, MI.tax, " +
            "O.id AS O_id, O.Table_id, O.Employee_id, O.Bill_id, O.[dateTime], O.[status], " +
            "M.id AS M_id, M.[name], " +
            "T.id AS T_id, T.[status], " +
            "E.id AS E_id, E.username, E.[name], E.[hash], E.salt, E.[role], " +
            "B.id AS B_id, B.comment, B.paymentMethod, B.tip, B.payed " +
            "FROM OrderItem AS OI " +
            "JOIN [MenuItem] AS MI ON OI.menuItem_id = MI.id " +
            "JOIN [Order] AS O ON OI.order_id = O.id " +
            "JOIN [Menu] AS M ON MI.Menu_id = M.id " +
            "JOIN [Table] AS T ON O.Table_id = T.id " +
            "JOIN [Employee] AS E ON O.Employee_id = E.id " +
            "JOIN [Bill] AS B ON O.Bill_id = B.id ";
        public List<OrderItem> GetAll()
        {
             return ReadTables(ExecuteSelectQuery(BaseQuery));
        }
        public OrderItem GetById(int id)
        {
            string query = BaseQuery + "WHERE OI.id = @id";
            SqlParameter[] sqlParameters = new SqlParameter[]
             {
                new SqlParameter("@id", id ),
             };
            return ReadSingle(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<OrderItem> GetByTableId(int tableId, int billId)
        {
            string query = BaseQuery + "WHERE T.Id = @Table_Id AND B.Id = @Bill_id";
            SqlParameter[] sqlParameters = new SqlParameter[]
             {
                new SqlParameter("@Table_Id", tableId),
                new SqlParameter("@Bill_id",billId),
             };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<OrderItem> GetByOrderId(int orderId)
        {
            string query = BaseQuery + "WHERE O.id = @id";
            SqlParameter[] sqlParameters = new SqlParameter[]
             {
                new SqlParameter("@id", orderId ),
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
            StringBuilder query = new StringBuilder(BaseQuery + "WHERE M.id ");
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
                orderItems.Add(CreateOrderItemFromRow(row));
            }
            return orderItems;
        }
        private OrderItem ReadSingle(DataTable dataTable)
        {
            DataRow row = dataTable.Rows[0];
            return CreateOrderItemFromRow(row);
        }
        private OrderItem CreateOrderItemFromRow(DataRow row)
        {
            Menu menu = new Menu()
            {
                menuId = (int)row["M_id"],
                name = (string)row["name"],
            };
            Table table = new Table()
            {
                tableId = (int)row["T_id"],
                status = (TableStatus)row["status"]
            };
            Employee employee = new Employee()
            {
                employeeId = (int)row["E_id"],
                username = (string)row["username"],
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
                date = (DateTime)row["dateTime"],
                status = (OrderStatus)row["status"]
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
            OrderItem orderItem = new OrderItem()
            {
                orderItemId = (int)row["OI_id"],
                order = order,
                menuItem = menuItem,
                amount = (int)row["amount"],
                comment = (string)row["comment"],
                status = (OrderStatus)row["status"]
            };
            return orderItem;
        }

        public List<OrderItem> GetAllByBillId(int billId)
        {
            string query = BaseQuery + "WHERE O.Bill_id = @Bill_id";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                    new SqlParameter("@Bill_id", billId ),
            };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
    }
}
