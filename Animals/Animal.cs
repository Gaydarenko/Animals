namespace Animals
{
    public class Animal
    {
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
                //Console.WriteLine($"eated = {eated}, _foodPerDay = {_foodPerDay}, weight = {weight}");
                if (eated >= _foodPerDay)
                    Console.WriteLine("животное есть не будет, т.к. уже сыто");
                else
                    eated += weight;
                    if (eated > _foodPerDay)
                    {
                        eated = _foodPerDay;
                    }
                    IsWellFed();
            }
        }
        public double eated = 0;
        public void IsWellFed()
        {
            if (_foodPerDay == eated)
            {
                hungryStatus = "животное сыто и довольно";
            }
        }
        public string hungryStatus = "животное голодное";
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
        private string _kind;
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
        private string _requiredBiom;
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
        private string _requiredArea;
        public List<string> TypeFood
        {
            get
            {
                return typesFood;
            }
        }
        private List<string> typesFood = new List<string>();
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
        private string _predatorOrHerbivore;
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
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
