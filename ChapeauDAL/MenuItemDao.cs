using ChapeauModel;
using System.Collections.Generic;
using System;
using System.Data;
using System.Data.SqlClient;

namespace ChapeauDAL
{
    public class MenuItemDao : BaseDao
    {
        public MenuItem GetById(int id)
        {
            string query = 
                "SELECT MI.id AS MI_id, MI.stock, MI.priceExc, MI.itemName, MI.itemType, MI.tax, " +
                "M.id AS M_id, M.[name] " +
                "FROM MenuItem AS MI " +
                "JOIN Menu AS M ON MI.Menu_id = M.id " +
                "WHERE MI.id = @id";
            SqlParameter[] sqlParameters = new SqlParameter[]
             {
                new SqlParameter("@id", id ),
             };
            return ReadSingle(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<MenuItem> GetAllByMenuId(int menuId)
        {
            string query = $"SELECT id, Menu_id, stock, priceExc, itemName, tax, itemType FROM MenuItem WHERE Menu_id = @menuId";
            SqlParameter[] sqlParameters = new SqlParameter[]
             {
                new SqlParameter("@menuId", menuId ),
             };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<MenuItem> GetByItemType(ItemType itemType, int menuId)
        {
            string query = 
                "SELECT MI.id AS MI_id, MI.stock, MI.priceExc, MI.itemName, MI.itemType, MI.tax, " +
                "M.id AS M_id, M.[name] " +
                "FROM MenuItem AS MI " +
                "JOIN Menu AS M ON MI.Menu_id = M.id " +
                "WHERE MI.itemType = @itemType AND M.id = @menuId";
            SqlParameter[] sqlParameters = new SqlParameter[]
             {
                new SqlParameter("@itemType", Convert.ToInt32(itemType)),
                new SqlParameter("@menuId", Convert.ToInt32(menuId)),
             };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<MenuItem> ReadTables(DataTable dataTable)
        {
            List<MenuItem> menuItems = new List<MenuItem>();
            foreach (DataRow row in dataTable.Rows)
            {
                MenuItem menuItem = CreateMenuItemFromRow(row);
                menuItems.Add(menuItem);
            }
            return menuItems;
        }
        private MenuItem ReadSingle(DataTable dataTable)
        {
            DataRow row = dataTable.Rows[0];
            if (dataTable.Rows.Count > 0)
            {
                return CreateMenuItemFromRow(row);
            };
            return null;
        }
        private MenuItem CreateMenuItemFromRow(DataRow row)
        {
            Menu menu_ = new Menu()
            {
                menuId = (int)row["M_id"],
                name = (string)row["name"]
            };
            return new MenuItem()
            {
                menuItemId = (int)row["MI_id"],
                menu = menu_,
                stock = (int)row["stock"],
                price = Convert.ToDouble(row["priceExc"]),
                itemName = (string)row["itemName"],
                tax = Convert.ToDouble(row["tax"]),
                itemType = (ItemType)row["itemType"],
            };
        }
    }
}
