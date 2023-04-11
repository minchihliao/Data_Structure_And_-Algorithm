using Question;
using DataStructure;
using Algorithm;
namespace Test
{
    public class Test_Data_Structure
    {
        public void ArrayList()
        {
            ArrayList test = new ArrayList();
            test.Add(3.16);
            test.Add(5);
            test.Add("String");
            Console.WriteLine(test.Get(1));
            test.RemoveAt(1);
            Console.WriteLine(test.Get(1));
        }
        public void StringBuilder()
        {
            StringBuilder sb = new StringBuilder(50);
            sb.Append("ABC");
            sb.Append("CDF");
            Console.WriteLine(sb.Capacity);
            Console.WriteLine(sb.Length);
            Console.WriteLine(sb.ToString());
        }

        public void MyLinkList()
        {
            MyLinkList llist = new MyLinkList();
            llist.Push(7);
            llist.Push(1);
            llist.Push(3);
            llist.Push(2);
            llist.Push(8);

            Console.WriteLine("\nCreated Linked list is: ");
            llist.PrintList();

            llist.DeleteNode(2);
            Console.WriteLine("\nLinked List after "
                        + "Deletion 2: ");
            llist.PrintList();

            llist.Append(3);
            Console.WriteLine("\nLinked List after "
                        + "Append 3: ");
            llist.PrintList();

            llist.Insert(llist.Head.next, 9);
            Console.WriteLine("\nLinked List after "
                        + "Insert 9 at Position 2-3: ");
            llist.PrintList();
        }

        public void MyDoubleLinkList()
        {
            MyDoubleLinkList dll = new MyDoubleLinkList();

            // Insert 2. So linked list becomes 2->NULL
            dll.Push(2);

            // Insert 6. So linked list becomes 2->6->NULL
            dll.Append(6);

            // Insert 4. So linked list becomes 4->2->6->NULL
            dll.Push(4);

            // Insert 8. So linked list becomes 8->4->2->6->NULL
            dll.Push(8);

            // Insert 10. So linked list becomes 10->8->4->2->6->NULL
            dll.Push(10);

            // Insert 8, after 7. So linked list
            // becomes 10->8->8->4->2->6->NULL
            dll.Insert(dll.Head.Next, 8);

            Console.Write("Original Linked list ");
            dll.PrintList();

            // Deleting first node
            dll.DeleteNode(dll.Head);

            dll.DeleteNode(dll.Head.Next);

            dll.DeleteNode(dll.Head.Next);

            Console.Write("Modified Linked list ");
            dll.PrintList();
        }

        public void MyStack_Array()
        {
            MyStack_Array stack = new MyStack_Array(3);

            // 推入元素
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            // 彈出元素
            int x = stack.Pop();  // x = 3

            // 查看堆疊頂部元素
            int y = stack.Peek(); // y = 2

            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
        }
        public void MyStack_LinkList()
        {
            MyStack_LinkList stack = new MyStack_LinkList();

            // 推入元素
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            // 彈出元素
            int x = stack.Pop();  // x = 3

            // 查看堆疊頂部元素
            int y = stack.Peek(); // y = 2

            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
        }

        public void MyQueue_Array()
        {
            MyQueue_Array Queue = new MyQueue_Array(3);

            // 推入元素
            Queue.Enqueue(1);
            Queue.Enqueue(2);
            Queue.Enqueue(3);

            // 彈出元素
            int x = Queue.Dequeue();  // x = 1

            // 查看堆疊頂部元素
            int y = Queue.Peek(); // y = 2

            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
        }

        public void MyQueue_LinkList()
        {
            MyQueue_LinkList Queue = new MyQueue_LinkList();

            // 推入元素
            Queue.Enqueue(1);
            Queue.Enqueue(2);
            Queue.Enqueue(3);

            // 彈出元素
            int x = Queue.Dequeue();  // x = 1

            // 查看堆疊頂部元素
            int y = Queue.Peek(); // y = 2

            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
        }

        public void MyBinaryTree()
        {
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.Root = new TreeNode(1);
            binaryTree.Root.left = new TreeNode(2);
            binaryTree.Root.right = new TreeNode(3);
            binaryTree.Root.left.left = new TreeNode(4);
            binaryTree.Root.left.right = new TreeNode(5);

            Console.WriteLine("Preorder traversal of binary tree is ");
            binaryTree.PreOrder(binaryTree.Root);
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Inorder traversal of binary tree is ");
            binaryTree.InOrder(binaryTree.Root);
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Postorder traversal of binary tree is ");
            binaryTree.PostOrder(binaryTree.Root);
            Console.WriteLine("----------------------------------");
        }

