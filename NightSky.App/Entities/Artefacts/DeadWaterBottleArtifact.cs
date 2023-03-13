using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightSky.App.Entities.Artefacts
{
    public class DeadWaterBottleArtifact : Artifact
    {
        private int _manaIncrease;

        public DeadWaterBottleArtifact(int power, bool renewable, int manaIncrease) : base(power, renewable)
        {
            _manaIncrease = manaIncrease;
        }
        public override void PerformMagicEffect(Mage ?character = null, int ? power = null)
        {
            if (character != null && character is Mage magicUser)
            {
                var currentMana = magicUser.CurrentMagicalEnergy;
                var maxMana = magicUser.MaxMagicalEnergy;
                var newMana = currentMana + _manaIncrease;

                if (newMana > maxMana)
                {
                    magicUser.CurrentMagicalEnergy = maxMana;
                }
                else
                {
                    magicUser.CurrentMagicalEnergy = newMana;
                }
            }
        }
    }
}
