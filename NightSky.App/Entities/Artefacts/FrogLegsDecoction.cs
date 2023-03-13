using NightSky.App.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightSky.App.Entities.Artefacts
{
    public class FrogLegsDecoction : Artifact
    {
        public FrogLegsDecoction() : base(0, false) { }

        public override void PerformMagicEffect(Mage? character = null, int? power = null)
        {
            if(character != null)
            {
                character.Config.State = character.Config.State == State.Poisoned ?
                        State.Normal : character.Config.State;
            }
          
        }
    }
}
