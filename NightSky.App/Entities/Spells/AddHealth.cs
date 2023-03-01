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

        public AddHealth() : base(0, true, true) { }

        public AddHealth(int manaCost, bool verbalComponent, bool motorComponent, int healthToAdd)
       : base(manaCost, verbalComponent, motorComponent)
        {
            _healthToAdd = healthToAdd;
        }

        public override void ExecuteMagicEffect(Mage? character, int? power)
        {
            int maxHealthToAdd = RequiredMana / 2; // Максимальное количество здоровья, которое можно добавить за один раз

            if (_healthToAdd > maxHealthToAdd)
            {
                _healthToAdd = maxHealthToAdd;
            }
            
            if(character != null)
            {
                character.Config.CurrentHealth += _healthToAdd;

                if (character.Config.CurrentHealth > character.Config.MaxHealth)
                {
                    character.Config.CurrentHealth = character.Config.MaxHealth;
                }
            }

        }
    }
}
