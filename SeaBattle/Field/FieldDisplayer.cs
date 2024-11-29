namespace SeaBattle.Field.Field
{
    public class FieldDisplayer : IFieldDisplayer
    {
        public void ShowField(IPlayer player)
        {
            foreach (var row in Field.GameField[player])
            {
                foreach (var column in row)
                {
                    Console.Write(column + " ");
                }
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
