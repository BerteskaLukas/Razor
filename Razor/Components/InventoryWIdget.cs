using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Razor.Services;

namespace Razor.Components
{
    public class InventoryWIdget : ViewComponent
    {

        public IInventoryService _inventoryService { get; set; }

        public InventoryWIdget(IInventoryService inventoryService)
        {
            _inventoryService = inventoryService;
        }


        public async Task<IViewComponentResult> InvokeAsync(int threshold = 10)
        {
            return View(_inventoryService.GetInvetoryLevels(threshold));
        }
    }

    public class InventoryItem
    {
        public int Count { get; set; }
        public string Name { get; set; }
    }
}