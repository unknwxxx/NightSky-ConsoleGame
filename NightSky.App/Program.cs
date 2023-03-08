using NightSky.App.Entities.DialogTree;
using System.Text.Json;

DialogTree dialogTree = new DialogTree();


using (FileStream fs = new FileStream("D:\\NightSky-ConsoleGame\\NightSky.App\\Files\\test.json",
         FileMode.Create))
{
    JsonSerializer.Serialize(fs, dialogTree.Branches,
        new JsonSerializerOptions { WriteIndented = true });
}
