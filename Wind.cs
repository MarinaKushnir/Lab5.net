namespace Lab5
{
    internal class Wind : MusicInstrument
{
    public string InstrumentType { get; set; }
    public string MouthpieceMaterial { get; set; }
    public string InstrumentMaterial { get; set; }

    public override string ToString()
    {
        return $"{base.ToString()} \n Тип инструмента: {InstrumentType};\n Материал мундштука: {MouthpieceMaterial};\n Материал инструмента: {InstrumentMaterial}.";
    }
}
}