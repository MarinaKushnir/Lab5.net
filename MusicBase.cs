namespace Lab5
{
    internal class MusicBase
    {
        public string Name { get; set; }
        public string Maker { get; set; }
        public string Color { get; set; }
        public double Weight { get; set; }
        public int Price { get; set; }

        public override string ToString()
        {
            return $"\n Имя: {Name}; \n Производитель: {Maker};\n Цвет: {Color};\n Вес: {Weight};\n Цена(грн): {Price};";
        }
    }
}