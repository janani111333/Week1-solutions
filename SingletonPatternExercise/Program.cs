using System;

public class Singleton
{
    private static Singleton instance = null;

    private Singleton()
    {
        Console.WriteLine("Singleton Instance Created.");
    }

    public static Singleton GetInstance()
    {
        if (instance == null)
        {
            instance = new Singleton();
        }
        return instance;
    }

    public void ShowMessage()
    {
        Console.WriteLine("Hello from Singleton Pattern!");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Singleton obj1 = Singleton.GetInstance();
        Singleton obj2 = Singleton.GetInstance();

        obj1.ShowMessage();

        if (obj1 == obj2)
        {
            Console.WriteLine("Only one instance is used. Singleton works!");
        }
        else
        {
            Console.WriteLine("Different instances. Singleton failed.");
        }
    }
}
