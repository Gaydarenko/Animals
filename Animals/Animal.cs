namespace Animals
{
    public class Animal
    {
        private static double _foodPerDay;
        private string _kind;
        private string _requiredBiom;
        private string _requiredArea;
        private string _predatorOrHerbivore;
        private List<string> typesFood = new List<string>();
        private string _sound;
        public double Eated = 0;
        public string HungryStatus = "животное голодное";
        public Animal(string name, string kind, string predatorOrHerbivore, double foodPerDay)
        {
            Name = name;
            Kind = kind;
            PredatorOrHerbivore = predatorOrHerbivore;
            FoodPerDay = foodPerDay;
        }
        public void Eat(double weight, string typeFood)
        {
            if (typesFood.Contains(typeFood))
            {
                if (Eated >= _foodPerDay)
                    Console.WriteLine("животное есть не будет, т.к. уже сыто");
                else
                    Eated += weight;
                    if (Eated > _foodPerDay)
                    {
                        Eated = _foodPerDay;
                    }
                    IsWellFed();
            }
        }
        public void IsWellFed()
        {
            if (_foodPerDay == Eated)
            {
                HungryStatus = "животное сыто и довольно";
            }
        }
        public void MakeSound()
        {
            Console.WriteLine(_sound);
        }
        public void Play()
        {
            Console.WriteLine($"{_kind} {Name} playing.");
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
        public string RequiredBiom
        {
            get
            {
                return $"Необходимый биом - {_requiredBiom}";
            }
            set
            {
                _requiredBiom = value;
            }
        }
        public string RequiredArea
        {
            get
            {
                return $"Необходимая площадь - {_requiredArea}";
            }
            set
            {
                _requiredArea = value;
            }
        }
        public List<string> TypeFood
        {
            get
            {
                return typesFood;
            }
        }
        public string PredatorOrHerbivore
        {
            get
            {
                return $"{_predatorOrHerbivore}";
            }
            set
            {
                if (value == "хищник" ^ value == "травоядный")
                {
                    _predatorOrHerbivore = value;
                }
            }
        }
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
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
