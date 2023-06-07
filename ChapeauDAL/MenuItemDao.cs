﻿using ChapeauModel;
using System.Collections.Generic;
using System;
using System.Data;
using System.Data.SqlClient;

namespace ChapeauDAL
{
    public class MenuItemDao : BaseDao
    {
        public List<MenuItem> GetAll()
        {
            string query = "SELECT id, Menu_id, stock, priceExc, itemName, tax FROM MenuItem";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public MenuItem GetById(int id)
        {
            string query = $"SELECT id, Menu_id, stock, priceExc, itemName, tax FROM MenuItem WHERE id = @id";
            SqlParameter[] sqlParameters = new SqlParameter[]
             {
                new SqlParameter("@id", id ),
             };
            return ReadSingle(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<MenuItem> GetAllByMenuId(int menuId)
        {
            string query = $"SELECT id, Menu_id, stock, priceExc, itemName, tax FROM MenuItem WHERE Menu_id = @menuId";
            SqlParameter[] sqlParameters = new SqlParameter[]
             {
                new SqlParameter("@menuId", menuId ),
             };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public void UpdateStock()
        {

        }
        private List<MenuItem> ReadTables(DataTable dataTable)
        {
            List<MenuItem> menuItems = new List<MenuItem>();
            foreach (DataRow row in dataTable.Rows)
            {
                MenuItem menuItem = new MenuItem()
                {
                    menuItemId = (int)row["id"],
                    menuId = (int)row["Menu_id"],
                    stock = (int)row["stock"],
                    price = (float)row["priceExc"],
                    itemName = (string)row["itemName"],
                };
            }
            return menuItems;
        }
        private MenuItem ReadSingle(DataTable dataTable)
        {
            DataRow row = dataTable.Rows[0];
            MenuItem menuItem = new MenuItem()
            {
                menuItemId = (int)row["id"],
                menuId = (int)row["Menu_id"],
                stock = (int)row["stock"],
                price = (float)row["priceExc"],
                itemName = (string)row["itemName"],
            };
            return menuItem;
        }
    }
}