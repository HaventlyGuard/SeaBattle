using SeaBattle.Field.Field;

namespace SeaBattle
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var a = 0;
            var av = new Player();
            Field.Field.Field.AddNewFieldTenOnTen(av);
            av.FillField(Field.Field.Field.GameField[av]);
            Field.Field.FieldDisplayer.ShowField(av);
        }
    }
}
