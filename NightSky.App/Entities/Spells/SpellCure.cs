using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightSky.App.Entities.Spells
{
    public class SpellCure : Spell
    {
        public SpellCure() : base() { }
        public override void ExecuteMagicEffect(Mage? target = null, int? power = null)
        {
            RequiredMana = 20;
            RequiresSomaticComponent = true;
            RequiresVerbalComponent = true;

            if (target != null)
            {
                if (target.Config.State == Enums.State.Sick && target.CurrentMagicalEnergy > RequiredMana)
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
