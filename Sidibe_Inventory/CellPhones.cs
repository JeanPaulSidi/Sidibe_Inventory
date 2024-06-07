using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sidibe_Inventory
{
    public class CellPhones : IShippable
    {
        private decimal _shipcost = 5.95M;
        private string _productname = "Cell Phone";

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
