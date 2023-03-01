using NightSky.App.Enums;

namespace NightSky.App.Models
{
    public class PlayerModel
    {
        private static int _id;

        private readonly string _name;
        private int _age;

        private State _state;
        private readonly Race _race;
        private readonly Gender _gender;

        private bool _canTalk;
        private bool _canMove;

        private float _health;
        private readonly float _maxHealth;
        private float _experience;

        public PlayerModel() { }

        public PlayerModel(string name, int age, Race race, Gender gender, State state, float maxHealth, float health, bool canTalk, bool canMove)
        {
            _id++;
            _name = name;
            _race = race;
            _gender = gender;
            _age = age;
            _maxHealth = maxHealth;
            _health = health;
            _state = state;
            _canTalk = canTalk;
            _canMove = canMove;
        }

        public int Id => _id;
        public string Name => _name;
        public State State { get => _state; set => _state = value; }
        public bool CanTalk { get => _canTalk; set => _canTalk = value; }
        public bool CanMove { get => _canMove; set => _canMove = value; }
        public Race Race => _race;
        public Gender Gender => _gender;
        public int Age { get => _age; set => _age = value; }
        public float CurrentHealth
        {
            get => _health;
            set
            {
                _health = value;
                if (_health <= 0)
                {
                    _state = State.Dead;
                    _canTalk = false;
                    _canMove = false;
                }
                else if (_health >= _maxHealth)
                {
                    _state = State.Normal;
                }
                else if (_health >= _maxHealth * 0.1)
                {
                    _state = State.Weakened;
                }
                else
                {
                    _state = State.Sick;
                }
            }
        }
        public float MaxHealth => _maxHealth;
        public float Experience { get => _experience; set => _experience = value; }
    }
}
