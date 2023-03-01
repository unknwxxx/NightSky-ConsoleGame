using NightSky.App.Interfaces;

namespace NightSky.App.Entities.Spells
{
    public abstract class Spell : IMagic
    {
        private int _requiredMana;
        private bool _requiresVerbalComponent;
        private bool _requiresSomaticComponent;
        protected Spell() { }
        protected Spell(int requiredMana, bool requiresVerbalComponent, bool requiresSomaticComponent)
        {
            _requiredMana = requiredMana;
            _requiresVerbalComponent = requiresVerbalComponent;
            _requiresSomaticComponent = requiresSomaticComponent;
        }
        protected int RequiredMana
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
                    throw new AggregateException("Wrong requiredMana!!!");
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
        public abstract void ExecuteMagicEffect(Mage? target = null, int? power = null);
    }
}
