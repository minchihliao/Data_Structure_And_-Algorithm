namespace Algorithm
{
    public class BinaryHeap
    {
        private int[] heap;
        private int size;

        public BinaryHeap(int capacity)
        {
            this.heap = new int[capacity + 1];
            this.size = 0;
        }

        //Insert
        public void Insert(int val)
        {
            if (size == heap.Length - 1)
                throw new InvalidOperationException("Heap is full");
            size++;
            heap[size] = val;
            bubbleUp(size);
        }

        private void bubbleUp(int index)
        {
            int parent = index / 2;
            if (parent == 0) return;
            if (heap[index] < heap[parent])
            {
                swap(index, parent);
                bubbleUp(parent);
            }
        }

        private void swap(int index1, int index2)
        {
            int temp = heap[index1];
            heap[index1] = heap[index2];
            heap[index2] = temp;
        }

        //Remove
        public int Remove()
        {
            if (size == 0)
                throw new InvalidOperationException("Heap is empty");

            int value = heap[1];
            heap[1] = heap[size];
            size--;
            bubbleDown(1);
            return value;
        }

        private void bubbleDown(int index)
        {
            int left = index * 2;
            int right = index * 2 + 1;
            if (left > size) return;
            int minChild = left;
            if (right <= size && heap[right] < heap[left])
            {
                minChild = right;
            }

            if (heap[index] > heap[minChild])
            {
                swap(index, minChild);
                bubbleDown(minChild);
            }
        }


    }


}