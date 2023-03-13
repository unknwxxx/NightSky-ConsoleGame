using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightSky.App.Entities.Artefacts
{
    public class WaterBottle : Artifact
    {
        private int _healthIncrease;

        public WaterBottle(int power, int healthIncrease) : base(power, false)
        {
            _healthIncrease = healthIncrease;
        }

        public override void PerformMagicEffect(Mage? character = null, int? power = null)
        {
            if (character != null)
            {
                var currentHealth = character.Config.CurrentHealth;
                var maxHealth = character.Config.MaxHealth;
                var newHealth = currentHealth + _healthIncrease;

                if (newHealth > maxHealth)
                {
                    character.Config.CurrentHealth = maxHealth;
                }
                else
                {
                    character.Config.CurrentHealth = newHealth;
                }
            }
        }
    }
}
