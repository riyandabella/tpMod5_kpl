public class DataGeneric<T>
{
    private T data;

    public DataGeneric(T data)
    {
        this.data = data;
    }

    public void PrintData()
    {
        Console.WriteLine("Data yang tersimpan adalah : " + data);
    }
}

public class Utama
{
    static void Main()
    {
        DataGeneric<String> data = new DataGeneric<string>("103022300001");
        data.PrintData();
    }
}