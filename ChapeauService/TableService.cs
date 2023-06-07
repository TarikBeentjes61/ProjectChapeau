using ChapeauDAL;
using ChapeauModel;
using System.Collections.Generic;

namespace ChapeauService
{
    public class TableService
    {
        public TableDao tableDao;

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
    }
}
