using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace NightSky.App.Entities.Spells
{
    public class ArmorSpell : Spell
    {
        private int _duration;
        private bool _isInvulnerable;
        public int Duration
        {
            get => _duration;
            set
            {
                if (value >= 0)
                {
                    _duration = value;
                }
                else
                {
                    throw new AggregateException("Invalid duration");
                }
            }
        }
        public bool IsInvulnerable { get => _isInvulnerable; set => _isInvulnerable = value; }

        public ArmorSpell(int duration) : base(50, true, true)
        {
            _duration = duration;

            var timer = new System.Timers.Timer(_duration * 1000);
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        private void Timer_Elapsed(object? sender, ElapsedEventArgs e)
        {
            IsInvulnerable = false;
        }

        public override void PerformMagicEffect(Mage ? character = null, int ? power = null)
        {
            IsInvulnerable = true;
            character.Config.IsInvulnerable = _isInvulnerable;
            OnSpellCast(new SpellEventArgs(character, this));
        }

     

    }
}
