using ChapeauDAL;
using ChapeauModel;
using System.Collections.Generic;

namespace ChapeauService
{
    public class TableService
    {
        private TableDao tableDao;

        public TableService()
        {
            tableDao= new TableDao();
        }
        public List<Table> GetAll()
        {
            return tableDao.GetAll();
        }
        public Table GetById(int id)
        {
            return tableDao.GetById(id);
        }
        public void UpdateById(int id, int status)
        {
            tableDao.UpdateById(id, status);
        }
    }
}
