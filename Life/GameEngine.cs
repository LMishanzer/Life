using System;

namespace Life
{
    class GameEngine
    {
        private readonly int tenuity;
        private bool[,] field;

        public int Resolution { get; }
        public int Cols { get; }
        public int Rows { get; }

        public bool[,] GetField
        {
            get
            {
                var newField = new bool[Rows, Cols];

                for (int i = 0; i < Rows; i++)
                {
                    for (int j = 0; j < Cols; j++)
                    {
                        newField[i, j] = field[i, j];
                    }
                }

                return newField;
            }
        }

        public GameEngine(int width, int height, int resolution, int tenuity)
        {
            Cols = width / resolution;
            Rows = height / resolution;
            Resolution = resolution;
            this.tenuity = tenuity;
        }

        public void StartGame()
        {
            var random = new Random();
            field = new bool[Rows, Cols];

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    field[i, j] = random.Next(tenuity) == 0;
                }
            }
        }

        public void NextGeneration()
        {
            var newField = new bool[Rows, Cols];

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    var neighborsCount = CountNeighbors(i, j);

                    if (field[i, j] && (neighborsCount < 2 || neighborsCount > 3))
                    {
                        newField[i, j] = false;
                    }
                    else if (!field[i, j] && neighborsCount == 3)
                    {
                        newField[i, j] = true;
                    }
                    else
                    {
                        newField[i, j] = field[i, j];
                    }
                }
            }

            field = newField;
        }

        private int CountNeighbors(int row, int col)
        {
            int counter = 0;

            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    if (i == 0 && j == 0)
                        continue;

                    int currentRow = (row + i + Rows) % Rows;
                    int currentCol = (col + j + Cols) % Cols;

                    if (field[currentRow, currentCol])
                        counter++;
                }
            }

            return counter;
        }

        public void AddCell(int row, int col)
        {
            field[row, col] = true;
        }

        public void RemoveCell(int row, int col)
        {
            field[row, col] = false;
        }
    }
}
