using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackingInventory
{
    internal class Pack
    {
        private int itemCount  { get; set; }
        private double weight { get; set; }
        private double volume { get; set; }
        
        private int maxNumberOfItems { get; }
        private double maxItemWeight { get; }
        private double maxItemVolume { get; }
        

        InventoryItem[] packTotal;

        public Pack(int _maxNumberOfItems, double _maxItemWeight, double _maxItemVolume)
        {
            maxNumberOfItems = _maxNumberOfItems;
            maxItemWeight = _maxItemWeight;
            maxItemVolume = _maxItemVolume;
        }

        public bool Add(InventoryItem item)
        {
            if (itemCount > maxNumberOfItems)
            {
                return false;
            } else
            {
                itemCount += 1;
                weight += item.ItemWeight;
                volume += item.ItemVolume;
                return true;
            };
        }

    }
}
