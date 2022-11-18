using Microsoft.VisualBasic;

TerrainType[,] mapArray = new TerrainType[6, 7]
{
    {TerrainType.Water, TerrainType.Water, TerrainType.Water, TerrainType.Water, TerrainType.Water, TerrainType.Water, TerrainType.Water}, 
    {TerrainType.Water, TerrainType.MountainOptions, TerrainType.Water, TerrainType.MountainOptions, TerrainType.MountainOptions, TerrainType.Water, TerrainType.Water}, 
    {TerrainType.Water, TerrainType.MountainOptions, TerrainType.MountainOptions, TerrainType.Land, TerrainType.Land, TerrainType.Land, TerrainType.Water}, 
    {TerrainType.Water, TerrainType.Water, TerrainType.Land, TerrainType.Land, TerrainType.Land, TerrainType.Water, TerrainType.Water}, 
    {TerrainType.Water, TerrainType.Land, TerrainType.Land, TerrainType.Water, TerrainType.Land, TerrainType.Water, TerrainType.Water}, 
    {TerrainType.Water, TerrainType.Water, TerrainType.Water, TerrainType.Water, TerrainType.Water, TerrainType.Water, TerrainType.Water}
};

TerrainType test = TerrainType.Water;
for (int i = 0; i < mapArray.GetLength(0); i++)
{
    for (int j = 0; j < mapArray.GetLength(1); j++)
    {
        string tile = mapArray[i, j] switch
        {
            TerrainType.Land => "**",
            TerrainType.Water => " ",
            TerrainType.MountainOptions => "^^",
            _ => "Invalid"
        };
        Console.Write(tile);
    }
    Console.WriteLine();
}

Console.ReadLine();

enum TerrainType{ Water, Land, MountainOptions};