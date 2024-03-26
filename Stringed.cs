namespace Lab5
{
    internal class Stringed : MusicInstrument
    {
        public int NumberOfStrings { get; set; }
        public string StringMaterial { get; set; }
        public string IsElectric { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()} \n Количество струн: {NumberOfStrings};\n Материал струн: {StringMaterial};\n Элекрическое подключение: {IsElectric}.";
        }
    }
}