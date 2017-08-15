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
            public int MinX { get; set; }
            public int MaxX { get; set; }
            public int MinY { get; set; }
            public int MaxY { get; set; }
            Random random = new Random();

            public GamePiece(string name, string color)
            {
                PositionX = 0;
                PositionY = 0;
                MinX = 0;
                MaxX = 100;
                MinY = 0;
                MaxY = 500;
                Frozen = false;
                Name = name;
                Color = color;
            }

            public void Move()
            {
                if (Frozen == true)
                {
                    Console.WriteLine($"{Color} {Name} is frozen and cannot move.");
                } else {
                    PositionX = random.Next(0,100);
                    PositionY = random.Next(0,500);
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
            
            Console.WriteLine(Piece);

            Piece.Move();
            Console.WriteLine(Piece);

            Piece.Freeze();
            Piece.Move();
            Console.WriteLine(Piece);

            Piece.Unfreeze();
            Piece.Move();
            Console.WriteLine(Piece);
        }
    }
}
