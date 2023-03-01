using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightSky.App.Entities.Spells
{
    public class AddHealth : Spell
    {
        private int _healthToAdd;

        public AddHealth() : base() { }

        public AddHealth(int manaCost, bool verbalComponent, bool motorComponent, int healthToAdd)
       : base(manaCost, verbalComponent, motorComponent)
        {
            _healthToAdd = healthToAdd;
        }

        public override void ExecuteMagicEffect(Mage? character, int? power)
        {
            if(character.MaxMagicalEnergy > RequiredMana)
            {
                int maxHealthToAdd = RequiredMana / 2;

                if (_healthToAdd > maxHealthToAdd)
                {
                    _healthToAdd = maxHealthToAdd;
                }

                character.MaxMagicalEnergy -= RequiredMana;

                if (character != null)
                {
                    character.Config.CurrentHealth += _healthToAdd;

                    if (character.Config.CurrentHealth > character.Config.MaxHealth)
                    {
                        character.Config.CurrentHealth = character.Config.MaxHealth;
                    }
                }
            }
            else
            {
                throw new ArgumentException("Not enough mana!!!");
            }


        }
    }
}
