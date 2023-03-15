using NightSky.App.Entities.Spells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightSky.App.Entities
{

    public class GameManager
    {
        public GameManager() 
        { 
        }
     
    }

    public class LevelEventArgs : EventArgs
    {
        public LevelManager Level { get; set; }
        public LevelEventArgs(LevelManager level)
        {
            Level = level;
        }
    }

    public class LevelManager
    {
        public event EventHandler<LevelEventArgs> LoadLevel;
        public string Name { get; set; }

        public virtual void Load(LevelEventArgs e) => OnLoadLevel(e);
        protected virtual void OnLoadLevel(LevelEventArgs e) => LoadLevel?.Invoke(this, e);

    }

    public class Kordon : LevelManager
    {
    }



}
