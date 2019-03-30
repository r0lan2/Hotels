using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelsAdmin.Data;
using HotelsAdmin.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HotelsAdmin.Web.Pages.Hotels
{
    public class ListModel : PageModel
    {
        private readonly IHotelsData hotelsData;
        public IEnumerable<Hotel> Hotels;

        public ListModel(IHotelsData hotelsDataManager)
        {
            hotelsData = hotelsDataManager;
        }

        public void OnGet()
        {
            Hotels = hotelsData.GetAll();
        }
    }
}