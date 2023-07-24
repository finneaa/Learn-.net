public class Maze
{
    public int[][] myMaze;
    int size = 0;

    private int[][] createMaze(int mysize){
        int[][] tempmaze = new int[mysize][];
        for (int i = 0; i < tempmaze.Length; i++){
            tempmaze[i] = new int[mysize];
        }
        return tempmaze;
    }

    public Maze(int size)
    {
        this.size = size;
        myMaze = createMaze(size);
    }
}