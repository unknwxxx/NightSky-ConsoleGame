using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightSky.App.Entities
{
    public abstract class Item
    {
        public int ID { get; private set; }
        public Item()
        {
            ID++;
        }
    }
}
