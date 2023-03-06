﻿using NightSky.App.Enums;
using NightSky.App.Models;

namespace NightSky.App.Entities
{
    public class Player : IComparable<Player>
    {
        public PlayerModel Config { get; set; }
        public Player()
        {
            Config = new PlayerModel();
        }
        public Player(string name, int age, Race race, Gender gender, State state, float maxHealth, float health, bool canTalk,
            bool canMove)
        {
            Config = new PlayerModel(name, age, race,
                gender, state, maxHealth, health, canTalk, canMove);
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
