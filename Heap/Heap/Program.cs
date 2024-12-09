using Heap;

MinHeap heap = new MinHeap();
heap.Add(10);
heap.Add(5);
heap.Add(20);
heap.Add(2);

heap.Print();
Console.WriteLine(heap.Remove());
heap.Print();