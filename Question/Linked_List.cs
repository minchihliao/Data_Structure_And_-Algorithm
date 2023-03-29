namespace Question
{
    public class LinkedListNode
    {
        public int data;
        public LinkedListNode next;

        public LinkedListNode(int val)
        {
            this.data = val;
            this.next = null;
        }
    }

    public class Linked_List
    {
        public void Display<T>(LinkedList<T> linkedList)
        {
            foreach (var data in linkedList)
            {
                Console.WriteLine(data + " ");
            }
        }
        public void Display(LinkedListNode head)
        {
            while (!(head == null))
            {
                Console.WriteLine(head.data + " ");
                head = head.next;
            }
        }
        #region DeleteRepeateNode
        public LinkedList<int> DeleteRepeatNode(LinkedList<int> linkedList)
        {
            HashSet<int> hashSet = new HashSet<int>();
            LinkedList<int> newList = new LinkedList<int>();
            foreach (int val in linkedList)
            {
                if (!hashSet.Contains(val))
                {
                    hashSet.Add(val);
                    newList.AddLast(val);
                }
            }
            return newList;
        }

        #endregion

        public LinkedListNode NthToLast(LinkedListNode head, int k)
        {
            LinkedListNode first = head;
            LinkedListNode second = head;

            for (int i = 0; i < k; i++)
            {
                if (first == null) return null;
                first = first.next;
            }

            while (first != null)
            {
                first = first.next;
                second = second.next;
            }
            return second;
        }

        public void DeleteMidNode(LinkedListNode midNode)
        {
            midNode.data = midNode.next.data;
            midNode.next = midNode.next.next;
        }

        public LinkedListNode Partition(LinkedListNode node, int x)
        {
            LinkedListNode leftHead = null;
            LinkedListNode leftTail = null;
            LinkedListNode rightHead = null;
            LinkedListNode rightTail = null;
            while (node != null)
            {
                LinkedListNode next = node.next;
                node.next = null;
                if (node.data <= x)
                {
                    if (leftHead == null)
                    {
                        leftHead = node;
                        leftTail = leftHead;
                    }
                    else
                    {
                        leftTail.next = node;
                        leftTail = node;
                    }
                }
                else
                {
                    if (rightHead == null)
                    {
                        rightHead = node;
                        rightTail = rightHead;
                    }
                    else
                    {
                        rightTail.next = node;
                        rightTail = node;
                    }
                }
                node = next;
            }

            if (leftHead == null)
                return rightHead;

            leftTail.next = rightHead;
            return leftHead;
        }

        public LinkedListNode addLists(LinkedListNode l1, LinkedListNode l2)
        {
            int result = 0;

            if (l1 != null)
            {
                result += l1.data;
                l1 = l1.next;
            }

            if (l2 != null)
            {
                result += l2.data;
                l2 = l2.next;
            }

            LinkedListNode head = new LinkedListNode(result % 10);
            LinkedListNode temp = head;
            int carry = 0;
            if (result > 10)
                carry++;

            while (l1 != null || l2 != null || carry != 0)
            {
                result = 0;
                if (l1 != null)
                {
                    result += l1.data;
                    l1 = l1.next;
                }

                if (l2 != null)
                {
                    result += l2.data;
                    l2 = l2.next;
                }
                result += carry;
                carry = 0;
                LinkedListNode newNode = new LinkedListNode(result % 10);
                if (result > 10)
                    carry++;
                temp.next = newNode;
                temp = newNode;
            }

            return head;

        }

        public LinkedListNode addList_Recursion(LinkedListNode l1, LinkedListNode l2, int carry = 0)
        {
            if (l1 == null && l2 == null)
                return null;
            LinkedListNode result = new LinkedListNode(0);
            LinkedListNode temp = result;
            int val = carry;
            if (l1 != null)
                val += l1.data;
            if (l2 != null)
                val += l2.data;
            result.data = val % 10;

            if (l1 != null || l2 != null)
            {
                LinkedListNode more = addList_Recursion(l1 == null ? null : l1.next,
                                                        l2 == null ? null : l2.next,
                                                        val >= 10 ? 1 : 0);
                temp.next = more;
            }
            return result;
        }

        public Boolean IsPalindrome(LinkedListNode node)
        {
            LinkedListNode fast = node;
            LinkedListNode slow = node;
            Stack<int> stack = new Stack<int>();
            while (fast != null && fast.next != null)
            {
                stack.Push(slow.data);
                slow = slow.next;
                fast = fast.next.next;
            }
            if (fast != null)
            {
                slow = slow.next;
            }

            while (slow != null)
            {
                if (slow.data != stack.Pop())
                    return false;
                slow = slow.next;
            }

            return true;

        }

    }


}