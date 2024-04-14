using System;

namespace Lab5
{
    internal class Wind : MusicInstrument
{
        private string _instrumentType;
        private string _mouthpieceMaterial;
        private string _instrumentMaterial;

        public string InstrumentType
        {
            get => _instrumentType;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _instrumentType = value.Trim();
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
        }
        public string MouthpieceMaterial
        {
            get => _mouthpieceMaterial;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _mouthpieceMaterial = value.Trim();
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
        }
        public string InstrumentMaterial
        {
            get => _instrumentMaterial;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _instrumentMaterial = value.Trim();
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
        }


        public Wind(string name, string maker, string color, double weight, int price, string instrumentType, string mouthpieceMaterial, string instrumentMaterial) : base(name, maker, color, weight, price)
        {
            InstrumentType = instrumentType;
            MouthpieceMaterial = mouthpieceMaterial;
            InstrumentMaterial = instrumentMaterial;
        }

        public override string ToString()
    {
        return $"{base.ToString()} \n Тип инструмента: {InstrumentType};\n Материал мундштука: {MouthpieceMaterial};\n Материал инструмента: {InstrumentMaterial}.";
    }
}
}
