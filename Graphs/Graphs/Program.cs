using Graphs;

Graph graph = new Graph();
graph.AddEdge(0, 1);
graph.AddEdge(0, 2);
graph.AddEdge(1, 3);
graph.AddEdge(1, 4);
graph.AddEdge(2, 5);
graph.AddEdge(2, 6);

graph.DfS(0);