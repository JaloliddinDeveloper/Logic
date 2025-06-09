namespace LearnLinkedList.Classes
{
    public class LinkedListL
    {
        private Node Head;

        public LinkedListL()
        {
            Head = null;
        }

        public void AddLast(int value)
        {
            Node newNode = new Node(value);
            if (Head == null)
            {
                Head = newNode;
                return;
            }

            Node current = Head;

            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }

        public void AddFirst(int value)
        {
            Node newNode = new Node(value);
            newNode.Next = Head;
            Head = newNode;
        }

        public void Print()
        {
            Node current = Head;

            while (current != null)
            {
                Console.Write(current.Value + "->");
                current = current.Next;
            }

            Console.WriteLine("null");
        }

        public void PrintEven()
        {
            Node current = Head;

            while (current != null)
            {
                if (current.Value % 2 == 0)
                {
                    Console.WriteLine(current.Value + "->");
                }
                current = current.Next;
            }
            Console.WriteLine("null");
        }


        public void PrintOdd()
        {
            Node current = Head;
            while (current != null)
            {
                if (current.Value % 2 != 0)
                {
                    Console.WriteLine(current.Value + "->");
                }
                current = current.Next;
            }
            Console.WriteLine("null");
        }

        public void Remove(int value)
        {
            if (Head == null)
                return;

            if (Head.Value == value)
            {
                Head = Head.Next;
                return;
            }

            Node current = Head;

            while (current.Value != null)
            {
                if (current.Next.Value == value)
                {
                    current.Next = current.Next.Next;
                    return;
                }
                current = current.Next;
            }
        }


       
    }
}
