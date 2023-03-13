using NightSky.App.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightSky.App.Entities.Artefacts
{
    public abstract class Artifact : IMagic
    {
        private int _power;
        private bool _renewable;

        public Artifact(int power, bool renewable)
        {
            _power = power;
            _renewable = renewable;
        }

        public int Power
        {
            get { return _power; }
            set { if (value >= 0) { _power = value; } }
        }

        public bool Renewable
        {
            get { return _renewable; }
            set { _renewable = value; }
        }

        public abstract void PerformMagicEffect(Mage? character = null, int? power = null);
    }
}
