// 24th lesson
using Animals;

Animal animal1 = new Animal("Желтый полосатик", "тигра", "хищник", 3.5);
//animal1.Kind = "tiger";
animal1.RequiredBiom = "savana";
animal1.RequiredArea = "20 m^2";
//animal1.TypeFood = { "fish", "meat" };
//animal1.PredatorOrHerbivore = "predator";
animal1.Sound = "Rrrrrr";

//animal1.Name = "Simba";
//animal1.FoodPerDay = 7.5;
animal1.Age = 9;


// tests
Console.WriteLine(animal1.Kind);
Console.WriteLine(animal1.RequiredBiom);
Console.WriteLine(animal1.RequiredArea);
Console.WriteLine(animal1.PredatorOrHerbivore);
Console.WriteLine(animal1.Sound);
Console.WriteLine(animal1.Name);
Console.WriteLine($"Возраст {animal1.Age}");



animal1.TypeFood.Add("meet");
animal1.TypeFood.Add("grass");
foreach (string s in animal1.TypeFood)
{
    Console.WriteLine(s);
}
Console.WriteLine(animal1.eated);
animal1.Eat(2, "meet");
Console.WriteLine(animal1.eated);
animal1.Eat(2.7, "meet");
Console.WriteLine(animal1.eated);
animal1.Eat(7, "meet");
Console.WriteLine(animal1.eated);
//animal1.IsWellFed();
Console.WriteLine(animal1.hungryStatus);
//Console.WriteLine(animal1.TypeFood.);
//string[] = [] { "qq", "ww", "ee"}
