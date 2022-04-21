public class PascalTriange {
    public int[][] Triangle {get;set;}
    public PascalTriange(int rowsNumber)
    {
        Triangle = Generate(rowsNumber);
    }
    public int[][] Generate(int rows) 
    {
        var triangle = new int[rows][]; // Triangle contains ArrayList[][]
        int value;

        for (int i = 0; i < triangle.Length; i++) // loop for rows
        {
            triangle[i] = new int[i+1]; 

            for (int j = 0; j < triangle[i].Length; j++) // loop for columns
            {
                //  If not first or last element:  
               if (j > 0 && j < triangle[i].Length -1) // j is not first [> 0] and j is not last element [< array.length] 
               {
                   triangle[i][j] = triangle[i - 1][j - 1] + triangle[i -1][j]; // set current position [i][j] to be sum of prev row element
               }
               else // If first or last element:  
               {
                   triangle[i][j] = 1;
               }
            }
        }
        return triangle;
    }
    public void PrintTriangle() 
    {
        for (int i = 0; i < this.Triangle.Length; i++) // Print triangle 
        {
            for (int s = this.Triangle[i].Length -1; s == 0 ; s--) // Loop for spaces
            {
                System.Console.Write(" ");
            }
            for (int j = 0; j < this.Triangle[i].Length; j++) // Loop for printing each column in each rows 
            {
                System.Console.Write($"[{Triangle[i][j]}]");
            }
            System.Console.WriteLine( );
        }
    }










    public void FirstSolution () {
        int n = 6, row, col, space, value = 1;

        for (row = 0; row < n; row++) // loop for rows 
        {
            for (space = 1; space <= (n - row); space++) // Loops for spacing 
            {
                Console.Write(" ");
            }
            for (col = 0; col < row; col++) // loop for columns
            {
                if (col == 0 || col == row) // Check if is first or last
                {
                    value = 1;
                }
                else
                {
                    value = value * (row-col+1)/col;
                    
                }
                Console.Write($"{value}");


            }
            System.Console.WriteLine();
        }

    }
    
}