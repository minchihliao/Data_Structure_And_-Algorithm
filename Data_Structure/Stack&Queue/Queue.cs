namespace DataStructure
{
    public class MyQueue_Array
    {
        private int[] arr;
        private int front, rear;
        private int size;


        public MyQueue_Array(int size)
        {
            arr = new int[size];
            front = 0;
            rear = -1;
            size = 0;
        }

        private Boolean isFull()
        {
            return size == arr.Length;
        }

        private Boolean isEmpty()
        {
            return size == 0;
        }
        public void Enqueue(int val)
        {
            if (isFull())
            {
                new StackOverflowException();
            }

            rear = (rear + 1) % arr.Length;
            arr[rear] = val;
            size++;
        }

        public int Dequeue()
        {
            if (isEmpty())
            {
                new InvalidOperationException();
            }

            int resule = arr[front];
            front = (front + 1) % arr.Length;
            size--;

            return resule;
        }

        public int Peek()
        {
            if (isEmpty())
            {
                new InvalidOperationException();
            }
            return arr[front];
        }
    }

    public class MyQueue_LinkList
    {
        public class QueueNode
        {
            public int Data;
            public QueueNode Next;
            public QueueNode(int val)
            {
                this.Data = val;
                this.Next = null;
            }
        }

        private QueueNode head;
        public QueueNode Head { get { return head; } }

        public MyQueue_LinkList()
        {
            head = null;
        }
        public void Enqueue(int val)
        {
            QueueNode newNode = new QueueNode(val);
            if (head == null)
            {
                head = newNode;
                return;
            }
            QueueNode temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = newNode;
        }

        public int Dequeue()
        {
            if (head == null)
                new InvalidOperationException();

            int resule = head.Data;
            head = head.Next;

            return resule;
        }

        public int Peek()
        {
            if (head == null)
                new InvalidOperationException();

            return head.Data;
        }
    }


}