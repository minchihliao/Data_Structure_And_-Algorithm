namespace DataStructure
{
    public class TreeNode
    {
        public int data;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int val)
        {
            this.data = val;
            this.left = null;
            this.right = null;
        }
    }

    public class BinaryTree
    {
        private TreeNode root;
        public TreeNode Root
        {
            get { return root; }
            set { root = value; }
        }
        public BinaryTree()
        {
            this.Root = null;
        }

        //Preorder
        public void PreOrder(TreeNode node)
        {
            if (node == null) return;
            Console.Write("{0} ", node.data);
            PreOrder(node.left);
            PreOrder(node.right);
        }

        //Inorder
        public void InOrder(TreeNode node)
        {
            if (node == null) return;
            InOrder(node.left);
            Console.Write("{0} ", node.data);
            InOrder(node.right);
        }

        //Postorder
        public void PostOrder(TreeNode node)
        {
            if (node == null) return;
            PostOrder(node.left);
            PostOrder(node.right);
            Console.Write("{0} ", node.data);
        }

    }
}