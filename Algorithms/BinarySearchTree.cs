namespace Algorithm
{
    public class BinarySearchTreeNode
    {
        public int data;
        public BinarySearchTreeNode left;
        public BinarySearchTreeNode right;

        public BinarySearchTreeNode(int val)
        {
            this.data = val;
            this.left = null;
            this.right = null;
        }
    }

    public class BinarySearchTree
    {
        private BinarySearchTreeNode root;

        public BinarySearchTree()
        {
            root = null;
        }

        public void Insert(int val)
        {
            root = Insert(root, val);
        }

        private BinarySearchTreeNode Insert(BinarySearchTreeNode node, int data)
        {
            if (node == null) return new BinarySearchTreeNode(data);

            if (data <= node.data)
            {
                node.left = Insert(node.left, data);
            }
            else
            {
                node.right = Insert(node.right, data);
            }
            return node;
        }

        //InOrder

        public void InOrder()
        {
            InOrder(root);
            Console.WriteLine();
        }
        private void InOrder(BinarySearchTreeNode node)
        {
            if (node != null)
            {
                InOrder(node.left);
                Console.Write("{0} ", node.data);
                InOrder(node.right);
            }
        }

    }

}