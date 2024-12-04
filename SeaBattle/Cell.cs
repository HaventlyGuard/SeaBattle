namespace SeaBattle
{
    public class Cell : ICell
    {
        public bool Fullness { get; set; }
        public int ShipsCount { get; set; }

        public void PlaceShipToCell()
        {
            ShipsCount++;
            Fullness = true;
        }
        public void TakeShipFromCell()
        {
            ShipsCount--;
            Fullness = ShipsCount > 0 ? true : false;
        }



        public override string ToString()
        {
            return Fullness ? "X" : "O";
        }
    }
}
