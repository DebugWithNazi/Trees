
namespace Heap
{
    public class MinHeap
    {
        private List<int> heap;
        public MinHeap()
        {
            heap = new List<int>();
        }

        public void Add(int x)
        {
            heap.Add(x);
            HeapifyUp(heap.Count - 1);
        }
        public void HeapifyUp(int index)
        {
            while (index > 0)
            {
                int parentIndex = (index - 1) / 2;
                if (heap[index] >= heap[parentIndex])
                {
                    break;
                }
                swap(index, parentIndex);
                index = parentIndex;
            }
        }

        public void swap(int x, int y)
        {
            int temp = heap[x];
            heap[x] = heap[y];
            heap[y] = temp;
        }

        public int Peek()
        {
            if (heap.Count == 0)
            {
                throw new InvalidOperationException("Heap is empty");
            }

            return heap[0];
        }

        public int Remove()
        {
            if (heap.Count == 0)
            {
                throw new InvalidOperationException("Heap is empty!");
            }
            int min = heap[0];
            heap[0] = heap[heap.Count - 1];
            heap.RemoveAt(heap.Count - 1);
            HeapifyDown(0);
            return min;
        }
        public void HeapifyDown(int index)
        {
            while (index < heap.Count)
            {
                int leftChild = 2 * index + 1;
                int rightchild = 2 * index + 2;
                int smallest = index;

                if (leftChild < heap.Count && heap[leftChild] < heap[index])
                {
                    smallest = leftChild;
                }
                else if (rightchild < heap.Count && heap[rightchild] < heap[index])
                {
                    smallest = rightchild;
                }
                if(smallest == index)
                {
                    break;
                }
                swap(index, smallest);
                index = smallest;
            }
        }
        public void Print()
        {
            for (int i = 0; i < heap.Count; i++)
            {
                Console.WriteLine(heap[i] + " ");
            }
        }
    }
}
