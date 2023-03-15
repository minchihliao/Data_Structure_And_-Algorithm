namespace DataStructure{
    class Test{
        public void ArrayList(){
            ArrayList test = new ArrayList();
            test.Add(3.16);
            test.Add(5);
            test.Add("String");
            Console.WriteLine(test.Get(1));
            test.RemoveAt(1);
            Console.WriteLine(test.Get(1));
        }

        public void StringBuilder(){

            StringBuilder sb = new StringBuilder(50);
            sb.Append("ABC");
            sb.Append("CDF");
            Console.WriteLine(sb.Capacity);
            Console.WriteLine(sb.Length);
            Console.WriteLine(sb.ToString());
        }

        public void MyLinkList(){
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

            llist.Insert(llist.Head.next,9);
            Console.WriteLine("\nLinked List after "
                        + "Insert 9 at Position 2-3: ");
            llist.PrintList();
        }

        public void MyDoubleLinkList(){
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
    }
}