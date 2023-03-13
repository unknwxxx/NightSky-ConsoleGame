using NightSky.App.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightSky.App.Entities.Artefacts
{
    public class BasiliskEye : Artifact
    {
        public BasiliskEye(int power) : base(power, false) { }

        public override void PerformMagicEffect(Mage? character = null, int? power = null)
        {
            if (character != null && character.Config.State != State.Dead)
            {
                character.Config.State = State.Paralyzed;
            }
            else
            {
                throw new ArgumentException("No character specified for the Basilisk Eye effect or character is already dead and cannot be paralyzed!!!");
            }
        }
    }
}
