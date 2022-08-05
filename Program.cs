using System;
    abstract class Engine
    {

   
        public abstract void Throttle();
    }


    class V8 : Engine
    {

        public override void Throttle()
        {

            Console.WriteLine("horn2 + 1horn");

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            V8 D = new V8();
            D.Throttle();

            
        }
    }
