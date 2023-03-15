using NightSky.App.Entities;
using NightSky.App.Entities.Artefacts;
using NightSky.App.Entities.DialogTree;
using NightSky.App.Entities.Spells;
using NightSky.App.Enums;
using System.Reflection.Emit;
using System.Text.Json;


GameManager gameManager = new GameManager();
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
        {
            Console.WriteLine("\nНажмте enter для продолжения ...");
            Console.ReadKey();
        }

        Console.Clear();
    }
};



//using(StreamReader sr = new StreamReader("D:\\NightSky-ConsoleGame\\NightSky.App\\Files\\logo.txt"))
//{
//    string content = sr.ReadToEnd();
//    Console.WriteLine(content);
//}

//dialogTree.Root = new Branch("\n\t\t" +
//    "Добро пожаловать в NightSky, захватывающую ролевую игру, где вы отправитесь в незабываемое приключение в увлекательном мире фэнтези! \n\t\t" +
//    "Вы готовы стать героем своей собственной истории? \n\t\tВ NightSky вас ждут увлекательные задания, встречи с интересными персонажами и опасные приключения. \t\t").AddWaiting();


//dialogTree.Root = new Branch("Для начала необходимо создать персонажа.").AddWaiting();

//Console.Write("Введите имя персонажа: ");
//var name = Console.ReadLine();

//dialogTree.Root = new Branch("Далее необходимо указать возраст и пол персонажа. ").AddWaiting();
//Console.Write("Возраст: ");
//var age = int.Parse(Console.ReadLine());

//Console.Write("Чтобы выбрать пол напишите 0 для выбора мужского пола и 1 для женского: ");
//var gender = int.Parse(Console.ReadLine());

//dialogTree.Root = new Branch("Отлично.");
//dialogTree.Root = new Branch("Далее пройдемся по более узким характеристикам.");

//Console.WriteLine("Укажите рассу персонажа: ");
//dialogTree.Root = new Branch("0. Человек \n")
//    .AddOption("1. Эльф \n", null, 0)
//    .AddOption("2. Орк \n", null, 1)
//    .AddOption("3. Гоблин \n", null, 2);

//var race = int.Parse(Console.ReadLine());

//Console.Clear();
//Console.WriteLine("Ваш персонаж создан. Ниже расположена вся информация о персонаже: ");

//var player = new Mage(
//    name: name,
//    age: age,
//    race: (Race)Enum.Parse(typeof(Race), race.ToString()),
//    gender: (Gender)Enum.Parse(typeof(Gender), gender.ToString()),
//    state: State.Normal,
//    maxHealth: 100f,
//    health: 100f,
//    canTalk: true,
//    canMove: true,
//    currentMagicalEnergy: 100f,
//    maxMagicalEnergy: 100f,
//    isInvulnerable: false);

//Console.WriteLine(player);
//Console.ReadKey();

//Console.WriteLine("Выберите уровень сложности: ");
//dialogTree.Root = new Branch("0. Новичок \n")
//    .AddOption("1. Опытный \n", null, 0)
//    .AddOption("2. Ветеран \n", null, 1)
//    .AddOption("3. Мастер \n", null, 2).AddWaiting();

//var levelOfDifficulty = int.Parse(Console.ReadLine());

//dialogTree.Root = new Branch("Отлично. Теперь нужно выбрать место старта. ").AddWaiting();
//dialogTree.Root = new Branch("В зависимости от спавна будет увеличиваться сложность старта. Игровая зона делится на северную и южную часть. " +
//    "\nЛокации более севернее - сложнее. Южнее - легче. В первой награды и задания куда получше чем во второй, но риск умереть куда больше. ").AddWaiting();


//Console.WriteLine("Cписок локаций: ");
//dialogTree.Root = new Branch("0. Кордон - (Южная Локация) \n")
//    .AddOption("1. Лощина - (Южная Локация) \n", null, 0)
//    .AddOption("2. Генераторы - (Северная Локация) \n", null, 1)
//    .AddOption("3. Радар - (Северная Локация) \n", null, 2);

var levelStart = int.Parse(Console.ReadLine());


while(true)
{
    switch (levelStart)
    {
        case 0:
            {

                var level = new LevelManager();

                level.LoadLevel += (e, level) =>
                {
                    Console.WriteLine("Загрузка локации Кордон...");
                };

                level.Load(new LevelEventArgs(new Kordon()));

                while (true)
                {

                }

                

                break;
            }
        case 1:
            {
                break;
            }
        case 2:
            {
                break;
            }
        case 3:
            {
                break;
            }
        default:
            {
                break;
            }

    }
}



