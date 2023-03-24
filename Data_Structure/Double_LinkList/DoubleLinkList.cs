namespace DataStructure
{
    public class DoubleNode{
        public int Data;
        public DoubleNode Prev;
        public DoubleNode Next;
        public DoubleNode(int value){
            this.Data = value;
            this.Prev = null;
            this.Next = null;
        }
    }

    class MyDoubleLinkList{
        private DoubleNode head;
        public DoubleNode Head{get{return head;}}

        public void Push(int newValue){
            DoubleNode newNode = new DoubleNode(newValue);
            newNode.Next = head;
            if(head!=null)
                head.Prev = newNode;
            head = newNode;
        }

        public void Insert(DoubleNode prevNode,int newValue){
            if(prevNode==null)
                Console.WriteLine("The Node is null");
            DoubleNode newNode = new DoubleNode(newValue);
            newNode.Next = prevNode.Next;
            newNode.Prev = prevNode;
            prevNode.Next = newNode;

            if(newNode.Next!=null)
                newNode.Next.Prev = newNode;
        }

        public void Append(int newValue){
            DoubleNode newNode = new DoubleNode(newValue);
            if(head ==null){
                head = newNode;
                return;
            }
            DoubleNode last = head;
            
            while(last.Next!=null){
                last = last.Next;
            }
            last.Next = newNode;
            newNode.Prev = last;
        }

        public void DeleteNode(DoubleNode targetNode){
            if(targetNode==null||head ==null)
                return;

            if(head==targetNode){
                head = targetNode.Next;
            }

            if(targetNode.Next!=null){
                targetNode.Next.Prev = targetNode.Prev;
            }

            if(targetNode.Prev!=null){
                targetNode.Prev.Next = targetNode.Next;
            }
        }

        public void PrintList(){
            DoubleNode temp = head;
            while(temp!=null){
                Console.Write(temp.Data + " ");
                temp = temp.Next;
            }
            Console.WriteLine();
        }
    }
}