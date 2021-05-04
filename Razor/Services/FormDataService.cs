using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Razor.Services
{
    public class FormDataService : IFormDataService
    {
        public List<SelectListItem> GetClientTypes()
        {
            return new List<SelectListItem>
            {
                new SelectListItem() { Text = "Northeast", Value = "1" },
                new SelectListItem() { Text = "Wesrt", Value = "2"},
                new SelectListItem() { Text = "Downtown", Value = "3"},
                new SelectListItem() { Text = "TownShip", Value = "4"}
            };
        }

        public List<SelectListItem> GetLocations()
        {
            return new List<SelectListItem>
            {
                new SelectListItem() {Text = "Small Bussiness"},
                new SelectListItem() {Text = "Individual"},
                new SelectListItem() {Text = "Corporation"}
            };
        }
    }
}
