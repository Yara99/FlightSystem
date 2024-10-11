using Dapper;
using FlightSystem.Core.Common;
using FlightSystem.Core.Data;
using FlightSystem.Core.DTO;
using FlightSystem.Core.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSystem.Infra.Repository
{
    public class ReservationRepository :IReservationRepository
    {
        private readonly IDbContext _dbContext;
        public ReservationRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void CreateReservation(Reservation reservation)
        {
            var p = new DynamicParameters();
            p.Add("p_ReservationDate",reservation.Reservationdate,dbType:DbType.DateTime,direction:ParameterDirection.Input);
            p.Add("p_TotalPrice", reservation.Totalprice, dbType: DbType.Decimal, direction: ParameterDirection.Input);
            p.Add("p_NumOfPassengers", reservation.Numofpassengers, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("p_UserID", reservation.Userid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("p_FlightID", reservation.Flightid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            _dbContext.Connection.Execute("Reservation_Package.CreateReservation",p,commandType:CommandType.StoredProcedure);
        }

        public ReservationDTO FetchReservationByUserID(int userId)
        {
            var p = new DynamicParameters();
            p.Add("p_UserID", userId, dbType:DbType.Int32,direction:ParameterDirection.Input);
            var result = _dbContext.Connection.Query<ReservationDTO>("Reservation_Package.FetchReservationsByUserID",
                p,commandType:CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }
        public ReservationDTO FetchReservationById(int Id)
        {
            var p = new DynamicParameters();
            p.Add("p_id", Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.Query<ReservationDTO>("Reservation_Package.FetchReservationsByID",
                p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }
        public List<ReservationDTO> FetchAllReservation()
        {
            var result = _dbContext.Connection.Query<ReservationDTO>("Reservation_Package.FetchAllReservations",
                 commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
        

        public List<SearchReservationDTO> SearchReservation(SearchReservationDTO obj)
        {
            var p = new DynamicParameters();
            p.Add("fName", obj.Firstname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("lName", obj.Lastname, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("flightNum", obj.Flightnumber, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("DateFrom", obj.DateFrom, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("DateTo", obj.DateTo, dbType: DbType.DateTime, direction: ParameterDirection.Input);

            var res = _dbContext.Connection.Query<SearchReservationDTO>("Reservation_Package.SearchReservation", p, commandType: CommandType.StoredProcedure);

            return res.ToList();
        }


    }
}
