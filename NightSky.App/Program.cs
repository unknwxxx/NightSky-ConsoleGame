using NightSky.App.Entities.DialogTree;
using System.Text.Json;

//name, age, race, gender, state, maxHealth, health, canTalk, canMove - Mage

//var player = new Mage("Адольф", 10, Race.Orc, Gender.Male, 
//State.Sick, 100f, 50f, true, true, 40f, 100f);

DialogTree dialogTree = new DialogTree();



using (FileStream fs = new FileStream("D:\\NightSky-ConsoleGame\\NightSky.App\\Files\\test.json",
         FileMode.Create))
{
    JsonSerializer.Serialize(fs, dialogTree.Branches,
        new JsonSerializerOptions { WriteIndented = true });
}
