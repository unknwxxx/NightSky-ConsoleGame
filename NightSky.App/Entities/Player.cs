using NightSky.App.Enums;
using NightSky.App.Models;
using NightSky.App.Entities.Inventory;

namespace NightSky.App.Entities
{
    public class Player : IComparable<Player>
    {
        public PlayerModel Config { get; private set; }

        public InventoryComponent Inventory { get; private set; }

        public Player()
        {
            Config = new PlayerModel();
            Inventory = new InventoryComponent();
        }
        public Player(PlayerModel config, InventoryComponent inventory)
        {
            Config = config;
            Inventory = inventory;
        }
        public Player(string name, int age, Race race, Gender gender, State state, float maxHealth, float health, bool canTalk,
            bool canMove, bool isInvulnerable)
        {
            Config = new PlayerModel(name, age, race,
                gender, state, maxHealth, health, canTalk, canMove, isInvulnerable);
            Inventory = new InventoryComponent();
        }
        public override string ToString()
        {
            return
                $"ID: {Config.Id}\nName: {Config.Name}\nState: {Config.State}\nCan Talk: {Config.CanTalk}\nCan Move: {Config.CanMove}\n" +
                $"Race: {Config.Race}\nGender: {Config.Gender}\nAge: {Config.Age}\nHealth: {Config.CurrentHealth}\nExperience: {Config.Experience}";
        }
        public int CompareTo(Player other) => 
            Config.Experience.CompareTo(other.Config.Experience);
    }
}
