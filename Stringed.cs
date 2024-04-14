using System;

namespace Lab5
{
    internal class Stringed : MusicInstrument
    {
        private bool _isElectric;
        private string _stringMaterial;
        private int _numberOfStrings;
        public static readonly int MAX_NumberOfStrings = 50;

        public int NumberOfStrings
        {
            get => _numberOfStrings;
            set => _numberOfStrings = value > 0 && value < MAX_NumberOfStrings ? value : throw new System.ArgumentOutOfRangeException();
        }
        public bool IsElectric
        {
            get => _isElectric;
            set => _isElectric = value;
        }
        public string StringMaterial
        {
            get => _stringMaterial;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _stringMaterial = value.Trim();
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
        }


        public Stringed(string name, string maker, string color, double weight, int price, int numberOfStrings, bool isElectric, string stringMaterial) : base(name, maker, color, weight, price)
        {
            NumberOfStrings = numberOfStrings;
            IsElectric = isElectric;
            StringMaterial = stringMaterial;
        }


        public override string ToString()
        {
            return $"{base.ToString()} \n Количество струн: {NumberOfStrings};\n Материал струн: {StringMaterial};\n Элекрическое подключение: {IsElectric}.";
        }

    }
}
