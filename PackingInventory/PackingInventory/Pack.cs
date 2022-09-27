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
        
        private int maxNumberOfItems { get; set; }
        private double maxItemWeight { get; }
        private double maxItemVolume { get; }
        private readonly List<InventoryItem> _items = new();


        InventoryItem[] packTotal;

        public Pack(int _maxNumberOfItems, double _maxItemWeight, double _maxItemVolume)
        {
            maxNumberOfItems = _maxNumberOfItems;
            maxItemWeight = _maxItemWeight;
            maxItemVolume = _maxItemVolume;
        }

        public bool Add(InventoryItem item)
        {
            if (itemCount > maxNumberOfItems) return false;
            if (weight > maxItemWeight) return false;
            if (volume > maxItemVolume) return false;
            
            weight += item.ItemWeight;
            volume += item.ItemVolume;
            _items.Add(item);
            return true;
        }

        public void DisplayItems()
        {
            foreach (InventoryItem item in _items)
            {
                Console.WriteLine(item);
            }
        }

    }
}
