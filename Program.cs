using System;

namespace GamePiece
{
    class Program
    {
        public class GamePiece
        {
            public int PositionX { get; set; }
            public int PositionY { get; set; }
            public bool Frozen { get; set; }
            public string Name { get; set; }
            public string Color { get; set; }

            public GamePiece(string name, string color)
            {
                PositionX = 0;
                PositionY = 0;
                Frozen = false;
                Name = name;
                Color = color;
            }

            public void Move(int posX, int posY)
            {
                if (Frozen == true)
                {
                    Console.WriteLine($"{Color} {Name} is frozen and cannot move.");
                } else {
                    PositionX = posX;
                    PositionY = posY;
                }
            }

            public void Freeze()
            {
                Frozen = true;
                Console.WriteLine($"Freezing {Color} {Name}.");
            }

            public void Unfreeze()
            {
                Frozen = false;
                Console.WriteLine($"Unfreezing {Color} {Name}.");
            }

            public override string ToString()
            {
                return $"{Color} {Name} is currently at ({PositionX},{PositionY}).";
            }

        }
        static void Main(string[] args)
        {
            var Piece = new GamePiece("Rook", "Black");
            
            Piece.Move(12,12);
            Console.WriteLine(Piece);

            Piece.Freeze();

            Console.WriteLine(Piece);
            
            Piece.Move(13,13);
            Console.WriteLine(Piece);
            
            Piece.Unfreeze();
            Piece.Move(14,14);
            Console.WriteLine(Piece);
        }
    }
}
