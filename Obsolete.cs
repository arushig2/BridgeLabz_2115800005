using System;

class LegacyAPI
{

    [Obsolete("OldFeature() is deprecated. Use NewFeature() instead.")]
    public void OldFeature()
    {
        Console.WriteLine("This is the old feature. It should not be used.");
    }

    public void NewFeature()
    {
        Console.WriteLine("This is the new feature. Use this instead.");
    }
}

class Program
{
    static void Main()
    {
        LegacyAPI api = new LegacyAPI();

        api.OldFeature();
        api.NewFeature();
    }
}
