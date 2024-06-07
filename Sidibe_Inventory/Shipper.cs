using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sidibe_Inventory
{
    public class Shipper
    {
        private List<IShippable> _itemsordered = new List<IShippable>();
        private List<int> _quantityordered = new List<int>();
        private int _totalitemsordered;

        public Shipper() 
        {
            _itemsordered.Clear();
            _quantityordered.Clear();
            _totalitemsordered = 0;
        }

        private void UpdateShippingCart(IShippable Item) 
        {
            bool AlreadyOrdered = false;

            for (int i = 0;  i < _itemsordered.Count; i++) 
            {
                if (_itemsordered[i].ProductName.ToLower() == Item.ProductName.ToLower()) 
                {
                    AlreadyOrdered = true;
                    _quantityordered[i]++;
                    break;
                }

            }
            if (!AlreadyOrdered) 
            {
                _itemsordered.Add(Item);
                _quantityordered.Add(1);
            }

        }

        public string Add(IShippable Item) 
        {
            string Message = string.Empty;

            if (_totalitemsordered == 10) 
            {
                Message = "Sorry, the limit of 10 items has been reached";
            }
            else 
            {
                UpdateShippingCart(Item);

                _totalitemsordered++;
                Message = ("1 " + Item.ProductName + " has been added.");
            }

            return Message;
        }

        private string GenerateShippingManifest() 
        {
            string ShippingManifest = string.Empty;

            ShippingManifest = ("***** Shipment Manifest *****" + "\n");

            for (int i = 0;i < _itemsordered.Count; i++) 
            {
                ShippingManifest += _quantityordered[i] + " ";

                if (_itemsordered[i].ProductName.ToLower() == "crackers") 
                {
                    ShippingManifest += _itemsordered[i].ProductName;
                }
                else 
                {
                    ShippingManifest += (_quantityordered[i] == 1 ? _itemsordered[i].ProductName : _itemsordered[i].ProductName + "s");
                }

                ShippingManifest += "\n";
            }

            ShippingManifest += ("\n" + "Total items ordered: " + _totalitemsordered);

            return ShippingManifest;

        }

        public string ListShipmentItems() 
        {
            string Message = string.Empty;

            if (_totalitemsordered > 0) 
            {
                Message = GenerateShippingManifest();
            }

            return Message;
        }

        public decimal ComputeShippingCharges() 
        {
            decimal TotalShippingCost = 0;

            if (_totalitemsordered > 0) 
            {
                for (int i = 0 ; i < _itemsordered.Count ; i++) 
                {
                    TotalShippingCost += (decimal)(_itemsordered[i].ShipCost * _quantityordered[i]);
                }
            }

            return TotalShippingCost;
        }
    }
}
