public class HaloGeneric
{
    public void SapaUser<T>(T nama)
    {
        Console.WriteLine("Halo User " + nama);
    }
}

public class Utama
{
    public static void Main(String[] args)
    {
        HaloGeneric sapa = new HaloGeneric();
        sapa.SapaUser("Bella");
    }
}