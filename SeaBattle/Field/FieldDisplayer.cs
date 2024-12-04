namespace SeaBattle.Field.Field
{
    public class FieldDisplayer : IFieldDisplayer
    {
        public static void ShowField(IPlayer player)
        {
            var index = 1;
            Console.Clear();
            Console.Write("\t");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i + 1 + "  ");
            }
            Console.WriteLine("\n");
            foreach (var row in Field.GameField[player])
            {
                Console.Write(index + "\t");
                foreach (var column in row)
                {
                    Console.Write(column + "  ");
                }
                index++;
                Console.WriteLine();
            }
        }
        public void HideField()
        {
            //берем с словаря по нулевому индексу значение(пустая карта) и выводим этот лист листов обычным циклом

            throw new NotImplementedException();
        }
    }
}
