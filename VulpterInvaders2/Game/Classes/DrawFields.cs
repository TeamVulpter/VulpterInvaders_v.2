namespace Game.Classes
{
    using System;
    using Interfaces;
    class DrawFields : IMap
    {
        public void DrawField(int[,] matrix)
        {
            Random randomWidthGenerator = new Random();
            Random randomValue = new Random();
            Random randomDigit = new Random();
            Random randomLifeChance = new Random();
            int chance = randomLifeChance.Next(1, 100);

            //exit
            matrix[1, 1] = 8;

            int height = matrix.GetLength(0);
            int width = matrix.GetLength(1);

            //draw matrix borders
            for (int brick = 0; brick < height; brick++)
            {
                matrix[brick, 0] = 1;
                matrix[0, brick] = 1;
                matrix[height - 1, brick] = 1;
                matrix[brick, height - 1] = 1;
            }
            
            //draw matrix grid
            for (int row = 5; row < height - 5; row += 5)
            {
                for (int col = 0; col < width; col++)
                {
                    matrix[row, col] = 1;
                }
            }
            
            //draw doors
            for (int row = 1; row < height - 1; row++)
            {
                int randomHole = randomValue.Next(1, width - 1);
                if (matrix[row, randomHole] == 1)
                {
                    if (matrix[row, randomHole] != 8)
                    {
                        matrix[row, randomHole] = 0;
                    }
                }
            }

            //draw digits
            for (int row = 1; row < height - 1; row++)
            {
                int randomCol = randomWidthGenerator.Next(1, width - 1);
                int random = randomDigit.Next(3, 9);
                if (matrix[row, randomCol] == 0)
                {
                    matrix[row, randomCol] = random;
                }
            }

            for (int row = 0; row < height; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    if (matrix[row, col] == 1)
                    {
                        //Visualization.PrintCharMatrixAtPosition(row, col, '#', ConsoleColor.White);
                    }

                    else if (matrix[row, col] >= 3 && matrix[row, col] <= 6)
                    {
                        //Visualization.PrintCharMatrixAtPosition(row, col, (char)(matrix[row, col] + 48), ConsoleColor.Blue);
                    }
                    else if (matrix[row, col] == 7 && chance > 20)
                    {
                        //Visualization.PrintCharMatrixAtPosition(row, col, '\u2665', ConsoleColor.Red);
                    }
                    else if (matrix[row, col] == 8)
                    {
                        //Visualization.PrintCharMatrixAtPosition(row, col, '\u0065', ConsoleColor.Green);
                    }
                    else
                    {
                        //Console.Write(" ");
                    }
                }
                //Console.WriteLine();
            }
        }
    }
}
