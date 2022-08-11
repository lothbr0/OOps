
interface Sim
{
    void call(); void browse();
}
class Airtel : Sim
{
    public void call() { Console.WriteLine("Airtel is calling"); }
    public void browse() { Console.WriteLine("Airtel 4G connecting"); }
}
class Jio : Sim
{
    public void call() { Console.WriteLine("Jio is calling"); }
    public void browse() { Console.WriteLine("Jio 4G connecting"); }
}
class Program
{
    static void Main(String[] args)
    {
        Airtel a = new Airtel(); a.call(); a.browse(); Jio j = new Jio(); j.call(); j.browse();

        Console.ReadLine();
    }
}

