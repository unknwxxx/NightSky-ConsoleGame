using NightSky.App.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightSky.App.Entities.Spells
{
    public class AntidoteSpell : Spell
    {
        public AntidoteSpell() : base(30, true, true) { }

        public override void PerformMagicEffect(Mage? character = null, int? power = null)
        {
            character.Config.State = character.Config.State == State.Poisoned ?
               State.Normal : character.Config.State;

            base.PerformMagicEffect(character, power);
        }
    }
}
