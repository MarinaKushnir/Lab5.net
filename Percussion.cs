namespace Lab5
{
    internal class Percussion : MusicInstrument
    {

        private string _drumType;
        private string _drumMaterial;
        private int _numberOfPieces;
        public static readonly int MAX_NumberOfPieces = 100;
        public int NumberOfPieces
        {
            get => _numberOfPieces;
            set => _numberOfPieces = value > 0 && value < MAX_NumberOfPieces ? value : throw new System.ArgumentOutOfRangeException();
        }
        public string DrumType{ 
            get=> _drumType; 
            set => _drumType = value.Trim(); 
        }
        public string DrumMaterial{
            get => _drumMaterial;
            set => _drumMaterial = value.Trim();
        }


        public Percussion(string name, string maker, string color, double weight, int price, int numberOfPieces, string drumType, string drumMaterial) : base(name, maker, color, weight, price)
        {
            NumberOfPieces= numberOfPieces;
            DrumType = drumType;
            DrumMaterial = drumMaterial;
        }

        

        public override string ToString()
        {
            return $"{base.ToString()} \n Количество частей: {NumberOfPieces};\n Тип: {DrumType};\n Материал : {DrumMaterial}";
        }
    }
}
