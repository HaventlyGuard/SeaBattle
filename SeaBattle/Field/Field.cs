namespace SeaBattle.Field.Field
{
    public class Field : IField
    {
        public static Dictionary<IPlayer?, List<List<ICell>>> GameField { get; set; }

        static Field()
        {
            GameField = [];
            AddNewFieldTenOnTen(new Player());
        }
        public Field()
        {

        }
        public static void AddNewFieldTenOnTen(IPlayer? player)
        {
            GameField[player] =
                Enumerable.Repeat(new List<ICell>(Enumerable.Repeat(new Cell(), 10)), 10).ToList();
        }
    }
}
