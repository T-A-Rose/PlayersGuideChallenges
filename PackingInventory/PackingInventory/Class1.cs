using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackingInventory.thing
{
    public class Example
    {
        public void Main()
        {
            var newPackage = new Pack(5, 23, 20);
            var ropeExample1 = new Rope();
            var ropeExample2 = new InventoryItem(1, 1.5);
            newPackage.Add(ropeExample1);
            newPackage.Add(ropeExample2);
        }
    }
    public class Pack
    {
        public double CurrentVolume { get; private set; }
        public double CurrentWeight { get; private set; }
        public int CurrentItemCount => _items.Count;
        public int MaxItemCount { get; }
        public double MaxWeight { get; }
        public double MaxVolume { get; }
        private readonly List<InventoryItem> _items = new();
        public Pack(int maxItemCount, double maxWeight, double maxVolume)
        {
            MaxItemCount = maxItemCount;
            MaxWeight = maxWeight;
            MaxVolume = maxVolume;
        }
        public bool Add(InventoryItem item)
        {
            if (CurrentItemCount == MaxItemCount)
                return false;
            if (CurrentWeight + item.ItemWeight > MaxWeight)
                return false;
            if (CurrentVolume + item.ItemVolume > MaxVolume)
                return false;
            CurrentWeight += item.ItemWeight;
            CurrentVolume += item.ItemVolume;
            _items.Add(item);
            return true;
        }
    }
    public class InventoryItem
    {
        public double ItemWeight { get; }
        public double ItemVolume { get; }
        public InventoryItem(double itemWeight, double itemVolume)
        {
            ItemWeight = itemWeight;
            ItemVolume = itemVolume;
        }
    }
    public class Rope : InventoryItem
    {
        public Rope() : base(1, 1.5)
        {
        }
    }
}
