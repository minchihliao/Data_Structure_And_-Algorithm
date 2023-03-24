namespace DataStructure
{
    public class MyStack_Array
    {
        private int[] arr;
        private int top;

        public MyStack_Array(int size)
        {
            arr = new int[size];
            top = -1;
        }

        private Boolean isEmpty()
        {
            return top == -1;
        }

        private Boolean isFull()
        {
            return top >= arr.Length;
        }

        public void Push(int value)
        {
            if (isFull())
            {
                throw new StackOverflowException();
            }
            arr[++top] = value;
        }

        public int Pop()
        {
            if (isEmpty())
            {
                throw new InvalidOperationException();
            }

            return arr[top--];
        }

        public int Peek()
        {
            if (isEmpty())
            {
                throw new InvalidOperationException();
            }

            return arr[top];
        }
    }

    public class MyStack_LinkList
    {
        public class StakcNode
        {
            public int Value;
            public StakcNode Next;
            public StakcNode(int val)
            {
                this.Value = val;
                this.Next = null;
            }
        }

        private StakcNode head;
        public StakcNode StackHead { get { return head; } }
        public void Push(int val)
        {
            StakcNode newNode = new StakcNode(val);
            if (head == null)
            {
                head = newNode;
                return;
            }

            newNode.Next = head;
            head = newNode;
        }

        public int Pop()
        {
            if (head == null)
            {
                new InvalidOperationException();
            }
            int resule = head.Value;
            head = head.Next;
            return resule;
        }

        public int Peek()
        {
            if (head == null)
            {
                new InvalidOperationException();
            }
            return head.Value;
        }
    }
}