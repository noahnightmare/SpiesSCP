namespace SpiesSCP.ConfigObjects;

public class ItemChance
{
    public string ItemName { get; set; } = ItemType.None.ToString();

    public double Chance { get; set; }

    public void Deconstruct(out string name, out double i, out string groupKey)
    {
        name = ItemName;
        i = Chance;
    }
}