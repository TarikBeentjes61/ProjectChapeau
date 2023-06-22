using System;
using System.Collections.Generic;

namespace ChapeauModel
{
    public class Menu
    {
        public int menuId;
        private List<MenuItem> menuItems;
        public string name;

        public List<MenuItem> MenuItems{ get { return menuItems; } set { menuItems = value; } }

        public void SetMenu(List<MenuItem> menuItems)
        {
            this.menuItems = menuItems; 
        } 
    }
}
