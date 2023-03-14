using NightSky.App.Entities;
using NightSky.App.Entities.Artefacts;
using NightSky.App.Entities.DialogTree;
using NightSky.App.Entities.Spells;
using NightSky.App.Enums;
using System.Security.Cryptography;
using System.Text.Json;


//var spell = new AddHealth();
//spell.SpellCast += Spell_SpellCast;
//spell.PerformMagicEffect(player, 10);

//var artifact = new WaterBottle(0, false, 10);
//artifact.PerformMagicEffect(player);
//Console.WriteLine(player.Config.CurrentHealth);


//var smallDeadWaterBottle = new BasiliskEye(10);
//smallDeadWaterBottle.PerformMagicEffect(player);
//Console.WriteLine(player);

//void Spell_SpellCast(object? sender, SpellEventArgs e)
//{
//    Console.WriteLine(e.TargetCharacter.Config.CurrentHealth);
//}

DialogTree dialogTree = new DialogTree(new Branch());

dialogTree.BranchInfoSaved += (branch) =>
{
    using (FileStream fs = new FileStream("D:\\NightSky-ConsoleGame\\NightSky.App\\Files\\test.json",
         FileMode.Append))
    {
        JsonSerializer.Serialize(fs, branch,
            new JsonSerializerOptions { WriteIndented = true }
            );

        foreach (var item in branch.Text)
        {
            Console.Write(item);
            Thread.Sleep(80);
        }

        foreach (var item in branch.Content)
        {
            for (int i = 0; i < item.Value.Length; i++)
            {
                Console.Write(item.Value[i]);
                Thread.Sleep(80);
            }
        }

        if (branch.IsWaiting)
            Console.ReadKey();

        Console.Clear();
    }
};


dialogTree.Root = new Branch("Добро пожаловать в NightSky, захватывающую ролевую игру, где вы отправитесь в незабываемое приключение в увлекательном мире фэнтези! Вы готовы стать героем своей собственной истории? В NightSky вас ждут увлекательные задания, встречи с интересными персонажами и опасные приключения. Давайте начнем!");

dialogTree.Root = new Branch("Для начала необходимо создать персонажа.").AddWaiting();

Console.Write("Введите имя персонажа: ");
var name = Console.ReadLine();

dialogTree.Root = new Branch("Далее необходимо указать возраст и пол персонажа. ").AddWaiting();
Console.Write("Возраст: ");
var age = int.Parse(Console.ReadLine());

Console.Write("Чтобы выбрать пол напишите 0 для выбора мужского пола и 1 для женского: ");
var gender = int.Parse(Console.ReadLine());

dialogTree.Root = new Branch("Отлично.");
dialogTree.Root = new Branch("Далее пройдемся по более узким характеристикам.");

dialogTree.Root = new Branch("Укажите рассу персонажа: ");
dialogTree.Root = new Branch("1. Человек \n")
    .AddOption("2. Эльф \n", null, 0)
    .AddOption("3. Орк \n", null, 1)
    .AddOption("4. Гоблин \n", null, 2);

var race = int.Parse(Console.ReadLine());


dialogTree.Root = new Branch("Выберите уровень сложности: ");
dialogTree.Root = new Branch("1. Новичок \n")
    .AddOption("2. Опытный \n", null, 0)
    .AddOption("3. Ветеран \n", null, 1)
    .AddOption("4. Мастер \n", null, 2);

var LevelOfDifficulty = int.Parse(Console.ReadLine());

dialogTree.Root = new Branch("Отлично. Теперь нужно выбрать место старта. ").AddWaiting();
dialogTree.Root = new Branch("В зависимости от спавна будет увеличиваться сложность старта. Игровая зона делится на северную и южную часть. " +
    "\nЛокации более севернее - сложнее. Южнее - легче. В первой награды и задания куда получше чем во второй, но риск умереть куда больше. ").AddWaiting();







//var player = new Mage(
//    name: name,
//    age: age,
//    race: Race.Orc,
//    gender: Gender.Male,
//    state: State.Sick,
//    maxHealth: 100f,
//    health: 50f,
//    canTalk: true,
//    canMove: true,
//    currentMagicalEnergy: 150f,
//    maxMagicalEnergy: 1000f,
//    isInvulnerable: false);



//dialogTree.Root = new Branch("test").AddOption("test1", null, 0).AddOption("test2", null, 1);

//var choice = 0;

//while(true)
//{
//    choice = int.Parse(Console.ReadLine());

//    if (choice == 0)
//    {
//        Console.WriteLine(dialogTree.Root.Content[choice].Value);
//    }
//    else
//    {
//        Console.WriteLine(dialogTree.Root.Content[choice].Value);
//    }
//}








