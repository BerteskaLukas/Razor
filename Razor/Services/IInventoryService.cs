using Razor.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Razor.Services
{
    public interface IInventoryService
    {
        List<InventoryItem> GetInvetoryLevels(int threshold);
    }
}
