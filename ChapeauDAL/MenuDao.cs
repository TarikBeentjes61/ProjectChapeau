using ChapeauModel;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ChapeauDAL
{
    public class MenuDao : BaseDao
    {
        public List<Menu> GetAll()
        {
            string query = "SELECT id, name FROM Menu";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));

        }
        public Menu GetById(int id)
        {
            string query = $"SELECT id FROM Menu WHERE id = @id";
            SqlParameter[] sqlParameters = new SqlParameter[]
             {
                new SqlParameter("@id", id ),
             };
            return ReadSingle(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<Menu> ReadTables(DataTable dataTable)
        {
            List<Menu> menus = new List<Menu>();
            foreach (DataRow row in dataTable.Rows)
            {
                Menu menu = new Menu()
                {
                    menuId = (int)row["id"],
                    name = (string)row["name"],
                };
                menu.SetMenu(GetMenuItems(menu.menuId));
                menus.Add(menu);
            }
            return menus;
        }
        private Menu ReadSingle(DataTable dataTable)
        {
            DataRow row = dataTable.Rows[0];
            Menu menu = new Menu()
            {
                menuId = (int)row["id"],
                name = (string)row["name"],
            };
            menu.SetMenu(GetMenuItems(menu.menuId));
            return menu;
        }
        private List<MenuItem> GetMenuItems(int menuId)
        {
            MenuItemDao menuItemDao = new MenuItemDao();
            return menuItemDao.GetAllByMenuId(menuId);
        }
    }
}
