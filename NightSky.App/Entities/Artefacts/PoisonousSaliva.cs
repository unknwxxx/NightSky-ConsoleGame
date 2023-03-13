using NightSky.App.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightSky.App.Entities.Artefacts
{
    public class PoisonousSaliva : Artifact
    {
        public PoisonousSaliva(int power) : base(power, true) { }
        public override void PerformMagicEffect(Mage? character = null, int? power = null)
        {
            if (character != null && character.Config.State != State.Poisoned)
            {
                var damage = power.HasValue ? power.Value : 0;
                character.Config.CurrentHealth = Math.Max(0, character.Config.CurrentHealth - damage);
                character.Config.State = State.Poisoned;
            }
        }
    }
}
