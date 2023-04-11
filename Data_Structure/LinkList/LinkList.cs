namespace DataStructure
{
    public class LinkedListNode
    {
        public int data;
        public LinkedListNode next;
        public LinkedListNode(int value)
        {
            this.data = value;
            this.next = null;
        }
    }

    class MyLinkList
    {
        private LinkedListNode head;
        public LinkedListNode Head { get { return head; } }

        public void Push(int newValue)
        {
            LinkedListNode newHead = new LinkedListNode(newValue);
            newHead.next = head;
            head = newHead;
        }

        public void Insert(LinkedListNode prevNode, int newValue)
        {
            if (prevNode == null)
            {
                Console.WriteLine("The given previous node"
                          + " cannot be null");
                return;
            }
            LinkedListNode newNode = new LinkedListNode(newValue);
            newNode.next = prevNode.next;
            prevNode.next = newNode;
        }

        public void Append(int newValue)
        {
            LinkedListNode newLast = new LinkedListNode(newValue);
            if (head == null)
                head = newLast;
            LinkedListNode last = head;
            while (last.next != null)
            {
                last = last.next;
            }
            last.next = newLast;
        }

        public void DeleteNode(int value)
        {

            LinkedListNode temp = head;
            LinkedListNode prev = null;

            if (temp != null && head.data == value)
            {
                head = head.next;
                return;
            }

            while (temp != null && temp.data != value)
            {
                prev = temp;
                temp = temp.next;
            }

            if (temp == null)
                return;

            prev.next = temp.next;
        }

        public void PrintList()
        {
            LinkedListNode temp = head;
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
    }
}