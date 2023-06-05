using ChapeauDAL;
using ChapeauModel;
using System.Collections.Generic;

namespace ChapeauService
{
    public class MenuService
    {
        private MenuDao menuDao;

        public MenuService()
        {
            menuDao = new MenuDao();
        }
        public List<Menu> GetAll()
        {
            return menuDao.GetAll();
        }
        public Menu GetById(int id)
        {
            return menuDao.GetById(id);
        }
    }
}
