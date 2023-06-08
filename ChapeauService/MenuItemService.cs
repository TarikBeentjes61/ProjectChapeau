using ChapeauDAL;
using ChapeauModel;
using System.Collections.Generic;

namespace ChapeauService
{
    public class MenuItemService
    {
        public MenuItemDao menuItemDao;
        public MenuItemService() 
        {
            menuItemDao = new MenuItemDao();
        }
        public List<MenuItem> GetAll()
        {
            return menuItemDao.GetAll();
        }
        public MenuItem GetById(int id) 
        { 
            return menuItemDao.GetById(id); 
        }
        public List<MenuItem> GetByMenuId(int menuId)
        {
            return menuItemDao.GetAllByMenuId(menuId);
        }
        public void UpdateStock()
        {

        }
    }
}
