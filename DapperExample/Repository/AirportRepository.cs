using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DapperExample.Model;
using Dapper;
using DapperExample.Configuration;

namespace DapperExample.Repository
{
    public class AirportRepository : IAirportRepository
    {
        private string _connection;
        public AirportRepository()
        {
            _connection = DatabaseSettings.Get();
        }


        public bool Add(Airport airport)
        {
            bool status = false;

            using (var db = new SqlConnection(_connection))
            {
                db.Open();
                db.Execute(Airport.INSERT, airport);
                status = true;
                db.Close();
            }

            return status;
        }

        public List<Airport> GetAll()
        {
            using (var db = new SqlConnection(_connection))
            {
                db.Open();
                var airports = db.Query<Airport>(Airport.GETALL);

                return (List<Airport>)airports;
            }
        }
    }
}
