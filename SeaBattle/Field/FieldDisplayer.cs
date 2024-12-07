using System.Data;

namespace SeaBattle.Field.Field
{
    public class FieldDisplayer : IFieldDisplayer
    {
        
        public static void ShowField(IPlayer player)
        {
            DataTable dataTable = new DataTable();
            var index = 1;
            Console.Clear();

            Console.WriteLine("\n\n");
            Console.Write(" \t  ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($" {i + 1}" + "  ");
            }
            Console.WriteLine("\n\t");
            for (int i = 0; i < 10; i++)
            {
    
            }
            Console.WriteLine("\n");
            foreach (var row in Field.GameField[player])
            {
                Console.Write($"{index}\t");
                foreach (var column in row)
                {
                    Console.Write(" | " + column.ToString());
                }
                Console.WriteLine(" | \n");
                index++;
            }
            Console.WriteLine("\n");
            Program.shipCount++;
            if (Program.shipCount == 5) Program.currentShipSize++;
            if (Program.shipCount == 8) Program.currentShipSize++;
            if(Program.shipCount == 10) Program.currentShipSize++;

            Console.WriteLine($"Сейчас вы вводите координаты для корабля размером: {Program.currentShipSize}");
        }
        public void HideField()
        {
            //берем с словаря по нулевому индексу значение(пустая карта) и выводим этот лист листов обычным циклом

            throw new NotImplementedException();
        }
    }
}
