public class Auto
{
    public string Marka { get; set; }
    public int Ev { get; set; }

    public override string ToString()
    {
        return $"{Marka} ({Ev})";
    }
}