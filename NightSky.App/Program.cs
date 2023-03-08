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


var spell = new AddHealth();
spell.SpellCast += SpellCast;
spell.PerformMagicEffect(player, 10);

void SpellCast(object? sender, SpellEventArgs e)
{
    Console.WriteLine(e.TargetCharacter.Config.IsInvulnerable);
    Console.WriteLine(e.TargetCharacter.CurrentMagicalEnergy);
}

