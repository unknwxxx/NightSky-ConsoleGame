using NightSky.App.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightSky.App.Entities.Spells
{
    public class AntidoteSpell : Spell
    {
        public AntidoteSpell() { }
        public override void ExecuteMagicEffect(Mage? target = null, int? power = null)
        {
            RequiredMana = 30;
            RequiresSomaticComponent = true;
            RequiresVerbalComponent = true;

            if (target != null)
            {
                if (target.Config.State == Enums.State.Poisoned && target.CurrentMagicalEnergy > RequiredMana)
                {
                    target.Config.State = Enums.State.Weakened;
                    target.CurrentMagicalEnergy -= RequiredMana;
                }
                else
                {
                    throw new ArgumentException("Character doesn't need healing or too little mana!!!");
                }
            }
        }
    }
}
