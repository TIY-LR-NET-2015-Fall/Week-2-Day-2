    public class Human
    {
        public int Age { get; set; }
        public string FullName { get; set; }

        public static Human operator +(Human h1, Human h2)
        {
            return new Human() { FullName = "YOU JUST ADDED 2 PEOPLE TOGETHER.", Age = h1.Age + h2.Age};

        }

        public override string ToString()
        {
            return this.FullName;
        }

    }

    public class Calculator<T>
    {
        public T Add(T a, T b)
        {
            return (dynamic)a + (dynamic)b;
        }

       
    }

    public class DanielsCollectionOfNumbers : Collection<int>
    {
        public string SomeExtraProperty  { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { };
            
            List<int> numbers2 = new List<int>();
            numbers2.Add(5);
            numbers2.Add(134);
            numbers2.Clear();
            numbers2.Remove(5);


            Collection<int> numbers3 = new Collection<int>();
            numbers3.Add(5);
            numbers3.Add(134);
            numbers3.Clear();
            numbers3.Remove(5);

            DanielsCollectionOfNumbers numbers4 = new DanielsCollectionOfNumbers();
            numbers4.Add(5);
            numbers4.Add(134);
            numbers4.Clear();
            numbers4.Remove(5);


            Calculator<int> ti83 = new Calculator<int>();
            Calculator<float> ti83ThatHandlesFloats = new Calculator<float>();
            Calculator<Human> humanCalculator = new Calculator<Human>();

            Human human1 = new Human() { FullName = "Daniel", Age = 34 };
            Human human2 = new Human() { FullName = "Cason", Age = 27 };


            Console.WriteLine($"The sum of 5 and 3 is {ti83.Add(5, 3)}");
            Console.WriteLine($"The sum of 5.2 and 3.6is {ti83ThatHandlesFloats.Add(5.2f, 3.6f)}");
           Console.WriteLine($"The sum of 2 humans is {humanCalculator.Add(human1, human2)}");

            Console.ReadLine();

        }

       
    }
