using System;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Percussion drum = new Percussion
            {
                Information = new MusicBase
                {
                    Name = "Барабан",
                    Maker = "Mapex",
                    Color = "Коричневый",
                    Weight = 4,
                    Price = 6082
                },
                NumberOfPieces = 1,
                DrumType = "Малый барабан",
                DrumMaterial = "Дерево"
            };

            Stringed guitar = new Stringed
            {
                Information = new MusicBase
                {
                    Name = "Гитара",
                    Maker = "GEWA",
                    Color = "Черный",
                    Weight = 3.5,
                    Price = 4322
                },
                NumberOfStrings = 6,
                StringMaterial = "Нейлон",
                IsElectric = "Есть"
            };

            Wind flute = new Wind
            {
                Information = new MusicBase
                {
                    Name = "Флейта",
                    Maker = "Mooer",
                    Color = "Белый",
                    Weight = 0.5,
                    Price = 10628
                },
                InstrumentType = "Блок-флейта",
                MouthpieceMaterial = "Пластик",
                InstrumentMaterial = "Пластик"
            };


            MusicInstrument[] instruments = { drum, guitar, flute };


            foreach (var instrument in instruments)
            {
                Console.WriteLine(instrument);
            }
        }
    }
}
