using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sidibe_Inventory
{
    public class Crackers : IShippable
    {
        private decimal _shipcost = 0.57M;
        private string _productname = "Crackers";

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
