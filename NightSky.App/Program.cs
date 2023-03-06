using NightSky.App.Entities;
using NightSky.App.Entities.DialogTree;
using NightSky.App.Entities.Spells;
using NightSky.App.Enums;
using System.Diagnostics;
using System.Text.Json;

//name, age, race, gender, state, maxHealth, health, canTalk, canMove - Mage

//var player = new Mage("Адольф", 10, Race.Orc, Gender.Male, 
//State.Sick, 100f, 50f, true, true, 40f, 100f);

internal class Program
{
    private static async Task Main(string[] args)
    {
        DialogTree dialogTree = new DialogTree();

        dialogTree.Root = new Branch("Hello!");
        dialogTree.Root = new Branch("Good evening.");

        using (FileStream fs = new FileStream("D:\\NightSky-ConsoleGame\\NightSky.App\\Files\\dialog1.json",
           FileMode.Create))
        {
            await JsonSerializer.SerializeAsync(fs, dialogTree.branches,
                new JsonSerializerOptions { WriteIndented = true });
        }


    }



}






//Console.WriteLine(player);