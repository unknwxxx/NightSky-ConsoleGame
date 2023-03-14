using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightSky.App.Entities.Inventory
{
    public class InventoryComponent : IEnumerable<Item>
    {
        private List<Item> _items;
        public InventoryComponent()
        {
            _items = new List<Item>();
        }
        public InventoryComponent(List<Item> items)
        {
            _items = items;
        }

        public void Add(Item item)
        {
            if (item != null)
                _items.Add(item);
            else
                throw new ArgumentNullException();
        }

        public void Remove(int index)
        {
            if (index >= 0 && index < _items.Count)
                _items.RemoveAt(index);
            else
                throw new ArgumentException();
        }

        public Item FindItem(Predicate<Item> predicate)
        {
            if (predicate != null)
                return _items.Find(predicate);
            else
                throw new ArgumentNullException();
        }

        public void Transmit(int index, Player player)
        {
            player.Inventory.Add();
        }

        public IEnumerator<Item> GetEnumerator()
        {
            return _items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
