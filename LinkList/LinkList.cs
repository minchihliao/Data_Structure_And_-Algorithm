namespace DataStructure
{
    class Node{
        public int data;
        public Node next;
        public Node(int value){
            this.data = value;
            this.next = null;
        }
    }

    class MyLinkList{
        private Node head;
        public Node Head {get{return head;}}

        public void Push(int newValue){
            Node newHead = new Node(newValue);
            newHead.next = head;
            head = newHead;
        }

        public void Insert(Node prevNode,int newValue){
            if(prevNode ==null){
                Console.WriteLine("The given previous node"
                          + " cannot be null");
                return;
            }
            Node newNode = new Node(newValue);
            newNode.next = prevNode.next;
            prevNode.next = newNode;
        }

        public void Append(int newValue){
            Node newLast = new Node(newValue);
            if (head ==null)
                head = newLast;
            Node last = head;
            while(last.next!=null){
                last = last.next;
            }
            last.next = newLast;
        }

        public void DeleteNode(int value){

            Node temp = head;
            Node prev = null;
            
            if( temp !=null && head.data == value){
                head = head.next;
                return;
            }

            while (temp !=null && temp.data !=value){
                prev = temp;
                temp = temp.next;
            }

            if(temp==null)
                return;

            prev.next = temp.next;
        }

        public void PrintList(){
            Node temp = head;
            while(temp!=null){
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
    }
}