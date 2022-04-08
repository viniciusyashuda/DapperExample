using System;
using DapperExample.Model;
using DapperExample.Service;

namespace DapperExample
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Airport airport = new Airport()
            {
                City = "Araraquara",
                Code = "Ara",
                Continent = "Am. Sul",
                Country = "Brasil"
            };
            new AirportService().Add(airport);

            foreach (var item in new AirportService().GetAll())
            {
                Console.WriteLine(item);
            }
        }
    }
}
