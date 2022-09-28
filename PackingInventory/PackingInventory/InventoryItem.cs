public class InventoryItem
{
    public double itemWeight { get; }
    public double itemVolume { get; }

    public InventoryItem(double itemWeight, double itemVolume)
    {
        this.itemVolume = itemVolume;
        this.itemWeight = itemWeight;
    }

    // PascalCase
    // camelCase
    // snake_case
    // kebab-case
}