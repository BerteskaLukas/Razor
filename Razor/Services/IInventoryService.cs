using Razor.Components;
using System.Collections.Generic;

namespace Razor.Services
{
    public interface IInventoryService
    {
        List<InventoryItem> GetInvetoryLevels(int threshold);
    }
}
