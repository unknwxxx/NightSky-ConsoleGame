using NightSky.App.Interfaces;

namespace NightSky.App.Entities.Spells
{
    public abstract class Spell : IMagic
    {
        private int _requiredMana;

        private bool _requiresVerbalComponent;

        private bool _requiresSomaticComponent;
        public int RequiredMana
        {
            get => _requiredMana;
            set
            {
                if (value >= 0)
                {
                    _requiredMana = value;
                }
                else
                {
                    throw new AggregateException("Not enough!!!");
                }
            }
        }
        public bool RequiresVerbalComponent
        {
            get => _requiresVerbalComponent;
            set
            {
                _requiresVerbalComponent = value;
            }
               
        }
        public bool RequiresSomaticComponent
        {
            get => _requiresSomaticComponent;
            set => _requiresSomaticComponent = value;
        }

        public event EventHandler<SpellEventArgs> SpellCast;

        public Spell() { }
        public Spell(int requiredMana, bool requiresVerbalComponent, bool requiresSomaticComponent)
        {
            _requiredMana = requiredMana;
            _requiresVerbalComponent = requiresVerbalComponent;
            _requiresSomaticComponent = requiresSomaticComponent;
        }

        public virtual void OnSpellCast(SpellEventArgs e) => SpellCast?.Invoke(this, e);
        public virtual void PerformMagicEffect(Mage? character = null, int? power = null)
        {
            if (character == null)
                throw new ArgumentNullException(nameof(character));

            if (character.CurrentMagicalEnergy < RequiredMana)
                throw new ArgumentException("Not enough mana to cast spell.");

            if (character.Config.CurrentHealth > character.Config.MaxHealth)
                character.Config.CurrentHealth = character.Config.MaxHealth;

            character.CurrentMagicalEnergy -= _requiredMana;
            OnSpellCast(new SpellEventArgs(character, this));
        }
    }
}
