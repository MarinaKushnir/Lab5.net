namespace Lab5
{
    internal class Stringed : MusicInstrument
    {
        private string _isElectric;
        private string _stringMaterial;
        private int _numberOfStrings;
        public static readonly int MAX_NumberOfStrings = 50;

        public int NumberOfStrings
        {
            get => _numberOfStrings;
            set => _numberOfStrings = value > 0 && value < MAX_NumberOfStrings ? value : throw new System.ArgumentOutOfRangeException();
        }
        public string IsElectric
        {
            get => _isElectric;
            set => _isElectric = value.Trim();
        }
        public string StringMaterial
        {
            get => _stringMaterial;
            set => _stringMaterial = value.Trim();
        }


        public Stringed(string name, string maker, string color, double weight, int price, int numberOfStrings, string isElectric, string stringMaterial) : base(name, maker, color, weight, price)
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
