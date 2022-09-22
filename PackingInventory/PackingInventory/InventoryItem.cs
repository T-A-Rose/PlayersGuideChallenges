public class InventoryItem
{
    public double ItemWeight { get; }
    public double ItemVolume { get; }

    public InventoryItem(double itemWeight, double itemVolume)
    {
        ItemVolume = itemVolume;
        ItemWeight = itemWeight;
    }

}