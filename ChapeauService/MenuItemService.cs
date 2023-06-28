using ChapeauDAL;
using ChapeauModel;
using System.Collections.Generic;

namespace ChapeauService
{
    public class MenuItemService
    {
        private MenuItemDao menuItemDao;
        public MenuItemService() 
        {
            menuItemDao = new MenuItemDao();
        }
        public MenuItem GetById(int id) 
        { 
            return menuItemDao.GetById(id); 
        }
        public List<MenuItem> GetByItemType(ItemType itemType, int menuId)
        {
            return menuItemDao.GetByItemType(itemType, menuId);
        }
    }
}
