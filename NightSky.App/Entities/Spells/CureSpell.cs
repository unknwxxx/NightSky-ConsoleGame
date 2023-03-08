using NightSky.App.Enums;

namespace NightSky.App.Entities.Spells
{
    public class CureSpell : Spell
    {
        public CureSpell() : base(20, true, true) { }

        public override void PerformMagicEffect(Mage? character = null, int? power = null)
        {
            character.Config.State = character.Config.State == State.Sick ?
                State.Normal : character.Config.State;

            base.PerformMagicEffect(character, power);
        }
    }
}
