using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HotelsAdmin.Entities;

namespace HotelsAdmin.Data
{
    public interface IHotelsData
    {

        IEnumerable<Hotel> GetAll();
    }

    public class InMemoryHotelsData : IHotelsData
    {
        private List<Hotel> hotels;

        public InMemoryHotelsData()
        {
            hotels = new List<Hotel>()
            {
                new Hotel() {HotelId = 1, Name = "Manquehue", Location = "Seminario 252"},
                new Hotel() {HotelId = 1, Name = "Ibis", Location = "Diego Portales 1001"},
                new Hotel() {HotelId = 1, Name = "Don Luis", Location = "Quillota 146"}
            };
        }

        public IEnumerable<Hotel> GetAll()
        {
            return from h in hotels
                   orderby h.Name
                   select h;
        }

    }
}
