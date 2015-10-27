
    public interface IBrakeable
    {
        void Brake();
    }

    public interface IAccelerate
    {
        void Accelerate();
    }

    public interface ISteerable
    {
        void TurnWheel(TurnDirection direction);
    }


    public interface IAutoPilot : IBrakeable, IAccelerate, ISteerable
    {
        void TurnOnAutoPilot();
        void TurnOffAutoPilot();
    }

    public interface ITrain : IBrakeable, IAccelerate
    {

    }

    public enum TurnDirection
    {
        Right = 10,
        Left = 5,        
        Center = 23
    }
    

    public class HondaAccord : IBrakeable, ISteerable, IAccelerate
    {
        public int Speed { get; set; }
        public void Accelerate()
        {
            Speed += 10;
        }

        public void Brake()
        {
            Speed = 0;
        }

        public void TurnWheel(TurnDirection direction)
        {
           
            switch(direction)
            {
                case TurnDirection.Left:
                    break;
                case TurnDirection.Right:
                    break;
                case TurnDirection.Center:
                    break;
                default:
                    break;

            }
        }
    }

    public interface IHuman
    {
        string Eat(string food);
    }

    public interface IGirl : IHuman
    {
        bool HasLongHair { get; set; }
    }

    public interface IMiss : IGirl, IHuman
    {

    }

    public interface IMister : IHuman
    {

    }

    public class Human : IHuman
    {
        public Human(int hungerlevel, int sleepinesslevel)
        {
            HungerLevel = hungerlevel;
            FirstName = "John";
            LastName = "Doe";
            Age = 30;
            SleepinessLevel = sleepinesslevel;
        }
        public int HungerLevel { get; private set; }
        public int SleepinessLevel { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Eat(string food)
        {
            if (HungerLevel <= 0)
            {
                return $"Not Hungry, didn't eat the {food}";
            }

            switch (food)
            {
                case "Taco":
                    HungerLevel -= 10;
                    break;
                case "Pizza":
                    HungerLevel -= 20;
                    break;
                default:
                    HungerLevel -= 1;
                    break;
            }

            if (HungerLevel <= 0)
            {
                HungerLevel = 0;

                return $"Not Hungry ANYMORE. Thanks {food}!";
            }
            else
            {
                return $"Still Hungry but I feel better. Thanks {food}!";
            }
        }



    }

    public static class HumanExtensions
    {
        public static string Sleep(this Human human, int hoursOfSleep)
        {
            if (hoursOfSleep >= 8)
            {
                human.SleepinessLevel = 0;
                return $"That was a great {hoursOfSleep} hours of sleep!!";
            }

            human.SleepinessLevel -= hoursOfSleep * 10;
            if (human.SleepinessLevel <= 0)
            {
                human.SleepinessLevel = 0;
            }

            return $"That was an ok {hoursOfSleep} hours of rest.";


        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            HondaAccord myCar = new HondaAccord();
            myCar.TurnWheel(TurnDirection.Left);
            Human daniel = new Human(23, 50);

            Console.WriteLine($"Result: {daniel.Eat("Taco")}. HungerLevel: {daniel.HungerLevel}");
            Console.WriteLine($"Result: {daniel.Eat("Pizza")}. HungerLevel: {daniel.HungerLevel}");
            Console.WriteLine($"Result: {daniel.Eat("Taco")}. HungerLevel: {daniel.HungerLevel}");

            Console.WriteLine($"Result: {daniel.Sleep(6)}. Sleepiness Level: {daniel.SleepinessLevel}");
            HumanExtensions.Sleep(daniel, 6);
            daniel.Sleep(6);

            Console.ReadLine();


            List<int> numbers = new List<int>();
            numbers.Add(5);
            numbers.Add(43);
            numbers.Add(5);
            numbers.Add(53);
            numbers.Add(103);

            numbers.Sum();


        }
    }
