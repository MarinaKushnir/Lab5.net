namespace Lab5
{
    internal class MusicInstrument
    {
        public MusicBase Information { get; set; }

        public override string ToString()
        {
            return $"Музыкальный инструмент: {Information}";
        }
    }
}