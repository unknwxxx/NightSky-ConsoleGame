using NightSky.App.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightSky.App.Entities.Spells
{
    public class CastOffSpell : Spell
    {
        public CastOffSpell()  : base(85, true, true) { }

        public override void PerformMagicEffect(Mage? character = null, int? power = null)
        {
            character.Config.State = character.Config.State == State.Paralyzed ?
                State.Normal : character.Config.State;

            character.Config.CurrentHealth = 1;
            base.PerformMagicEffect(character, power);
        }
    }
}
