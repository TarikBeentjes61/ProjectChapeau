using ChapeauDAL;
using ChapeauModel;
using System.Collections.Generic;

namespace ChapeauService
{
    public class ReservationService
    {
        private ReservationDao reservationDao;

        public ReservationService()
        {
            reservationDao = new ReservationDao();
        }
        public List<Reservation> GetAll()
        {
            return reservationDao.GetAll();
        }
        public Reservation GetById(int id)
        {
            return reservationDao.GetById(id);
        }
        public void AddReservation()
        {

        }
        public void RemoveReservation()
        {

        }
    }
}
