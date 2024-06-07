using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sidibe_Inventory
{
    public class LawnMowers : IShippable
    {
        private decimal _shipcost = 24.00M;
        private string _productname = "Lawn Mower";

        public decimal ShipCost 
        {
            get { return _shipcost; }
        }

        public string ProductName 
        {
            get { return _productname; }
        }

    }
}
