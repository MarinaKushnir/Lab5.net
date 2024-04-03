namespace Lab5
{
    internal class MusicInstrument
    {
        private MusicBase _musicBase;


        public MusicInstrument(string name, string maker, string color, double weight, int price)
        {
            _musicBase = new MusicBase( name, maker, color, weight, price);
        }

        public override string ToString()
        {
            return $"Музыкальный инструмент: {_musicBase}";
        }
    }
}
