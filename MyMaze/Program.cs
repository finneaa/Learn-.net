// See https://aka.ms/new-console-template for more information
class Program
{
    
    static void Main()
    {
        Maze smallMaze = new Maze(7);

        
        // Display the array elements.
        for (int i = 0; i < smallMaze.myMaze.Length; i++)
        {
            for (int j = 0; j < smallMaze.myMaze[i].Length; j++)
            {
                System.Console.Write("{0}{1}", smallMaze.myMaze[i][j], j == (smallMaze.myMaze[i].Length - 1) ? "" : " ");
            }
            System.Console.WriteLine();
        }
    }
}