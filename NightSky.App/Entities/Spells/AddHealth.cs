using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightSky.App.Entities.Spells
{
    internal class AddHealth : Spell
    {
        public AddHealth() : base(0, true, true) { }

        public override void PerformMagicEffect(Mage? character = null, int? power = null)
        {
            RequiredMana = power != null ? power.Value * 2 : 0;

            var healthToAdd = power != null ? power.Value : character.CurrentMagicalEnergy / 2;
            character.Config.CurrentHealth += healthToAdd;

            base.PerformMagicEffect(character, power);
        }
    }
}
