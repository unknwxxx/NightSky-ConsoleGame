namespace NightSky.App.Entities.Spells
{
    public class SpellEventArgs : EventArgs
    {
        public Mage TargetCharacter { get; }
        public Spell CastSpell { get; }

        public SpellEventArgs(Mage targetCharacter, Spell castSpell)
        {
            TargetCharacter = targetCharacter;
            CastSpell = castSpell;
        }
    }
}
