using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace NightSky.App.Entities.Artefacts
{
    public class LightningStaff : Artifact
    {
        public LightningStaff(int power) : base(power, true) { }

        public override void PerformMagicEffect(Mage ?character = null, int? power = null)
        {
            if (power.HasValue && power.Value > 0 && Power >= power.Value)
            {
                if (character != null && character.Config.CurrentHealth > 0)
                {
                    character.Config.CurrentHealth = Math.Max(0, character.Config.CurrentHealth - power.Value);
                    Power -= power.Value;
                }
            }
        }
    }
}
