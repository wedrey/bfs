namespace BfsAlgorithm.BFS
{
    public class Vertex
    {
        public int vertex { get; set; } //vertex number
        public Vertex next { get; set; }  //reachable vertex
        public char color { get; set; }
        public int d { get; set; }
        public Vertex p { get; set; }
        public Vertex(int val)
        {
            vertex = val;
            d = Int32.MaxValue;
            color = 'W';
        }
    }
}
    