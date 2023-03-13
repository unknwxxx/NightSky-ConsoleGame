using NightSky.App.Entities;
using NightSky.App.Entities.Artefacts;
using NightSky.App.Entities.DialogTree;
using NightSky.App.Entities.Spells;
using NightSky.App.Enums;
using System.Text.Json;
using System.Timers;
using static System.Net.Mime.MediaTypeNames;

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
    maxMagicalEnergy: 1000f,
    isInvulnerable: false);



//var spell = new AddHealth();
//spell.SpellCast += Spell_SpellCast;
//spell.PerformMagicEffect(player, 10);


//var artifact = new WaterBottle(0, false, 10);
//artifact.PerformMagicEffect(player);
//Console.WriteLine(player.Config.CurrentHealth);


var smallDeadWaterBottle = new BasiliskEye(10);
smallDeadWaterBottle.PerformMagicEffect(player);
Console.WriteLine(player);




//void Spell_SpellCast(object? sender, SpellEventArgs e)
//{
//    Console.WriteLine(e.TargetCharacter.Config.CurrentHealth);
//}


//DialogTree dialogTree = new DialogTree();

//using (FileStream fs = new FileStream("D:\\NightSky-ConsoleGame\\NightSky.App\\Files\\test.json",
//         FileMode.Create))
//{
//    JsonSerializer.Serialize(fs, dialogTree.Branches,
//        new JsonSerializerOptions { WriteIndented = true });
//}



