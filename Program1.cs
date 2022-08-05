using System;

public class Espeed
{
    public virtual void setspeed()
    {
        Console.WriteLine("You exceeded 40");
    }
}
    public class Nspeed : Espeed
    {
        public override void setspeed()
        {
            Console.WriteLine("You exceeded 60");

        }
    }
class prgrm
{
    static void Main(string[] args)
    {
        Nspeed nspeed = new Nspeed();
        nspeed.setspeed();
        Espeed espeed = new Espeed();   
        espeed.setspeed();
    }

}

