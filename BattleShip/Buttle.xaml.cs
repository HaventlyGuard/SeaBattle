using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace BattleShip
{
    public partial class Buttle : Window
    {
        private int shipLength = 2; // Количество палуб (по умолчанию)
        private List<Rectangle> highlightedCells = new List<Rectangle>();
        private bool isVertical = false; // Положение корабля: вертикальное или горизонтальное

        public Buttle()
        {
            InitializeComponent();
            CreateGrid();
            this.KeyDown += Buttle_KeyDown;
        }


        

        private void Buttle_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.H)
            {
                RotateShip();
            }
            else if (e.Key == Key.Left)
            {
                MoveShip(-1, 0);
            }
            else if (e.Key == Key.Right)
            {
                MoveShip(1, 0);
            }
            else if (e.Key == Key.Up)
            {
                MoveShip(0, -1);
            }
            else if (e.Key == Key.Down)
            {
                MoveShip(0, 1);
            }
        }

        private void CreateGrid()
        {
            double cellSize = 50;
            for (int row = 0; row < 4; row++)
            {
                for (int column = 0; column < 4; column++)
                {
                    Rectangle cell = new Rectangle
                    {
                        Stroke = Brushes.Black,
                        Width = cellSize,
                        Height = cellSize,
                        Fill = Brushes.White
                    };
                    Canvas.SetLeft(cell, 115 + column * cellSize);
                    Canvas.SetTop(cell, 171 + row * cellSize);
                    MainCanvas.Children.Add(cell);
                }
            }
        }

        private void CheckShipPosition(Image shipImage)
        {
            double cellSize = 50;
            double fieldLeft = 105;
            double fieldTop = 151;

            double x = Canvas.GetLeft(shipImage);
            double y = Canvas.GetTop(shipImage);

            int column = (int)((x - fieldLeft) / cellSize);
            int row = (int)((y - fieldTop) / cellSize);

            ClearHighlightedCells();

            if (isVertical)
            {
                // Проверка, помещается ли корабль вертикально
                if (row < 0 || row + shipLength > 4 || column < 0) return;

                // Дополнительная проверка для последней строки
                if (row + shipLength - 1 >= 4) return;

                for (int i = 0; i < shipLength; i++)
                {
                    Rectangle cell = GetRectangleAt(row + i, column, isVertical);
                    if (cell != null)
                    {
                        cell.Fill = Brushes.Blue;
                        highlightedCells.Add(cell);
                    }
                }
            }
            else
            {
                // Проверка, помещается ли корабль горизонтально
                if (column < 0 || column + shipLength > 4 || row < 0) return;

                // Дополнительная проверка для последнего столбца
                if (column + shipLength - 1 >= 4) return;

                for (int i = 0; i < shipLength; i++)
                {
                    Rectangle cell = GetRectangleAt(row, column + i, isVertical);
                    if (cell != null)
                    {
                        cell.Fill = Brushes.Blue;
                        highlightedCells.Add(cell);
                    }
                }
            }

            UpdateShipPosition(fieldLeft, fieldTop, shipImage, column, row);
        }





        private void UpdateShipPosition(double fieldLeft, double fieldTop, Image shipImage, int column, int row)
        {
            double newX;
            double newY;

            if (isVertical)
            {
                newX = fieldLeft + column * 50; // Для вертикального положения X фиксируется
                newY = fieldTop + row * 50; // Y устанавливается в верхней части клетки
            }
            else
            {
                newX = fieldLeft + column * 50; // X устанавливается в левом краю клетки
                newY = fieldTop + row * 50 + (50 - shipImage.Height) / 2; // Y центрируется по вертикали
            }

            Canvas.SetLeft(shipImage, newX);
            Canvas.SetTop(shipImage, newY);
        }



        private Rectangle GetRectangleAt(int row, int column, bool isVertical)
        {
            int totalColumns = 4;
            int index;

            if (isVertical)
            {
                index = column + row * totalColumns;
            }
            else
            {
                index = row * totalColumns + column;
            }

            if (index >= 0 && index < MainCanvas.Children.Count)
            {
                return MainCanvas.Children[index] as Rectangle;
            }

            return null;
        }

        private void ClearHighlightedCells()
        {
            foreach (var cell in highlightedCells)
            {
                cell.Fill = Brushes.White;
            }
            highlightedCells.Clear();
        }

        private void RotateShip()
        {
            isVertical = !isVertical;

            Image shipImage = Ship;

            if (isVertical)
            {
                shipImage.RenderTransform = new RotateTransform(90);
                shipImage.Width = 50; // Single deck width
                shipImage.Height = shipLength * 50; // Height based on ship length
            }
            else
            {
                shipImage.RenderTransform = new RotateTransform(0);
                shipImage.Width = shipLength * 50; // Width based on ship length
                shipImage.Height = 50; // Single deck height
            }

            CheckShipPosition(shipImage);
        }


        private void MoveShip(int deltaX, int deltaY)
        {
            Image shipImage = Ship;

            double currentX = Canvas.GetLeft(shipImage);
            double currentY = Canvas.GetTop(shipImage);

            double newX = currentX + deltaX * 50;
            double newY = currentY + deltaY * 50;

            // Определение границ игрового поля
            double fieldLeft = 105; // Левый край
            double fieldTop = 171; // Верхний край
            double gridWidth = 4 * 50; // Ширина поля
            double gridHeight = 4 * 50; // Высота поля

            if (isVertical)
            {
                // Проверка границ для вертикального положения
                if (newY < fieldTop || newY + shipLength * 50 > fieldTop + gridHeight ||
                    newX < fieldLeft || newX >= fieldLeft + gridWidth) return;

                // Проверка, чтобы весь корабль помещался
                int row = (int)((newY - fieldTop) / 50);
                if (row + shipLength > 4) return; // Если выходит за пределы по вертикали
            }
            else
            {
                // Проверка границ для горизонтального положения
                if (newX < fieldLeft || newX + shipLength * 50 > fieldLeft + gridWidth ||
                    newY < fieldTop || newY >= fieldTop + gridHeight) return;

                // Проверка, чтобы весь корабль помещался
                int column = (int)((newX - fieldLeft) / 50);
                if (column + shipLength > 4) return; // Если выходит за пределы по горизонтали
            }

            // Устанавливаем новую позицию, если все проверки пройдены
            Canvas.SetLeft(shipImage, newX);
            Canvas.SetTop(shipImage, newY);

            CheckShipPosition(shipImage);
        }











        #region Drag and Drop Logic

        private int countZ = 0;
        private bool _canMove = false;
        private Point _offsetPoint;

        private void FF_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (sender is FrameworkElement ffElement)
            {
                _canMove = true;
                countZ++;
                Grid.SetZIndex(ffElement, countZ);

                Point posCursor = e.GetPosition(this);
                _offsetPoint = new Point(
                    posCursor.X - Canvas.GetLeft(ffElement),
                    posCursor.Y - Canvas.GetTop(ffElement)
                );

                Mouse.Capture(ffElement);
            }
        }

        private void FF_MouseMove(object sender, MouseEventArgs e)
        {
            if (_canMove && sender is FrameworkElement ffElement)
            {
                if (Mouse.Captured == ffElement)
                {
                    Point p = e.GetPosition(MainCanvas);

                    double newX = p.X - _offsetPoint.X;
                    double newY = p.Y - _offsetPoint.Y;

                    // Проверка границ
                    double fieldLeft = 115; // Левый край
                    double fieldTop = 171; // Верхний край
                    double gridWidth = 4 * 50; // Ширина поля
                    double gridHeight = 4 * 50; // Высота поля

                    // Проверяем границы для вертикального положения
                    if (isVertical)
                    {
                        if (newY < fieldTop) newY = fieldTop;
                        if (newY + shipLength * 50 > fieldTop + gridHeight) newY = fieldTop + gridHeight - shipLength * 50;
                    }
                    else // Проверяем границы для горизонтального положения
                    {
                        if (newX < fieldLeft) newX = fieldLeft;
                        if (newX + shipLength * 50 > fieldLeft + gridWidth) newX = fieldLeft + gridWidth - shipLength * 50;
                    }

                    Canvas.SetLeft(ffElement, newX);
                    Canvas.SetTop(ffElement, newY);
                }
            }
        }



        private void FF_MouseUp(object sender, MouseButtonEventArgs e)
        {
            _canMove = false;
            e.MouseDevice.Capture(null);

            Image shipImage = sender as Image;
            if (shipImage != null)
            {
                CheckShipPosition(shipImage);
            }
        }

        private void FF_MouseLeave(object sender, MouseEventArgs e)
        {
            _canMove = false;
            Mouse.Capture(null);
        }

        #endregion

        private void RotateButton_Click(object sender, RoutedEventArgs e)
        {
            RotateShip();
        }
    }
}
