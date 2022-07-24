using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Animal
    {
        public string Kind
        {
            get
            {
                return $"Вид - {_kind}";
            }
            set
            {
                _kind = value;
            }
        }
        private string? _kind;
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
        //public string[] TypeFood { 
        //    get
        //    {
        //        return _typefood;
        //    }
        //    set
        //    {
        //        string[] _typefood = { value };
        //    }
        //}
        //private string[] _typefood;
        public string PredatorOrHerbivore
        {
            get
            {
                return $"{_predatororherbivore}";
            }
            set
            {
                if (value == "predator" ^ value == "herbivore")
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
        public double FoodPerDay { get; set; }
        public int Age { get; set; }

        public void Eat()
        {
            eated += FoodPerDay;
        }
        public double eated = 0;
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