        public void MyTrie()
        {
            Trie trie = new Trie();
            trie.Insert("apple");
            trie.Insert("application");
            trie.Insert("apply");
            trie.Insert("banana");
            Console.WriteLine(trie.Search("apple")); // true
            Console.WriteLine(trie.Search("app")); // false
            Console.WriteLine(trie.Search("ban")); // false
            Console.WriteLine(trie.Search("banana")); // true
        }
    }


    public class Test_Algorithm
    {
        public void BreathFirstSearch()
        {
            BreathFirstSearch BFS = new BreathFirstSearch();
            BreathFirstSearch.Node node1 = BFS.CreateNode(1);
            BreathFirstSearch.Node node2 = BFS.CreateNode(2);
            BreathFirstSearch.Node node3 = BFS.CreateNode(3);
            BreathFirstSearch.Node node4 = BFS.CreateNode(4);
            BreathFirstSearch.Node node5 = BFS.CreateNode(5);
            BreathFirstSearch.Node node6 = BFS.CreateNode(6);
            node1.AddChildrenNode(node2);
            node1.AddChildrenNode(node3);
            node2.AddChildrenNode(node4);
            node2.AddChildrenNode(node5);
            node3.AddChildrenNode(node6);
            BFS.Excute(node1);
        }

        public void DepthFirstSearch()
        {
            DepthFirstSearch DFS = new DepthFirstSearch();
            DepthFirstSearch.Node node1 = DFS.CreateNode(1);
            DepthFirstSearch.Node node2 = DFS.CreateNode(2);
            DepthFirstSearch.Node node3 = DFS.CreateNode(3);
            DepthFirstSearch.Node node4 = DFS.CreateNode(4);
            DepthFirstSearch.Node node5 = DFS.CreateNode(5);
            DepthFirstSearch.Node node6 = DFS.CreateNode(6);
            node1.AddChildrenNode(node2);
            node1.AddChildrenNode(node3);
            node2.AddChildrenNode(node4);
            node2.AddChildrenNode(node5);
            node3.AddChildrenNode(node6);
            DFS.Excute(node1);
        }

        public void BinarySearchTree()
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.Insert(5);
            tree.Insert(3);
            tree.Insert(7);
            tree.Insert(1);
            tree.Insert(9);
            Console.Write("InOrder traversal of binary tree is ");
            tree.InOrder();
        }

