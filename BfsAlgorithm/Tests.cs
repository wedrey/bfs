using BfsAlgorithm.BFS;

namespace BfsAlgorithm
{
    public class Tests
    {
       
        public static void Search()
        {
            BreadthFirstSearch bfs = new BreadthFirstSearch(6);
            bfs.AddVertex(1, 2);
            bfs.AddVertex(1, 5);

            bfs.AddVertex(2, 1);
            bfs.AddVertex(2, 5);
            bfs.AddVertex(2, 3);
            bfs.AddVertex(2, 4);

            bfs.AddVertex(3, 2);
            bfs.AddVertex(3, 4);

            bfs.AddVertex(4, 2);
            bfs.AddVertex(4, 5);
            bfs.AddVertex(4, 3);

            bfs.AddVertex(5, 4);
            bfs.AddVertex(5, 1);
            bfs.AddVertex(5, 2);

            bfs.PathVertex(1, 4);
        }
    }
}

