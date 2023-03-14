namespace WarPreperations;

public record Sword(Materials materials, Gemstone gemstone, int length, int crossguardWidth)
{
    public override string ToString()
    {
        if (gemstone == Gemstone.none)
        {
            return $"A {length} inch blade with a {crossguardWidth} cm crossguard" +
                   $", made primarily out of {materials} with no gemstone";    
        }
        else
        {
            return $"A {length} inch blade with a {crossguardWidth} cm crossguard" +
                   $", made primarily out of {materials} with an {gemstone} gemstone";
        }
    }    
}

public enum Materials { wood, bronze, iron, steel, binarium};

public enum Gemstone { emerald, amber, sapphire, diamond, bitstone, none}
