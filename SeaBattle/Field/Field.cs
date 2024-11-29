namespace SeaBattle.Field.Field
{
    public class Field : IField
    {
        public static Dictionary<IPlayer?, List<List<ICell>>> GameField { get; set; }
        public static int Size = 10;
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
            GameField[player] = Enumerable.
                Range(0, 10).
                Select(_ => Enumerable.Range(0, 10).Select(_ => (ICell)new Cell()).ToList()).
                ToList();
        }
    }
}
