public class InventoryItem
{
    public double itemWeight { get; }
    public double itemVolume { get; }
    public string name { get; }

    public InventoryItem(double itemWeight, double itemVolume, string name)
    {
        this.itemVolume = itemVolume;
        this.itemWeight = itemWeight;
        this.name = name;
    }

    // PascalCase
    // camelCase
    // snake_case
    // kebab-case
}