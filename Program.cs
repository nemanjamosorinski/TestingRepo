using System;

namespace LinkedListProject
{
//branch testing 2
    class Program
    {
        static void Main(string[] args)
        {
            GenericLinkedList<int> numberList = new GenericLinkedList<int>();

            //git test
            numberList.AddAtTail(1);
            numberList.AddAtTail(2);
            numberList.AddAtTail(3);
            numberList.Add(2, 4);
            numberList.Add(0, 6);

            Console.WriteLine("BEFORE REMOVING:");
            Console.WriteLine("*******************************");
            Console.WriteLine();
            numberList.PrintLinkedList();

            Console.WriteLine("AFTER REMOVING:");
            Console.WriteLine("*******************************");
            Console.WriteLine();
            numberList.Remove(3);
            numberList.PrintLinkedList();

            GenericLinkedList<string> stringList = new GenericLinkedList<string>();

            Console.WriteLine("BEFORE REMOVING:");
            Console.WriteLine("*******************************");
            Console.WriteLine();
            stringList.Add(0, "First");
            stringList.Add(1, "Second");
            stringList.Add(2, "Third");
            stringList.AddAtTail("Fourth");
            stringList.Add(2, "Fifth");
            stringList.PrintLinkedList();

            Console.WriteLine("AFTER REMOVING:");
            Console.WriteLine("*******************************");
            Console.WriteLine();
            stringList.Remove(1);
            stringList.PrintLinkedList();
            
            Console.WriteLine();
            Console.WriteLine("PLEASE ENTER THE VALUE OF THE ELEMENT YOU WANT TO FIND IN LINKED LIST:");
            
            var item = Console.ReadLine();
            
            if (stringList.Contains(item) == true)
            {
                Console.WriteLine("ELEMENT WITH VALUE: {0} IS FOUND IN THE LIST!", item);
            }
            else
            {
                Console.WriteLine("ELEMENT WITH VALUE: {0} IS NOT FOUND IN THE LIST!", item);
            }

            Console.WriteLine();
            Console.WriteLine("PLEASE ENTER POSITION OF ELEMENT IN LINKED LIST:");
            string position = Console.ReadLine();
            int pos;
            
            if (int.TryParse(position, out pos))
            {
                if(pos > numberList.Count)
                {
                    Console.WriteLine("INDEX IS TOO LARGE. INDEX OF LAST ELEMENT IN THE LIST IS: {0}", numberList.Count.ToString());
                }
                else if (numberList.Count < pos)
                {
                    Console.WriteLine("POSITION OF ELEMENT IS OUT OF RANGE. ELEMENT ON POSITION: {0} IS NOT EXISTING. \nELEMENT ON THE LAST POSITION HAS INDEX: {1}", pos, numberList.Count.ToString());
                }
                else if (pos < 0)
                {
                    Console.WriteLine("POSITION OF ELEMENT IS OUT OF RANGE. ELEMENT POSITION CAN NOT BE NEGATIVE NUMBER!");
                }
                else
                {
                    Console.WriteLine("ELEMENT AT POSITION {0} HAS VALUE: {1}", position, numberList.Get(pos));
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("WRONG FORMAT! PLEASE ENTER A NUMBER VALUE.");
            }
            Console.WriteLine();
            Console.WriteLine("ENTER THE VALUE OF ELEMENT TO GET IT'S INDEX:");
            var elementIndex = Console.ReadLine();
            if (stringList.IndexOf(elementIndex) != -1)
            {
                Console.WriteLine("ELEMENT: {0} HAS INDEX: {1}", elementIndex, stringList.IndexOf(elementIndex));
            }
            else
            {
                Console.WriteLine("ELEMENT IS NOT EXISTING!");
            }

            GenericLinkedList<int> specialList = new GenericLinkedList<int>();

            specialList.SpecialAdd(1);
            specialList.SpecialAdd(5);

            Console.ReadLine();
        }
    }
}
