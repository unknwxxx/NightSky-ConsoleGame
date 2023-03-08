using NightSky.App.Entities;
using NightSky.App.Entities.Spells;
using NightSky.App.Enums;
using System.Timers;

var player = new Mage(
    name: "Адольф",
    age: 10,
    race: Race.Orc,
    gender: Gender.Male,
    state: State.Sick,
    maxHealth: 100f,
    health: 50f,
    canTalk: true,
    canMove: true,
    currentMagicalEnergy: 150f,
    maxMagicalEnergy: 100f,
    isInvulnerable: false);



using (FileStream fs = new FileStream("D:\\NightSky-ConsoleGame\\NightSky.App\\Files\\test.json",
         FileMode.Create))
{
    Console.WriteLine(e.TargetCharacter.Config.IsInvulnerable);
    Console.WriteLine(e.TargetCharacter.CurrentMagicalEnergy);
}

