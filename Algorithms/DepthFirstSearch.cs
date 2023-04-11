namespace Algorithm
{
    public class DepthFirstSearch
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
            if (start == null)
                throw new InvalidOperationException("Start Node is empty");
            Stack<Node> stack = new Stack<Node>();
            HashSet<Node> visted = new HashSet<Node>();
            stack.Push(start);
            visted.Add(start);
            while (stack.Count > 0)
            {
                Node currentNode = stack.Pop();
                Console.WriteLine(currentNode.Data + " ");
                foreach (var node in currentNode.Children)
                {
                    if (!visted.Contains(node))
                    {
                        stack.Push(node);
                        visted.Add(node);
                    }
                }

            }


        }
    }


}