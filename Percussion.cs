namespace Lab5
{
    internal class Percussion : MusicInstrument
    {
        public int NumberOfPieces { get; set; }
        public string DrumType { get; set; }
        public string DrumMaterial { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()} \n Количество частей: {NumberOfPieces};\n Тип: {DrumType};\n Материал : {DrumMaterial}";
        }
    }
}