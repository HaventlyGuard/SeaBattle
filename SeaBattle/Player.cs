namespace SeaBattle
{
    public class Player : IPlayer
    {
        public int Id { get; set; }
        public IEnumerable<IShip> Ships { get; set; }

        public Player() : this(0) { }
        public Player(int Id)
        {
            this.Id = Id;
            Ships = GetShips();
        }
        public IEnumerable<IEnumerable<ICell>> AttackOpponent(IEnumerable<IEnumerable<ICell>> field)
        {
            return field;
        }


        public IEnumerable<IEnumerable<ICell>> FillField(IEnumerable<IEnumerable<ICell>> field)
        {
            var enumeratorForShips = Ships.GetEnumerator();
            while (enumeratorForShips.MoveNext())
            {
                MoveShips(enumeratorForShips.Current);
                //Console.WriteLine(Console.ReadKey());

            }
            return field;
        }
        private void MoveShips(IShip ship)
        {
            var pressedKeyInfo = new ConsoleKeyInfo();
            while (pressedKeyInfo.Key != ConsoleKey.Enter)
            {
                pressedKeyInfo = Console.ReadKey();
                switch (pressedKeyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        TryMoveShipTo(ship, new Point(ship.ShipHead.X - 1, ship.ShipHead.Y));
                        //Console.WriteLine("up");
                        break;
                    case ConsoleKey.LeftArrow:
                        TryMoveShipTo(ship, new Point(ship.ShipHead.X, ship.ShipHead.Y - 1));
                        //Console.WriteLine("left");
                        break;
                    case ConsoleKey.DownArrow:
                        TryMoveShipTo(ship, new Point(ship.ShipHead.X + 1, ship.ShipHead.Y));
                        //Console.WriteLine("down");
                        break;
                    case ConsoleKey.RightArrow:
                        TryMoveShipTo(ship, new Point(ship.ShipHead.X, ship.ShipHead.Y + 1));
                        //Console.WriteLine("right");
                        break;
                    default:
                        break;

                }
            }
        }
        private void PutShipToField(IShip ship)
        {
            for (var i = 0; i < ship.Size; i++)
            {
                if (ship.IsHorizontal)
                    Field.Field.Field.GameField[this][ship.ShipHead.X][ship.ShipHead.Y + i].PlaceShipToCell();
                else
                    Field.Field.Field.GameField[this][ship.ShipHead.X + i][ship.ShipHead.Y].PlaceShipToCell();
            }
        }
        private void TakeShipFromField(IShip ship)
        {
            for (var i = 0; i < ship.Size; i++)
            {
                if (ship.IsHorizontal)
                    Field.Field.Field.GameField[this][ship.ShipHead.X][ship.ShipHead.Y + i].TakeShipFromCell();
                else
                    Field.Field.Field.GameField[this][ship.ShipHead.X + i][ship.ShipHead.Y].TakeShipFromCell();
            }
        }
        private void TryMoveShipTo(IShip ship, Point point)
        {
            if (point.Y < 0 || point.X < 0 ||
                (ship.IsHorizontal && (point.Y + ship.Size > Field.Field.Field.Size || point.X >= Field.Field.Field.Size)) ||
                (!ship.IsHorizontal && (point.X + ship.Size > Field.Field.Field.Size || point.Y >= Field.Field.Field.Size)))
            {
                return;
            }
            TakeShipFromField(ship);
            ship.ShipHead = point;
            PutShipToField(ship);
            Field.Field.FieldDisplayer.ShowField(this);
        }

        private IEnumerable<IShip> GetShips()
        {
            return new List<Ship>() {
                new Ship(1), new Ship(1), new Ship(1), new Ship(1),
                new Ship(2), new Ship(2), new Ship(2),
                new Ship(3), new Ship(3),
                new Ship(4),
            };
        }
    }
}
