namespace Question
{
    public class Stack_And_Queue
    {
        public class FixedMutiStack
        {
            private int stackNumber = 3;
            private int stackCapacity;
            private int[] sizes;
            private int[] values;

            public FixedMutiStack(int stackCapacity)
            {
                this.stackCapacity = stackCapacity;
                this.values = new int[stackCapacity * stackNumber];
                this.sizes = new int[stackNumber];
            }

            public void Push(int stackNum, int val)
            {
                if (isFull(stackNum))
                    throw new StackOverflowException();

                sizes[stackNum]++;
                values[getValuesTopIndex(stackNum)] = val;
            }

            public int Pop(int stackNum)
            {
                if (isEmpty(stackNum))
                    throw new IndexOutOfRangeException();

                int topIndex = getValuesTopIndex(stackNum);
                int val = values[topIndex];
                values[topIndex] = 0;
                sizes[stackNum]--;
                return val;
            }

            public int Peek(int stackNum)
            {
                if (isEmpty(stackNum))
                    throw new IndexOutOfRangeException();

                return values[getValuesTopIndex(stackNum)];
            }
            private Boolean isEmpty(int stackNum)
            {
                return sizes[stackNum] == 0;
            }
            private Boolean isFull(int stackNum)
            {
                return sizes[stackNum] == stackCapacity;
            }

            private int getValuesTopIndex(int stackNum)
            {
                int offset = stackNum * stackCapacity;
                int size = sizes[stackNum];
                return offset + size - 1;
            }
        }

        public class StackWithMin
        {
            private Stack<int> stack = new Stack<int>();
            private Stack<int> minStack = new Stack<int>();

            public void Push(int val)
            {
                if (val <= Min())
                {
                    minStack.Push(val);
                    
                }
                stack.Push(val);
            }

            public int Pop()
            {
                int val = stack.Pop();
                if (val == Min())
                {
                    minStack.Pop();
                }
                return val;
            }

            public int Min()
            {
                if (minStack.Count == 0)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    return minStack.Pop();
                }

            }
        }
    }

}