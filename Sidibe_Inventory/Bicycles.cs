using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sidibe_Inventory
{
    public class Bicycles : IShippable
    {
        private decimal _shipcost = 9.50M;
        private string _productname = "Bicycle";

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
