namespace Animals.Test
{
    public class AnimalTets
    {
        [TestCase("������ ���������", "�����", "������", 3.5, "��� - �����")]
        [TestCase("������� ����������", "��������", "������", 5, "��� - ��������")]
        [TestCase("�����", "�������", "����������", 0.2, "��� - �������")]
        public void KindTest(string name, string kind, string pred_herb, double food_weight, string expect)
        {
            Animal animal1 = new Animal(name, kind, pred_herb, food_weight);
            string actual = animal1.Kind;
            Assert.AreEqual(expect, actual);
        }
        [TestCase("������ ���������", "�����", "������", 3.5, "������", "����������� ���� - ������")]
        [TestCase("������� ����������", "��������", "������", 5, "�������", "����������� ���� - �������")]
        [TestCase("�����", "�������", "����������", 0.2, "�������", "����������� ���� - �������")]
        public void RequiredBiomTest(string name, string kind, string pred_herb, double food_weight,string req_biom, string expect)
        {
            Animal animal = new Animal(name, kind, pred_herb, food_weight);
            animal.RequiredBiom = req_biom;
            string actual = animal.RequiredBiom;
            Assert.AreEqual(expect, actual);
        }
        [TestCase("������ ���������", "�����", "������", 3.5, "20 m^2", "����������� ������� - 20 m^2")]
        [TestCase("������� ����������", "��������", "������", 5, "2 m^2", "����������� ������� - 2 m^2")]
        [TestCase("�����", "�������", "����������", 0.2, "320 m^2", "����������� ������� - 320 m^2")]
        public void RequiredAreaTest(string name, string kind, string pred_herb, double food_weight, string req_area, string expect)
        {
            Animal animal = new Animal(name, kind, pred_herb, food_weight);
            animal.RequiredArea = req_area;
            string actual = animal.RequiredArea;
            Assert.AreEqual(expect, actual);
        }
        [TestCase("������ ���������", "�����", "������", 3.5, "������")]
        [TestCase("������� ����������", "��������", "������", 5, "������")]
        [TestCase("�����", "�������", "����������", 0.2, "����������")]
        public void PredatorOrHerbivoreTest(string name, string kind, string pred_herb, double food_weight, string expect)
        {
            Animal animal = new Animal(name, kind, pred_herb, food_weight);
            string actual = animal.PredatorOrHerbivore;
            Assert.AreEqual(expect, actual);
        }
        [TestCase("������ ���������", "�����", "������", 3.5, "����", "����")]
        [TestCase("������� ����������", "��������", "������", 5, "����", "����")]
        [TestCase("�����", "�������", "����������", 0.2, "�����-�����", "�����-�����")]
        public void SoundTest(string name, string kind, string pred_herb, double food_weight, string sound, string expect)
        {
            Animal animal = new Animal(name, kind, pred_herb, food_weight);
            animal.Sound = sound;
            string actual = animal.Sound;
            Assert.AreEqual(expect, actual);
        }
        [TestCase("������ ���������", "�����", "������", 3.5, "������ ���������")]
        [TestCase("������� ����������", "��������", "������", 5, "������� ����������")]
        [TestCase("�����", "�������", "����������", 0.2, "�����")]
        public void NameTest(string name, string kind, string pred_herb, double food_weight, string expect)
        {
            Animal animal = new Animal(name, kind, pred_herb, food_weight);
            string actual = animal.Name;
            Assert.AreEqual(expect, actual);
        }
        [TestCase("������ ���������", "�����", "������", 3.5, 3.5)]
        [TestCase("������� ����������", "��������", "������", 5, 5)]
        [TestCase("�����", "�������", "����������", 0.2,  0.2)]
        public void FoodPerDayTest(string name, string kind, string pred_herb, double food_weight, double expect)
        {
            Animal animal = new Animal(name, kind, pred_herb, food_weight);
            double actual = animal.FoodPerDay;
            Assert.AreEqual(expect, actual);
        }
        [TestCase("������ ���������", "�����", "������", 3.5, 1, 1)]
        [TestCase("������� ����������", "��������", "������", 5, 5, 5)]
        [TestCase("�����", "�������", "����������", 0.2, 22, 22)]
        public void AgeTest(string name, string kind, string pred_herb, double food_weight, int age, int expect)
        {
            Animal animal = new Animal(name, kind, pred_herb, food_weight);
            animal.Age = age;
            int actual = animal.Age;
            Assert.AreEqual(expect, actual);
        }
        [TestCase("������ ���������", "�����", "������", 3.5, 2, "����", 2)]
        [TestCase("������� ����������", "��������", "������", 5, 13, "����", 5)]
        [TestCase("������� ����������", "��������", "������", 5, 3, "����", 0)]
        public void EatTest(string name, string kind, string pred_herb, double food_weight, double food, string type_food, double expect)
        {
            Animal animal = new Animal(name, kind, pred_herb, food_weight);
            animal.TypeFood.Add("����");
            animal.Eat(food, type_food);
            double actual = animal.Eated;
            Assert.AreEqual(expect, actual);
        }
        [TestCase("������ ���������", "�����", "������", 3.5, 2, "����", "�������� ��������")]
        [TestCase("������� ����������", "��������", "������", 5, 13, "����", "�������� ���� � ��������")]
        [TestCase("������� ����������", "��������", "������", 5, 13, "����", "�������� ��������")]
        public void IsWellFedTest(string name, string kind, string pred_herb, double food_weight, double food, string type_food, string expect)
        {
            Animal animal = new Animal(name, kind, pred_herb, food_weight);
            animal.TypeFood.Add("����");
            animal.Eat(food, type_food);
            string actual = animal.HungryStatus;
            Assert.AreEqual(expect, actual);
        }
    }
}