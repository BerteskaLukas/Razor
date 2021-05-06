using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

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

        public List<SelectListItem> GetOrderStages()
        {
            return new List<SelectListItem>()
            {
                new SelectListItem() { Text = "Intake" },
                new SelectListItem() { Text = "Inventory Fulfillment" },
                new SelectListItem() { Text = "Billing" },
                new SelectListItem() { Text = "Prep for Shipping" },
                new SelectListItem() { Text = "Shipped" },
                new SelectListItem() { Text = "Delivery Confirmation" },
                new SelectListItem() { Text = "On Hold" }
            };
        }
    }
}
