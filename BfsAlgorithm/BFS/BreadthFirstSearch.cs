namespace BfsAlgorithm.BFS
{
    public class BreadthFirstSearch 
    {
        private Vertex[] adjacentList;
     
        public BreadthFirstSearch(int s)
        {
            adjacentList = new Vertex[s];
            for (int i = 0; i < adjacentList.Length; i++)
                adjacentList[i] = new Vertex(i);
        }

        public void BFS(int source) 
        {
            Queue<Vertex> queue = new Queue<Vertex>();  
            Vertex s = adjacentList[source];           
            for (int i = 0; i < adjacentList.Length; i++)
            {
                Vertex u = adjacentList[i];

                if (u.vertex!= source)
                {
                    u.color = 'W';
                    u.d = Int32.MaxValue; 
                    u.p = null;
                }
            }
            s.color = 'G';
            s.d = 0;
            s.p = null;
            queue.Enqueue(s); 
            while (queue.Count > 0)
            {
                Vertex u = queue.Dequeue(); 
                Vertex v = u.next;               
                while (v != null) 
                {
                    Vertex actualV = adjacentList[v.vertex];

                    if (actualV.color == 'W') 
                    {
                        actualV.color = 'G'; 
                        actualV.d = u.d + 1; 
                        actualV.p = u; 
                        queue.Enqueue(actualV); 
                    }
                    v = v.next; 
                }
                u.color = 'B';
            }
        }

        public void AddVertex(int u, int v)
        {
            Vertex uTmp = adjacentList[u];
            while (uTmp.next != null)
                uTmp = uTmp.next;
            
            uTmp.next = new Vertex(v); 

            Vertex vTmp = adjacentList[v];
            while (vTmp.next != null)
                vTmp = vTmp.next;
                
            vTmp.next = new Vertex(u); 
        }

        private void Print(Vertex u, Vertex v)
        {
            if (u == v)
                Console.Write(u.vertex + " ");
            else if (v.p == null)
                Console.Write("Unreachable path from u to v");
            else
            {
                Print(u, v.p);
                Console.Write(v.vertex + " ");
            }
        }

        public void PathVertex(int u, int v)
        {
            BFS(u);
            Console.Write("Distance (smallest number of edges) from ("+u + ") to (" + v + ") is: ");
            Print(adjacentList[u], adjacentList[v]); 
        }
    }
}
