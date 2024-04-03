using System;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Percussion drum1 = new Percussion("Барабан", "Mapex", "Коричневый", 4, 6082, 1, "Малый барабан", "Дерево");
            Stringed guitar1 = new Stringed("Гитара", "GEWA", "Черный", 3.5, 4322, 6, "Нейлон", "Есть");
            Wind flute1 = new Wind("Флейта", "Mooer", "Белый", 0.5, 10628, "Блок-флейта", "Пластик", "Пластик");

            MusicInstrument[] instruments = { drum1, guitar1, flute1 };


            foreach (var instrument in instruments)
            {
                Console.WriteLine(instrument);
            }
        }
    }
}