        public void BinaryHeap()
        {
            BinaryHeap heap = new BinaryHeap(5);
            heap.Insert(3);
            heap.Insert(1);
            heap.Insert(4);
            heap.Insert(2);
            heap.Insert(5);
            Console.WriteLine(heap.Remove());
            Console.WriteLine(heap.Remove());
            Console.WriteLine(heap.Remove());
            Console.WriteLine(heap.Remove());
            Console.WriteLine(heap.Remove());
        }
    }

    public class Test_Array_And_string
    {
        public void IsUniqueChars_Array()
        {
            Array_And_String arrayAndString = new Array_And_String();
            string test1 = "absdhrkx";
            Console.WriteLine(arrayAndString.IsUniqueChars_Array(test1));
            string test2 = "afgjggg";
            Console.WriteLine(arrayAndString.IsUniqueChars_Array(test2));
        }

        public void Permutation()
        {
            Array_And_String arrayAndString = new Array_And_String();
            string source = "abc";
            string compare = "bca";
            Console.WriteLine(arrayAndString.Permutation_Array(source, compare));
        }

        public void ReplaceSpace()
        {
            Array_And_String arrayAndString = new Array_And_String();
            char[] source = "Mr John Smith     ".ToArray();
            string result = arrayAndString.ReplaceSpace_Count(source, 13);
            Console.WriteLine(result);
        }

        public void PernutationOfPalindrome()
        {
            Array_And_String arrayAndString = new Array_And_String();
            string str = "Tact Coa";
            Console.WriteLine(arrayAndString.isPermutationOfPalindrome_Dict(str));
        }

        public void OneEditAway()
        {
            Array_And_String arrayAndString = new Array_And_String();
            string str1 = "pale";
            string str2 = "ale";
            Console.WriteLine(arrayAndString.IsOneEditAway_Three(str1, str2));
        }

        public void Compress()
        {
            Array_And_String arrayAndString = new Array_And_String();
            string str1 = "AAAABCDDD";
            Console.WriteLine(arrayAndString.Compress_WithCompare(str1));

        }

        public void Rotate()
        {
            Array_And_String arrayAndString = new Array_And_String();
            int[,] matrix = new int[,] { { 1, 2 }, { 3, 4 } };


            int[,] result = arrayAndString.Rotate(matrix);

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write("{0} ", matrix[i, j]);
                }
                Console.WriteLine();
            }

        }

        public void SetZero()
        {
            Array_And_String arrayAndString = new Array_And_String();
            int[,] matrix = new int[,] { { 1, 0, 3 }, { 3, 4, 5 } };


            int[,] result = arrayAndString.SetZero_BooleanArray(matrix);

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write("{0} ", matrix[i, j]);
                }
                Console.WriteLine();
            }

        }

    }

    public class Test_Linked_List
    {
        public void DeleteRepeatNode()
        {
            int[] data = { 1, 2, 3, 4, 5, 5, 6, 3 };
            LinkedList<int> linkedList = new LinkedList<int>(data);
            Linked_List linked_List = new Linked_List();
            linkedList = linked_List.DeleteRepeatNode(linkedList);
            linked_List.Display<int>(linkedList);
        }

        public void NthToLast()
        {
            Question.LinkedListNode head = new Question.LinkedListNode(1);
            head.next = new Question.LinkedListNode(2);
            head.next.next = new Question.LinkedListNode(3);
            head.next.next.next = new Question.LinkedListNode(4);
            head.next.next.next.next = new Question.LinkedListNode(5);
            head.next.next.next.next.next = new Question.LinkedListNode(6);
            Linked_List linked_List = new Linked_List();
            Console.WriteLine(linked_List.NthToLast(head, 2).data);
        }

        public void DeleteMidNode()
        {
            Linked_List linked_List = new Linked_List();
            Question.LinkedListNode head = new Question.LinkedListNode(1);
            head.next = new Question.LinkedListNode(2);
            head.next.next = new Question.LinkedListNode(3);
            head.next.next.next = new Question.LinkedListNode(4);
            head.next.next.next.next = new Question.LinkedListNode(5);
            head.next.next.next.next.next = new Question.LinkedListNode(6);
            linked_List.DeleteMidNode(head.next.next.next);
            linked_List.Display(head);
        }

        public void Partition()
        {
            Question.LinkedListNode head = new Question.LinkedListNode(3);
            head.next = new Question.LinkedListNode(8);
            head.next.next = new Question.LinkedListNode(9);
            head.next.next.next = new Question.LinkedListNode(2);
            head.next.next.next.next = new Question.LinkedListNode(7);
            head.next.next.next.next.next = new Question.LinkedListNode(2);
            Linked_List linked_List = new Linked_List();
            linked_List.Partition(head, 3);
            linked_List.Display(head);
        }

        public void addLists()
        {
            Question.LinkedListNode l1 = new Question.LinkedListNode(7);
            l1.next = new Question.LinkedListNode(1);
            l1.next.next = new Question.LinkedListNode(6);
            Question.LinkedListNode l2 = new Question.LinkedListNode(5);
            l2.next = new Question.LinkedListNode(9);
            l2.next.next = new Question.LinkedListNode(2);
            Linked_List linked_List = new Linked_List();
            Question.LinkedListNode head = linked_List.addLists(l1, l2);
            linked_List.Display(head);
        }
        public void addLists_Recursive()
        {
            Question.LinkedListNode l1 = new Question.LinkedListNode(7);
            l1.next = new Question.LinkedListNode(1);
            l1.next.next = new Question.LinkedListNode(6);
            Question.LinkedListNode l2 = new Question.LinkedListNode(5);
            l2.next = new Question.LinkedListNode(9);
            l2.next.next = new Question.LinkedListNode(2);
            Linked_List linked_List = new Linked_List();
            Question.LinkedListNode head = linked_List.addList_Recursion(l1, l2);
            linked_List.Display(head);
        }

        public void IsPalindrome()
        {
            Question.LinkedListNode l1 = new Question.LinkedListNode(1);
            l1.next = new Question.LinkedListNode(3);
            l1.next.next = new Question.LinkedListNode(1);
            Linked_List linked_List = new Linked_List();
            Console.WriteLine(linked_List.IsPalindrome(l1));
        }
    }
}