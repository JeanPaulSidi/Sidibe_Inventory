using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sidibe_Inventory
{
    public interface IShippable
    {
        decimal ShipCost {  get; }
        string ProductName {  get; }
    }
}
