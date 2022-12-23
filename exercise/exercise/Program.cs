using System;

namespace Static
{

    public interface IAligator
    {
        public void HuntA(Aligator aligator);
    }
    public interface IMoose
    {
        public void HuntM(Moose moose);
    }
    public interface IBladEagle
    {
        public void HuntB(BladEagle bladEagle);
    }
    public class Aligator : Animal
    {
        Aligator a = new Aligator();
        public void HuntA()
        {
            Console.WriteLine("aligator");
        }

    }
    public class Moose : Animal
    {
        Moose m = new Moose();
        public void HuntM()
        {
            Console.WriteLine("moos");
        }
    }
    public class BladEagle : Animal
    {
        BladEagle b = new BladEagle();
        public void HuntV()
        {
            Console.WriteLine("bladEagle");
        }
    }

    public abstract class Animal
    {
        public Animal()
        {

        }
        public int sumOfHandAndFoot { get; set; }
        public enum animalType
        {
            khazande,
            parande,
            pestandar
        }

        public abstract void Move()
        {
            Console.WriteLine("move animal");
        }
        public abstract void Eat()
        {
            Console.WriteLine("eat animal");
        }
        class Program:
        { 
        }
        static void Main(string[] args)
        {

        }
    }


}
