using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Animal
    {
        public Animal(string name, string kind, string predatororherbivore, double foodperday)
        {
            Name = name;
            Kind = kind;
            PredatorOrHerbivore = predatororherbivore;
            FoodPerDay = foodperday;
        }
        public string Kind
        {
            get
            {
                return $"Вид - {_kind}";
            }
            private set
            {
                _kind = value;
            }
        }
        private string _kind;
        public string RequiredBiom
        {
            get
            {
                return $"Необходимый биом - {_requiredbiom}";
            }
            set
            {
                _requiredbiom = value;
            }
        }
        private string _requiredbiom;
        public string RequiredArea
        {
            get
            {
                return $"Необходимая площадь - {_requiredarea}";
            }
            set
            {
                _requiredarea = value;
            }
        }
        private string _requiredarea;

        public List<string> TypeFood
        {
            get
            {
                return typesfood;
                //foreach (string food in typefood)
                //{
                //    Console.WriteLine(food);
                //}
            }
        }
        private List<string> typesfood=new List<string>();

        public string PredatorOrHerbivore
        {
            get
            {
                return $"{_predatororherbivore}";
            }
            set
            {
                if (value == "хищник" ^ value == "травоядный")
                {
                    _predatororherbivore = value;
                }
            }
        }
        private string _predatororherbivore;
        public string Sound
        {
            get
            {
                return _sound;
            }
            set
            {
                _sound = value;
            }
        }
        private string _sound;

        public string Name { get; set; }
        public double FoodPerDay 
        { 
            get
            {
                return _foodPerDay;
            }
            set
            {
                _foodPerDay = value;
            } 
        }
        private static double _foodPerDay;
        public int Age { get; set; }

        public void Eat(double weight, string typefood)
        {
            if (typesfood.Contains(typefood))
            {
                eated += weight;
                if (eated > _foodPerDay)
                {
                    eated = _foodPerDay;
                }
            }
        }
        public double eated = 0;
        public void IsWellFed()
        {
            if (eated >= _foodPerDay)
            {
                _hungryStatus = $"сыт и доволен";
            }
        }
        private string _hungryStatus = $"голоден";
        public void MakeSound()
        {
            Console.WriteLine(_sound);
        }
        public void Play()
        {
            Console.WriteLine($"{_kind} {Name} playing.");
        }
    }
}
