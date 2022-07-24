// 24th lesson
using Animals;

Animal animal1 = new Animal();
animal1.Kind = "tiger";
animal1.RequiredBiom = "savana";
animal1.RequiredArea = "20 m^2";
//animal1.TypeFood = { "fish", "meat" };
animal1.PredatorOrHerbivore = "predator";
animal1.Sound = "Rrrrrr";

animal1.Name = "Simba";
animal1.FoodPerDay = 7.5;
animal1.Age = 9;


Console.WriteLine(animal1.Kind);
Console.WriteLine(animal1.RequiredBiom);
Console.WriteLine(animal1.RequiredArea);
Console.WriteLine(animal1.PredatorOrHerbivore);
Console.WriteLine(animal1.Sound);
Console.WriteLine(animal1.Name);
for (int i = 0; i < 5; i++)
{
    animal1.Eat();
    Console.WriteLine($"Всего съедено {animal1.eated}кг.");
}
Console.WriteLine($"Возраст {animal1.Age}");