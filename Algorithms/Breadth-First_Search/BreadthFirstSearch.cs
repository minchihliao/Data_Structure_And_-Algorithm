namespace Algorithm
{
    public class BreathFirstSearch
    {
        public class Node
        {
            public int Data;
            public List<Node> Children;

            public Node(int val)
            {
                this.Data = val;
                this.Children = new List<Node>();
            }

            public void AddChildrenNode(Node childNode)
            {
                this.Children.Add(childNode);
            }
        }


        public Node CreateNode(int val)
        {
            return new Node(val);
        }



        public void Excute(Node start)
        {

            Queue<Node> queue = new Queue<Node>();
            HashSet<Node> visted = new HashSet<Node>();
            queue.Enqueue(start);
            visted.Add(start);

            while (queue.Count > 0)
            {
                Node currNode = queue.Dequeue();
                Console.WriteLine(currNode.Data + " ");
                foreach (var childNode in currNode.Children)
                {
                    if (!visted.Contains(childNode))
                    {
                        //Console.WriteLine("");
                        visted.Add(childNode);
                        queue.Enqueue(childNode);

                    }
                }
            }
        }


    }

}