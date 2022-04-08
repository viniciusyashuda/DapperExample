using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DapperExample.Model;
using DapperExample.Repository;

namespace DapperExample.Service
{
    public class AirportService
    {

        private IAirportRepository _airport;

        public AirportService()
        {
            _airport = new AirportRepository();
        }

        public bool Add(Airport airport)
        {
            return _airport.Add(airport);
        }

        public List<Airport> GetAll()
        {
            return _airport.GetAll();
        }


    }
}
