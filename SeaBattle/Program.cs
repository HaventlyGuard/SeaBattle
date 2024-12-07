using SeaBattle.Field.Field;

namespace SeaBattle
{
    
    public class Program
    {
        public static int currentShipSize=1;
        public static int shipCount = 1;
        static void Main(string[] args)
        {
            
            var numberForExample1 = new Random();
            var numberForExample2 = new Random();
            Console.WriteLine("\t\t     Игра Морской Бой\n");
            Console.WriteLine($"\tЧтобы поставить или атаковать поле противника\n\t   напишите координаты поля, к примеру: {numberForExample1.Next(11)} {numberForExample2.Next(11)}\n\tУчтите, что первым параметром задается горизонтальная\n\t     координата, а вторым ветрикальная\n");
            Console.WriteLine($"   Сейчас вы вводите координаты для корабля размером: {currentShipSize}");
            var a = 0;
            
            var av = new Player();
            Field.Field.Field.AddNewFieldTenOnTen(av);
            av.FillField(Field.Field.Field.GameField[av]);
            Field.Field.FieldDisplayer.ShowField(av);
        }
    }
}
