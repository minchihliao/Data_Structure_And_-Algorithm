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
    }
}