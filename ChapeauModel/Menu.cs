using System.Collections.Generic;

namespace ChapeauModel
{
    public class Menu
    {
        public int menuId;
        private List<MenuItem> menuItems;

        public void SetMenu (List<MenuItem> menuItems)
        {
            this.menuItems = menuItems; 
        } 
    }
}
