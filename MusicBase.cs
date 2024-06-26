using System;

namespace Lab5
{
    internal class MusicBase
    {
        private string _name;
        private string _maker;
        private string _color;
        private double _weight;
        private int _price;
        public static readonly int MAX_Weight = 100;

        public string Name { 
            get=> _name;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _name = value.Trim();
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
        }
        public string Maker
        {
            get => _maker;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _maker = value.Trim();
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
        }
        public string Color
        {
            get => _color;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _color = value.Trim();
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
        }
        public double Weight
        {
            get => _weight;
            set => _weight = value > 0 && value< MAX_Weight ? value : throw new System.ArgumentOutOfRangeException();
        }
        public int Price
        {
            get => _price;
            set => _price = value > 0 ? value : throw new System.ArgumentOutOfRangeException();
        }

        public MusicBase(string name, string maker, string color, double weight, int price)
        {
            Name = name;
            Maker = maker;
            Color = color;
            Weight = weight;
            Price = price;
        }
        public override string ToString()
        {
            return $"\n Имя: {Name}; \n Производитель: {Maker};\n Цвет: {Color};\n Вес: {Weight} кг;\n Цена: {Price} грн;";
        }
    }
}
