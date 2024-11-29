using SeaBattle.Field.Field;

namespace SeaBattle
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var a = 0;
            var av = new Player(3);
            Field.Field.Field.AddNewFieldTenOnTen(av);

            var displayer = new FieldDisplayer();
            displayer.ShowField(av);
        }
    }
}
