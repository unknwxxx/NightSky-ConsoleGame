using NightSky.App.Entities;
using NightSky.App.Entities.Spells;
using NightSky.App.Enums;

//name, age, race, gender, state, maxHealth, health, canTalk, canMove - Mage

var player = new Mage("Адольф", 10, Race.Orc, Gender.Male, 
    State.Sick, 100f, 50f, true, true, 40f, 100f);





Console.WriteLine(player);