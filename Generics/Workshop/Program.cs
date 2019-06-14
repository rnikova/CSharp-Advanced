namespace Workshop
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            var doublyLinkedList = new DoublyLinkedList();

            //doublyLinkedList.AddFirst(1);
            //doublyLinkedList.AddFirst(2);
            //doublyLinkedList.AddFirst(3);

            //doublyLinkedList.Print(Console.WriteLine);
            //Console.WriteLine(doublyLinkedList.Count==3);

            doublyLinkedList.AddLast(1);
            doublyLinkedList.AddLast(2);
            doublyLinkedList.AddLast(3);

            doublyLinkedList.RemoveFirst();

            Console.WriteLine(doublyLinkedList.Count == 2);
            doublyLinkedList.Print(Console.WriteLine);
        }
    }
}
