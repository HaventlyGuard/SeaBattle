namespace SeaBattle
{
    public class Ship : IShip
    {
        public int Size { get; set; }
        public bool IsHorizontal { get; set; }
        public Point ShipHead { get; set; }

        public Ship(int Size)
        {
            this.Size = Size;
            IsHorizontal = false;
            ShipHead = new Point();
        }

    }
}
//00000000000000
//00000000000000
//00000000000000
//00000000000000
//00000000000000
//00000000000000
//00000000000000

