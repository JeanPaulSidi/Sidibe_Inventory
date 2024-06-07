using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sidibe_Inventory
{
    public class BaseballGloves : IShippable
    {
        private decimal _shipcost = 3.23M;
        private string _productname = "Baseball Glove";

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
