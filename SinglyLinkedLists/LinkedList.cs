using System;
using System.Collections.Generic;
using System.Text;

namespace SinglyLinkedLists
{
    public class LinkedList
    {
        /// <summary>
        /// This goes through the linked list having two pointers. both originally pointing at the head. 
        /// if the count is greater than 5 then the second pointer becomes valid and moves forward by one with the header lagging behind it by 5
        /// </summary>
        /// <param name="intList"></param>
        /// <returns></returns>
        public  int FifthElementFromEnd(LinkedList<int> intList)
        {
            
            LinkedListNode<int> header = intList.First;

            LinkedListNode<int> fifthElement = intList.First;

            int counter = 1;

            if (fifthElement is null)
            {
                throw new Exception("List is empty");
            }

            while (header.Next != null)
            {
                counter++;
                header = header.Next;
                if (counter > 5)
                {
                    fifthElement = fifthElement.Next;
                }
                

            }

            if (fifthElement == intList.First && counter != 5)
            {
                throw new Exception("List does not contain 5 elements");
            }
            else return fifthElement.Value;

        }

        /// <summary>
        /// This goes through the linked list having two pointers. both originally pointing at the head. 
        /// if the count is greater than 5 then the second pointer becomes valid and moves forward by one with the header lagging behind it by 5
        /// </summary> 
        /// <param name="intList"></param>
        /// <returns></returns>
        public string FifthElementFromEnd(LinkedList<string> intList)
        {


            LinkedListNode<string> header = intList.First;

            LinkedListNode<string> fifthElement = intList.First;

            int counter = 1;

            if (fifthElement is null)
            {
                throw new Exception("List is empty");
            }

            while (header.Next != null)
            {
                counter++;
                header = header.Next;
                if (counter > 5)
                {
                    fifthElement = fifthElement.Next;
                }


            }

            if (fifthElement == intList.First && counter != 5)
            {
                throw new Exception("List does not contain 5 elements");
            }
            else return fifthElement.Value;

        }

    }
}
