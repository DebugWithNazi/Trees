using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Graphs
{
    public class Graph
    {
        private Dictionary<int, List<int>> adjacancyList;
        public Graph()
        {
            adjacancyList = new Dictionary<int, List<int>>();
        }
        public void AddVertex(int vertex)
        {
            if (!adjacancyList.ContainsKey(vertex))
            {
                adjacancyList[vertex] = new List<int>();
            }
        }
        public void AddEdge(int vertex1, int vertex2)
        {
            AddVertex(vertex1);
            AddVertex(vertex2);
            adjacancyList[vertex1].Add(vertex2);
            adjacancyList[vertex2].Add(vertex1);
        }

        public void BFS(int startVertex)
        {
            HashSet<int> visited = new HashSet<int>();
            Queue<int> queue = new Queue<int>();
            visited.Add(startVertex);
            queue.Enqueue(startVertex);

            while (queue.Count > 0)
            {
                int vertex = queue.Dequeue();
                Console.Write(vertex + " ");
                foreach (var neighbor in adjacancyList[vertex])
                {
                    if (!visited.Contains(neighbor))
                    {
                        visited.Add(neighbor);
                        queue.Enqueue(neighbor);
                    }
                }
            }
        }
        public void DfS(int startVertex)
        {
            HashSet<int> visited = new HashSet<int>();
            DFSHelper(startVertex,visited);
            Console.WriteLine();
        }

        public void DFSHelper(int startVertex, HashSet<int> visited)
        {
            visited.Add(startVertex);
            Console.Write(startVertex + " ");
            foreach(var neighbor in adjacancyList[startVertex])
            {
                if (!visited.Contains(neighbor))
                {
                    DFSHelper(neighbor, visited);
                }
            }
        }
    }
}
