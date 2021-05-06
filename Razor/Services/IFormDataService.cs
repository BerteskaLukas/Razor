using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Razor.Services
{
    public interface IFormDataService
    {
        List<SelectListItem> GetLocations();
        List<SelectListItem> GetClientTypes();
        List<SelectListItem> GetOrderStages();
    }
}
